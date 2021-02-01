﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FluentFTP;
using ModioX.Extensions;
using ModioX.Forms.Windows;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Humanizer;
using FtpExtensions = ModioX.Extensions.FtpExtensions;
using StringExtensions = ModioX.Extensions.StringExtensions;

namespace ModioX.Forms.Tools.PS3_Tools
{
    public partial class PackageManager : XtraForm
    {
        public PackageManager()
        {
            InitializeComponent();
        }

        private FtpClient FtpClient { get; } = MainWindow.FtpClient;

        private string PackageFilesPath { get; } = "/dev_hdd0/packages";

        private List<FtpListItem> PackageFiles { get; set; } = new();

        private void PackageManager_Load(object sender, EventArgs e)
        {
        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            LoadPackages();
            TimerWait.Enabled = false;
        }

        private void LoadPackages()
        {
            GridPackageFiles.DataSource = null;

            var packages = DataExtensions.CreateDataTable(new List<DataColumn>()
            {
                new("File Name", typeof(string)),
                new("File Size", typeof(string)),
                new(" ", typeof(string))
            });

            FtpClient.SetWorkingDirectory(PackageFilesPath);

            foreach (var listItem in FtpClient.GetListing(PackageFilesPath))
            {
                switch (listItem.Type)
                {
                    case FtpFileSystemObjectType.File when listItem.Name.EndsWith(".pkg"):
                        PackageFiles.Add(listItem);
                        break;

                    case FtpFileSystemObjectType.Directory:
                        break;

                    case FtpFileSystemObjectType.Link:
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            foreach (var package in PackageFiles)
            {
                packages.Rows.Add(package.Name, MainWindow.Settings.ShowFileSizeInBytes ? package.Size.Bytes().Humanize() : package.Size.Bytes().Humanize("MB"));
            }

            GridPackageFiles.DataSource = packages;

            GridViewPackageFiles.Columns[0].Width = 350;
            GridViewPackageFiles.Columns[1].Width = 125;

            ProgressPackageFiles.Visible = packages.Rows.Count < 1;

            // Check all package files for newer versions
            foreach (var packageFile in PackageFiles)
            {
                var installedPackageFile = MainWindow.Settings.GetInstalledPackageFile(packageFile.Name);

                if (installedPackageFile != null)
                {
                    if (MainWindow.Settings.IsPackageFileOldVersion(MainWindow.Database.ModsPS3, MainWindow.Database.CategoriesData, installedPackageFile))
                    {
                        if (XtraMessageBox.Show($"There is a new package version for: {packageFile.Name}.\n\nWould you like to update it?", "New File Version", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            MainWindow.Window.UninstallMods(MainWindow.Database.ModsPS3.GetModById(installedPackageFile.Id));
                            MainWindow.Window.InstallMods(MainWindow.Database.ModsPS3.GetModById(installedPackageFile.Id));
                        }
                    }
                }
            }

            ButtonDeleteAllPackageFiles.Enabled = packages.Rows.Count > 0;
        }

        private void GridViewPackageFiles_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            ButtonDeletePackageFile.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
            ButtonDownloadPackageFile.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
        }

        private void GridViewPackageFiles_RowClick(object sender, RowClickEventArgs e)
        {
            ButtonDeletePackageFile.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
            ButtonDownloadPackageFile.Enabled = GridViewPackageFiles.SelectedRowsCount > 0;
        }

        private void ButtonInstallPackageFile_Click(object sender, EventArgs e)
        {
            var localFilePath = DialogExtensions.ShowOpenFileDialog(this, "Choose Package File", "PKG Files (*.pkg)|*.pkg");

            if (!string.IsNullOrWhiteSpace(localFilePath))
            {
                var fileName = Path.GetFileName(localFilePath);
                var installFilePath = PackageFilesPath + "/" + fileName;

                if (FtpClient.FileExists(installFilePath))
                {
                    XtraMessageBox.Show("Package file with this name already exists on your console.", "Package File Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                UpdateStatus("Installing package file: " + fileName);
                FtpExtensions.UploadFile(localFilePath, installFilePath);
                UpdateStatus("Successfully installed package file.");
                LoadPackages();
            }
        }

        private void ButtonDeletePackageFile_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really want to delete the selected package file from your console?", "Delete Selected", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var packageFileName = GridViewPackageFiles.GetRowCellValue(GridViewPackageFiles.FocusedRowHandle, GridViewPackageFiles.Columns[0]).ToString();

                UpdateStatus($"Deleting package file: {packageFileName}");
                FtpExtensions.DeleteFile(MainWindow.FtpClient, PackageFilesPath + "/" + packageFileName);
                UpdateStatus($"Successfully deleted package file.");
                LoadPackages();
            }
        }

        private void ButtonDeleteAllPackageFiles_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Do you really to delete all of your package files from your console?", "Delete All", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (var package in PackageFiles)
                {
                    UpdateStatus($"Deleting package file: {package.Name}");
                    FtpExtensions.DeleteFile(MainWindow.FtpClient, PackageFilesPath + "/" + package.Name);
                    UpdateStatus($"Successfully deleted package file.");
                    LoadPackages();
                }
            }
        }

        private void ButtonDownloadPackageFile_Click(object sender, EventArgs e)
        {
            var updateUrl = PackageFilesPath + "/" + GridViewPackageFiles.GetRowCellValue(GridViewPackageFiles.FocusedRowHandle, GridViewPackageFiles.Columns[0]).ToString();
            var fileName = Path.GetFileName(updateUrl);
            var folderPath = DialogExtensions.ShowFolderBrowseDialog(this, "Select the folder where you want to download the package file.");

            if (!string.IsNullOrWhiteSpace(folderPath))
            {
                UpdateStatus("Downloading file: " + fileName);
                HttpExtensions.DownloadFile(updateUrl, folderPath + "/" + fileName);
                UpdateStatus("Successfully downloaded file to the specified folder.");
                LoadPackages();
            }
        }

        /// <summary>
        /// Set the current status.
        /// </summary>
        /// <param name="text"> </param>
        private void UpdateStatus(string text)
        {
            LabelStatus.Caption = text;
            Refresh();
        }
    }
}