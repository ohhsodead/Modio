﻿using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace ModioX.Forms.Windows
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.ContextMenuMods = new DarkUI.Controls.DarkContextMenu();
            this.ContextMenuModsInstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsUninstallFiles = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsDownloadArchive = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeparator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsAddToList = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsRemoveFromList = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenuModsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ContextMenuModsReportOnGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelSelectType = new System.Windows.Forms.Label();
            this.FlowPanelDetails = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleModDetails = new DarkUI.Controls.DarkTitle();
            this.LabelHeaderName = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelHeaderCategory = new System.Windows.Forms.Label();
            this.LabelCategory = new System.Windows.Forms.Label();
            this.LabelHeaderFirmware = new System.Windows.Forms.Label();
            this.LabelFirmware = new System.Windows.Forms.Label();
            this.LabelHeaderModType = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.LabelHeaderVersion = new System.Windows.Forms.Label();
            this.LabelVersion = new System.Windows.Forms.Label();
            this.LabelHeaderRegion = new System.Windows.Forms.Label();
            this.LabelRegion = new System.Windows.Forms.Label();
            this.LabelHeaderGameType = new System.Windows.Forms.Label();
            this.LabelConfig = new System.Windows.Forms.Label();
            this.LabelHeaderAuthor = new System.Windows.Forms.Label();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.LabelHeaderSubmittedBy = new System.Windows.Forms.Label();
            this.LabelSubmittedBy = new System.Windows.Forms.Label();
            this.LabelTitleModDescription = new DarkUI.Controls.DarkTitle();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.SectionModsInstallFilePaths = new DarkUI.Controls.DarkSectionPanel();
            this.GridControlModsInstallFiles = new DevExpress.XtraGrid.GridControl();
            this.GridViewModsInstallFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.LabelHeaderInstallationFiles = new DarkUI.Controls.DarkTitle();
            this.ColumnInstallationFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrollBarDetails = new DarkUI.Controls.DarkScrollBar();
            this.SectionArchiveInformation = new DarkUI.Controls.DarkSectionPanel();
            this.PanelModsInstallationPaths = new System.Windows.Forms.Panel();
            this.ToolStripArchiveInformation = new DarkUI.Controls.DarkToolStrip();
            this.ToolItemModInstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModUninstall = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModDownload = new System.Windows.Forms.ToolStripButton();
            this.ToolItemModAddToFavorite = new System.Windows.Forms.ToolStripButton();
            this.ToolStripLabelConnectedConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelConsole = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripStatusSeperator0 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripLabelStats = new System.Windows.Forms.ToolStripLabel();
            this.LabelSelectSystemType = new System.Windows.Forms.Label();
            this.LabelNoModsFound = new System.Windows.Forms.Label();
            this.GridControlMods = new DevExpress.XtraGrid.GridControl();
            this.GridViewMods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.PanelModsLibraryFilters = new System.Windows.Forms.Panel();
            this.ComboBoxRegion = new DevExpress.XtraEditors.ComboBoxEdit();
            this.MainMenu = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.ConnectMenuBar = new DevExpress.XtraBars.BarButtonItem();
            this.ConnectMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.PS3ConnectMenu = new DevExpress.XtraBars.BarSubItem();
            this.PS3ConnectButton = new DevExpress.XtraBars.BarButtonItem();
            this.XBConsole = new DevExpress.XtraBars.BarSubItem();
            this.Xbox360ConnectButton = new DevExpress.XtraBars.BarButtonItem();
            this.ToolsMenuBar = new DevExpress.XtraBars.BarButtonItem();
            this.ToolsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.GameBackupFilesButton = new DevExpress.XtraBars.BarButtonItem();
            this.GameUpdateFinderButton = new DevExpress.XtraBars.BarButtonItem();
            this.FileManagerButton = new DevExpress.XtraBars.BarButtonItem();
            this.PackageManagerButton = new DevExpress.XtraBars.BarButtonItem();
            this.WebManControlsMenu = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.ShutDownButtonBar = new DevExpress.XtraBars.BarButtonItem();
            this.RestartButtonBar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem20 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem21 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem23 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem24 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem26 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem17 = new DevExpress.XtraBars.BarButtonItem();
            this.ApplicationMenuBar = new DevExpress.XtraBars.BarButtonItem();
            this.ApplicationsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem27 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem28 = new DevExpress.XtraBars.BarButtonItem();
            this.OptionsMenuBar = new DevExpress.XtraBars.BarButtonItem();
            this.OptionsMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.AddConsoleButton = new DevExpress.XtraBars.BarButtonItem();
            this.EditGameRegionButton = new DevExpress.XtraBars.BarButtonItem();
            this.EditApplicationsButton = new DevExpress.XtraBars.BarButtonItem();
            this.EditYourLists = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.Exitbutton = new DevExpress.XtraBars.BarButtonItem();
            this.HelpMenuBar = new DevExpress.XtraBars.BarButtonItem();
            this.HelpMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.ReportBugButton = new DevExpress.XtraBars.BarButtonItem();
            this.DiscordServerButton = new DevExpress.XtraBars.BarButtonItem();
            this.OfficailSourceButton = new DevExpress.XtraBars.BarButtonItem();
            this.OpenLogFileButton = new DevExpress.XtraBars.BarButtonItem();
            this.OpenLogFolderButton = new DevExpress.XtraBars.BarButtonItem();
            this.CheckForUpdateButton = new DevExpress.XtraBars.BarButtonItem();
            this.WhatsNewButton = new DevExpress.XtraBars.BarButtonItem();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.AboutBar = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.HeaderConsoleConnected = new DevExpress.XtraBars.BarHeaderItem();
            this.LabelConsoleConnected = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            this.HelpSpacer1 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpSpacer2 = new DevExpress.XtraBars.BarButtonItem();
            this.HelpSpacer3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockingMenuItem1 = new DevExpress.XtraBars.BarDockingMenuItem();
            this.barToolbarsListItem2 = new DevExpress.XtraBars.BarToolbarsListItem();
            this.ComboBoxModType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ComboBoxSystemType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelSelectRegion = new System.Windows.Forms.Label();
            this.LabelTitleMods = new DarkUI.Controls.DarkTitle();
            this.LabelTitleFilterMods = new DarkUI.Controls.DarkTitle();
            this.TextBoxSearch = new DarkUI.Controls.DarkTextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.ColumnModsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsFirmware = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsNoFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnModsDownload = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnModsFavourite = new System.Windows.Forms.DataGridViewImageColumn();
            this.SectionGames = new DarkUI.Controls.DarkSectionPanel();
            this.ScrollBarCategories = new DarkUI.Controls.DarkScrollBar();
            this.FlowPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleGames = new DarkUI.Controls.DarkTitle();
            this.PanelGames = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleHomebrew = new DarkUI.Controls.DarkTitle();
            this.PanelHomebrew = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleResources = new DarkUI.Controls.DarkTitle();
            this.PanelResources = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelTitleMyLists = new DarkUI.Controls.DarkTitle();
            this.PanelLists = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelNoModsInstalled = new System.Windows.Forms.Label();
            this.GridControlGameModsInstalled = new DevExpress.XtraGrid.GridControl();
            this.GridViewGameModsInstalled = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ToolItemGameModsUninstallAll = new System.Windows.Forms.ToolStripButton();
            this.LabelInstalledGameModsStatus = new System.Windows.Forms.ToolStripLabel();
            this.ColumnModsInstalledId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledGameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledModType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledNoOfFiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnModsInstalledUninstall = new System.Windows.Forms.DataGridViewImageColumn();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.GroupModsLibrary = new DevExpress.XtraEditors.GroupControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.NavGroupGames = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupHomebrewApps = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupResources = new DevExpress.XtraNavBar.NavBarGroup();
            this.NavGroupMyLists = new DevExpress.XtraNavBar.NavBarGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.ContextMenuMods.SuspendLayout();
            this.FlowPanelDetails.SuspendLayout();
            this.SectionModsInstallFilePaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlModsInstallFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModsInstallFiles)).BeginInit();
            this.SectionArchiveInformation.SuspendLayout();
            this.PanelModsInstallationPaths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).BeginInit();
            this.PanelModsLibraryFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRegion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSystemType.Properties)).BeginInit();
            this.SectionGames.SuspendLayout();
            this.FlowPanelCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameModsInstalled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameModsInstalled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsLibrary)).BeginInit();
            this.GroupModsLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContextMenuMods
            // 
            this.ContextMenuMods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuMods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuMods.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextMenuMods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContextMenuModsInstallFiles,
            this.ContextMenuModsUninstallFiles,
            this.ContextMenuModsDownloadArchive,
            this.ContextMenuModsSeparator0,
            this.ContextMenuModsAddToList,
            this.ContextMenuModsRemoveFromList,
            this.ContextMenuModsSeparator1,
            this.ContextMenuModsReportOnGitHub});
            this.ContextMenuMods.Name = "ContextMenuConsole";
            this.ContextMenuMods.Size = new System.Drawing.Size(185, 174);
            // 
            // ContextMenuModsInstallFiles
            // 
            this.ContextMenuModsInstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsInstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsInstallFiles.Image = ((System.Drawing.Image)(resources.GetObject("ContextMenuModsInstallFiles.Image")));
            this.ContextMenuModsInstallFiles.Name = "ContextMenuModsInstallFiles";
            this.ContextMenuModsInstallFiles.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsInstallFiles.Text = "Install Files...";
            this.ContextMenuModsInstallFiles.Click += new System.EventHandler(this.ContextMenuModsInstallToConsole_Click);
            // 
            // ContextMenuModsUninstallFiles
            // 
            this.ContextMenuModsUninstallFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsUninstallFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsUninstallFiles.Image = ((System.Drawing.Image)(resources.GetObject("ContextMenuModsUninstallFiles.Image")));
            this.ContextMenuModsUninstallFiles.Name = "ContextMenuModsUninstallFiles";
            this.ContextMenuModsUninstallFiles.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsUninstallFiles.Text = "Uninstall Files...";
            this.ContextMenuModsUninstallFiles.Click += new System.EventHandler(this.ContextMenuModsUninstallFromConsole_Click);
            // 
            // ContextMenuModsDownloadArchive
            // 
            this.ContextMenuModsDownloadArchive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsDownloadArchive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsDownloadArchive.Image = ((System.Drawing.Image)(resources.GetObject("ContextMenuModsDownloadArchive.Image")));
            this.ContextMenuModsDownloadArchive.Name = "ContextMenuModsDownloadArchive";
            this.ContextMenuModsDownloadArchive.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsDownloadArchive.Text = "Download Archive...";
            this.ContextMenuModsDownloadArchive.Click += new System.EventHandler(this.ContextMenuModsDownloadArchive_Click);
            // 
            // ContextMenuModsSeparator0
            // 
            this.ContextMenuModsSeparator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsSeparator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsSeparator0.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuModsSeparator0.Name = "ContextMenuModsSeparator0";
            this.ContextMenuModsSeparator0.Size = new System.Drawing.Size(181, 6);
            // 
            // ContextMenuModsAddToList
            // 
            this.ContextMenuModsAddToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsAddToList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsAddToList.Image = global::ModioX.Properties.Resources.add_list;
            this.ContextMenuModsAddToList.Name = "ContextMenuModsAddToList";
            this.ContextMenuModsAddToList.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsAddToList.Text = "Add to List...";
            this.ContextMenuModsAddToList.Click += new System.EventHandler(this.ContextMenuModsAddToList_Click);
            // 
            // ContextMenuModsRemoveFromList
            // 
            this.ContextMenuModsRemoveFromList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsRemoveFromList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsRemoveFromList.Image = global::ModioX.Properties.Resources.delete_list;
            this.ContextMenuModsRemoveFromList.Name = "ContextMenuModsRemoveFromList";
            this.ContextMenuModsRemoveFromList.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsRemoveFromList.Text = "Remove from List...";
            this.ContextMenuModsRemoveFromList.Click += new System.EventHandler(this.ContextMenuModsRemoveFromList_Click);
            // 
            // ContextMenuModsSeparator1
            // 
            this.ContextMenuModsSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.ContextMenuModsSeparator1.Name = "ContextMenuModsSeparator1";
            this.ContextMenuModsSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // ContextMenuModsReportOnGitHub
            // 
            this.ContextMenuModsReportOnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextMenuModsReportOnGitHub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextMenuModsReportOnGitHub.Image = global::ModioX.Properties.Resources.bug;
            this.ContextMenuModsReportOnGitHub.Name = "ContextMenuModsReportOnGitHub";
            this.ContextMenuModsReportOnGitHub.Size = new System.Drawing.Size(184, 26);
            this.ContextMenuModsReportOnGitHub.Text = "Report an Issue";
            this.ContextMenuModsReportOnGitHub.Click += new System.EventHandler(this.ContextMenuModsReportOnGitHub_Click);
            // 
            // LabelSelectType
            // 
            this.LabelSelectType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectType.AutoSize = true;
            this.LabelSelectType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectType.Location = new System.Drawing.Point(556, 42);
            this.LabelSelectType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectType.Name = "LabelSelectType";
            this.LabelSelectType.Size = new System.Drawing.Size(64, 15);
            this.LabelSelectType.TabIndex = 1122;
            this.LabelSelectType.Text = "MOD TYPE";
            // 
            // FlowPanelDetails
            // 
            this.FlowPanelDetails.AutoScroll = true;
            this.FlowPanelDetails.AutoSize = true;
            this.FlowPanelDetails.Controls.Add(this.LabelTitleModDetails);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderName);
            this.FlowPanelDetails.Controls.Add(this.LabelName);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderCategory);
            this.FlowPanelDetails.Controls.Add(this.LabelCategory);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderFirmware);
            this.FlowPanelDetails.Controls.Add(this.LabelFirmware);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderModType);
            this.FlowPanelDetails.Controls.Add(this.LabelType);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelVersion);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderRegion);
            this.FlowPanelDetails.Controls.Add(this.LabelRegion);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderGameType);
            this.FlowPanelDetails.Controls.Add(this.LabelConfig);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelAuthor);
            this.FlowPanelDetails.Controls.Add(this.LabelHeaderSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.LabelSubmittedBy);
            this.FlowPanelDetails.Controls.Add(this.LabelTitleModDescription);
            this.FlowPanelDetails.Controls.Add(this.LabelDescription);
            this.FlowPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelDetails.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FlowPanelDetails.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelDetails.Margin = new System.Windows.Forms.Padding(0);
            this.FlowPanelDetails.Name = "FlowPanelDetails";
            this.FlowPanelDetails.Padding = new System.Windows.Forms.Padding(3, 8, 18, 4);
            this.FlowPanelDetails.Size = new System.Drawing.Size(375, 545);
            this.FlowPanelDetails.TabIndex = 0;
            this.FlowPanelDetails.TabStop = true;
            this.FlowPanelDetails.Scroll += new System.Windows.Forms.ScrollEventHandler(this.FlowPanelDetails_Scroll);
            this.FlowPanelDetails.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FlowPanelDetails_MouseWheel);
            // 
            // LabelTitleModDetails
            // 
            this.LabelTitleModDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleModDetails.Location = new System.Drawing.Point(8, 10);
            this.LabelTitleModDetails.Margin = new System.Windows.Forms.Padding(5, 2, 3, 3);
            this.LabelTitleModDetails.Name = "LabelTitleModDetails";
            this.LabelTitleModDetails.Size = new System.Drawing.Size(344, 17);
            this.LabelTitleModDetails.TabIndex = 1163;
            this.LabelTitleModDetails.Text = "DETAILS";
            // 
            // LabelHeaderName
            // 
            this.LabelHeaderName.AutoSize = true;
            this.LabelHeaderName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderName.Location = new System.Drawing.Point(5, 33);
            this.LabelHeaderName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderName.Name = "LabelHeaderName";
            this.LabelHeaderName.Size = new System.Drawing.Size(43, 15);
            this.LabelHeaderName.TabIndex = 26;
            this.LabelHeaderName.Text = "Name:";
            // 
            // LabelName
            // 
            this.LabelName.AutoEllipsis = true;
            this.LabelName.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelName, true);
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelName.Location = new System.Drawing.Point(50, 33);
            this.LabelName.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelName.MaximumSize = new System.Drawing.Size(300, 15);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(16, 15);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "...";
            // 
            // LabelHeaderCategory
            // 
            this.LabelHeaderCategory.AutoSize = true;
            this.LabelHeaderCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderCategory.Location = new System.Drawing.Point(5, 54);
            this.LabelHeaderCategory.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderCategory.Name = "LabelHeaderCategory";
            this.LabelHeaderCategory.Size = new System.Drawing.Size(60, 15);
            this.LabelHeaderCategory.TabIndex = 24;
            this.LabelHeaderCategory.Text = "Category:";
            // 
            // LabelCategory
            // 
            this.LabelCategory.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelCategory, true);
            this.LabelCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelCategory.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelCategory.Location = new System.Drawing.Point(67, 54);
            this.LabelCategory.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelCategory.Name = "LabelCategory";
            this.LabelCategory.Size = new System.Drawing.Size(16, 15);
            this.LabelCategory.TabIndex = 23;
            this.LabelCategory.Text = "...";
            // 
            // LabelHeaderFirmware
            // 
            this.LabelHeaderFirmware.AutoSize = true;
            this.LabelHeaderFirmware.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderFirmware.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderFirmware.Location = new System.Drawing.Point(5, 75);
            this.LabelHeaderFirmware.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderFirmware.Name = "LabelHeaderFirmware";
            this.LabelHeaderFirmware.Size = new System.Drawing.Size(80, 15);
            this.LabelHeaderFirmware.TabIndex = 20;
            this.LabelHeaderFirmware.Text = "System Type:";
            // 
            // LabelFirmware
            // 
            this.LabelFirmware.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelFirmware, true);
            this.LabelFirmware.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelFirmware.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelFirmware.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelFirmware.Location = new System.Drawing.Point(87, 75);
            this.LabelFirmware.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelFirmware.Name = "LabelFirmware";
            this.LabelFirmware.Size = new System.Drawing.Size(16, 15);
            this.LabelFirmware.TabIndex = 21;
            this.LabelFirmware.Text = "...";
            // 
            // LabelHeaderModType
            // 
            this.LabelHeaderModType.AutoSize = true;
            this.LabelHeaderModType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderModType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderModType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderModType.Location = new System.Drawing.Point(5, 96);
            this.LabelHeaderModType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderModType.Name = "LabelHeaderModType";
            this.LabelHeaderModType.Size = new System.Drawing.Size(64, 15);
            this.LabelHeaderModType.TabIndex = 16;
            this.LabelHeaderModType.Text = "Mod Type:";
            // 
            // LabelType
            // 
            this.LabelType.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelType, true);
            this.LabelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelType.Location = new System.Drawing.Point(71, 96);
            this.LabelType.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(16, 15);
            this.LabelType.TabIndex = 17;
            this.LabelType.Text = "...";
            // 
            // LabelHeaderVersion
            // 
            this.LabelHeaderVersion.AutoSize = true;
            this.LabelHeaderVersion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderVersion.Location = new System.Drawing.Point(5, 117);
            this.LabelHeaderVersion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderVersion.Name = "LabelHeaderVersion";
            this.LabelHeaderVersion.Size = new System.Drawing.Size(51, 15);
            this.LabelHeaderVersion.TabIndex = 3;
            this.LabelHeaderVersion.Text = "Version:";
            // 
            // LabelVersion
            // 
            this.LabelVersion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelVersion, true);
            this.LabelVersion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelVersion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelVersion.Location = new System.Drawing.Point(58, 117);
            this.LabelVersion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelVersion.Name = "LabelVersion";
            this.LabelVersion.Size = new System.Drawing.Size(16, 15);
            this.LabelVersion.TabIndex = 4;
            this.LabelVersion.Text = "...";
            // 
            // LabelHeaderRegion
            // 
            this.LabelHeaderRegion.AutoSize = true;
            this.LabelHeaderRegion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderRegion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderRegion.Location = new System.Drawing.Point(5, 138);
            this.LabelHeaderRegion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderRegion.Name = "LabelHeaderRegion";
            this.LabelHeaderRegion.Size = new System.Drawing.Size(85, 15);
            this.LabelHeaderRegion.TabIndex = 1164;
            this.LabelHeaderRegion.Text = "Game Region:";
            // 
            // LabelRegion
            // 
            this.LabelRegion.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelRegion, true);
            this.LabelRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelRegion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelRegion.Location = new System.Drawing.Point(92, 138);
            this.LabelRegion.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelRegion.Name = "LabelRegion";
            this.LabelRegion.Size = new System.Drawing.Size(16, 15);
            this.LabelRegion.TabIndex = 1165;
            this.LabelRegion.Text = "...";
            // 
            // LabelHeaderGameType
            // 
            this.LabelHeaderGameType.AutoSize = true;
            this.LabelHeaderGameType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderGameType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderGameType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderGameType.Location = new System.Drawing.Point(5, 159);
            this.LabelHeaderGameType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderGameType.Name = "LabelHeaderGameType";
            this.LabelHeaderGameType.Size = new System.Drawing.Size(72, 15);
            this.LabelHeaderGameType.TabIndex = 9;
            this.LabelHeaderGameType.Text = "Game Type:";
            // 
            // LabelConfig
            // 
            this.LabelConfig.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelConfig, true);
            this.LabelConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelConfig.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelConfig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelConfig.Location = new System.Drawing.Point(79, 159);
            this.LabelConfig.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelConfig.Name = "LabelConfig";
            this.LabelConfig.Size = new System.Drawing.Size(16, 15);
            this.LabelConfig.TabIndex = 10;
            this.LabelConfig.Text = "...";
            // 
            // LabelHeaderAuthor
            // 
            this.LabelHeaderAuthor.AutoSize = true;
            this.LabelHeaderAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderAuthor.Location = new System.Drawing.Point(5, 180);
            this.LabelHeaderAuthor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderAuthor.Name = "LabelHeaderAuthor";
            this.LabelHeaderAuthor.Size = new System.Drawing.Size(71, 15);
            this.LabelHeaderAuthor.TabIndex = 6;
            this.LabelHeaderAuthor.Text = "Created By:";
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelAuthor, true);
            this.LabelAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelAuthor.Location = new System.Drawing.Point(78, 180);
            this.LabelAuthor.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(16, 15);
            this.LabelAuthor.TabIndex = 15;
            this.LabelAuthor.Text = "...";
            // 
            // LabelHeaderSubmittedBy
            // 
            this.LabelHeaderSubmittedBy.AutoSize = true;
            this.LabelHeaderSubmittedBy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelHeaderSubmittedBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelHeaderSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelHeaderSubmittedBy.Location = new System.Drawing.Point(5, 201);
            this.LabelHeaderSubmittedBy.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.LabelHeaderSubmittedBy.Name = "LabelHeaderSubmittedBy";
            this.LabelHeaderSubmittedBy.Size = new System.Drawing.Size(86, 15);
            this.LabelHeaderSubmittedBy.TabIndex = 13;
            this.LabelHeaderSubmittedBy.Text = "Submitted By:";
            // 
            // LabelSubmittedBy
            // 
            this.LabelSubmittedBy.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelSubmittedBy, true);
            this.LabelSubmittedBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSubmittedBy.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSubmittedBy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSubmittedBy.Location = new System.Drawing.Point(93, 201);
            this.LabelSubmittedBy.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.LabelSubmittedBy.Name = "LabelSubmittedBy";
            this.LabelSubmittedBy.Size = new System.Drawing.Size(16, 15);
            this.LabelSubmittedBy.TabIndex = 14;
            this.LabelSubmittedBy.Text = "...";
            // 
            // LabelTitleModDescription
            // 
            this.LabelTitleModDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleModDescription.Location = new System.Drawing.Point(8, 223);
            this.LabelTitleModDescription.Margin = new System.Windows.Forms.Padding(5, 4, 3, 4);
            this.LabelTitleModDescription.Name = "LabelTitleModDescription";
            this.LabelTitleModDescription.Size = new System.Drawing.Size(344, 17);
            this.LabelTitleModDescription.TabIndex = 1162;
            this.LabelTitleModDescription.Text = "DESCRIPTION";
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.FlowPanelDetails.SetFlowBreak(this.LabelDescription, true);
            this.LabelDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDescription.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelDescription.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelDescription.Location = new System.Drawing.Point(5, 246);
            this.LabelDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 3);
            this.LabelDescription.MaximumSize = new System.Drawing.Size(410, 0);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.LabelDescription.Size = new System.Drawing.Size(16, 27);
            this.LabelDescription.TabIndex = 12;
            this.LabelDescription.Text = "...";
            // 
            // SectionModsInstallFilePaths
            // 
            this.SectionModsInstallFilePaths.Controls.Add(this.GridControlModsInstallFiles);
            this.SectionModsInstallFilePaths.Controls.Add(this.LabelHeaderInstallationFiles);
            this.SectionModsInstallFilePaths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SectionModsInstallFilePaths.Location = new System.Drawing.Point(0, 11);
            this.SectionModsInstallFilePaths.Margin = new System.Windows.Forms.Padding(0);
            this.SectionModsInstallFilePaths.Name = "SectionModsInstallFilePaths";
            this.SectionModsInstallFilePaths.SectionHeader = " ";
            this.SectionModsInstallFilePaths.Size = new System.Drawing.Size(375, 125);
            this.SectionModsInstallFilePaths.TabIndex = 26;
            // 
            // GridControlModsInstallFiles
            // 
            this.GridControlModsInstallFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlModsInstallFiles.Location = new System.Drawing.Point(1, 25);
            this.GridControlModsInstallFiles.MainView = this.GridViewModsInstallFiles;
            this.GridControlModsInstallFiles.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlModsInstallFiles.Name = "GridControlModsInstallFiles";
            this.GridControlModsInstallFiles.Size = new System.Drawing.Size(373, 99);
            this.GridControlModsInstallFiles.TabIndex = 3;
            this.GridControlModsInstallFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewModsInstallFiles});
            // 
            // GridViewModsInstallFiles
            // 
            this.GridViewModsInstallFiles.GridControl = this.GridControlModsInstallFiles;
            this.GridViewModsInstallFiles.Name = "GridViewModsInstallFiles";
            this.GridViewModsInstallFiles.OptionsView.ShowGroupPanel = false;
            // 
            // LabelHeaderInstallationFiles
            // 
            this.LabelHeaderInstallationFiles.BackColor = System.Drawing.Color.Transparent;
            this.LabelHeaderInstallationFiles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHeaderInstallationFiles.Location = new System.Drawing.Point(6, 5);
            this.LabelHeaderInstallationFiles.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.LabelHeaderInstallationFiles.Name = "LabelHeaderInstallationFiles";
            this.LabelHeaderInstallationFiles.Size = new System.Drawing.Size(362, 16);
            this.LabelHeaderInstallationFiles.TabIndex = 1163;
            this.LabelHeaderInstallationFiles.Text = "INSTALL FILES";
            // 
            // ColumnInstallationFiles
            // 
            this.ColumnInstallationFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnInstallationFiles.HeaderText = "Installation Files";
            this.ColumnInstallationFiles.Name = "ColumnInstallationFiles";
            this.ColumnInstallationFiles.ReadOnly = true;
            this.ColumnInstallationFiles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ScrollBarDetails
            // 
            this.ScrollBarDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarDetails.Location = new System.Drawing.Point(359, 25);
            this.ScrollBarDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.ScrollBarDetails.Name = "ScrollBarDetails";
            this.ScrollBarDetails.Size = new System.Drawing.Size(17, 556);
            this.ScrollBarDetails.TabIndex = 1133;
            this.ScrollBarDetails.Text = "darkScrollBar1";
            this.ScrollBarDetails.ViewSize = 1;
            this.ScrollBarDetails.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarDetails_ValueChanged);
            // 
            // SectionArchiveInformation
            // 
            this.SectionArchiveInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SectionArchiveInformation.Controls.Add(this.ScrollBarDetails);
            this.SectionArchiveInformation.Controls.Add(this.FlowPanelDetails);
            this.SectionArchiveInformation.Controls.Add(this.PanelModsInstallationPaths);
            this.SectionArchiveInformation.Controls.Add(this.ToolStripArchiveInformation);
            this.SectionArchiveInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionArchiveInformation.Location = new System.Drawing.Point(1195, 39);
            this.SectionArchiveInformation.Margin = new System.Windows.Forms.Padding(4, 4, 3, 4);
            this.SectionArchiveInformation.Name = "SectionArchiveInformation";
            this.SectionArchiveInformation.SectionHeader = "MOD INFORMATION";
            this.SectionArchiveInformation.Size = new System.Drawing.Size(377, 743);
            this.SectionArchiveInformation.TabIndex = 9;
            // 
            // PanelModsInstallationPaths
            // 
            this.PanelModsInstallationPaths.Controls.Add(this.SectionModsInstallFilePaths);
            this.PanelModsInstallationPaths.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelModsInstallationPaths.Location = new System.Drawing.Point(1, 570);
            this.PanelModsInstallationPaths.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsInstallationPaths.Name = "PanelModsInstallationPaths";
            this.PanelModsInstallationPaths.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.PanelModsInstallationPaths.Size = new System.Drawing.Size(375, 136);
            this.PanelModsInstallationPaths.TabIndex = 26;
            // 
            // ToolStripArchiveInformation
            // 
            this.ToolStripArchiveInformation.AutoSize = false;
            this.ToolStripArchiveInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripArchiveInformation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripArchiveInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripArchiveInformation.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripArchiveInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStripArchiveInformation.Location = new System.Drawing.Point(1, 706);
            this.ToolStripArchiveInformation.Name = "ToolStripArchiveInformation";
            this.ToolStripArchiveInformation.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.ToolStripArchiveInformation.Size = new System.Drawing.Size(375, 36);
            this.ToolStripArchiveInformation.TabIndex = 4;
            this.ToolStripArchiveInformation.TabStop = true;
            this.ToolStripArchiveInformation.Text = "darkToolStrip2";
            // 
            // ToolItemModInstall
            // 
            this.ToolItemModInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModInstall.Enabled = false;
            this.ToolItemModInstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModInstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModInstall.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemModInstall.Image")));
            this.ToolItemModInstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModInstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModInstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModInstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModInstall.Name = "ToolItemModInstall";
            this.ToolItemModInstall.Size = new System.Drawing.Size(66, 26);
            this.ToolItemModInstall.Text = "Install";
            this.ToolItemModInstall.ToolTipText = "Install to Console";
            this.ToolItemModInstall.Click += new System.EventHandler(this.ToolStripInstallFiles_Click);
            // 
            // ToolItemModUninstall
            // 
            this.ToolItemModUninstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModUninstall.Enabled = false;
            this.ToolItemModUninstall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModUninstall.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModUninstall.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemModUninstall.Image")));
            this.ToolItemModUninstall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModUninstall.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModUninstall.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModUninstall.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModUninstall.Name = "ToolItemModUninstall";
            this.ToolItemModUninstall.Size = new System.Drawing.Size(81, 26);
            this.ToolItemModUninstall.Text = "Uninstall";
            this.ToolItemModUninstall.ToolTipText = "Uninstall from Console";
            this.ToolItemModUninstall.Click += new System.EventHandler(this.ToolStripUninstallFiles_Click);
            // 
            // ToolItemModDownload
            // 
            this.ToolItemModDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModDownload.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemModDownload.Image")));
            this.ToolItemModDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModDownload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModDownload.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModDownload.Name = "ToolItemModDownload";
            this.ToolItemModDownload.Size = new System.Drawing.Size(89, 26);
            this.ToolItemModDownload.Text = "Download";
            this.ToolItemModDownload.ToolTipText = "Download Archive to Computer";
            this.ToolItemModDownload.Click += new System.EventHandler(this.ToolStripDownloadArchive_Click);
            // 
            // ToolItemModAddToFavorite
            // 
            this.ToolItemModAddToFavorite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemModAddToFavorite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemModAddToFavorite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemModAddToFavorite.Image = global::ModioX.Properties.Resources.heart;
            this.ToolItemModAddToFavorite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemModAddToFavorite.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemModAddToFavorite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemModAddToFavorite.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemModAddToFavorite.Name = "ToolItemModAddToFavorite";
            this.ToolItemModAddToFavorite.Size = new System.Drawing.Size(79, 26);
            this.ToolItemModAddToFavorite.Text = "Favorite";
            this.ToolItemModAddToFavorite.ToolTipText = "Add/Remove from Favorites";
            this.ToolItemModAddToFavorite.Click += new System.EventHandler(this.ToolStripFavorite_Click);
            // 
            // ToolStripLabelConnectedConsole
            // 
            this.ToolStripLabelConnectedConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConnectedConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConnectedConsole.Name = "ToolStripLabelConnectedConsole";
            this.ToolStripLabelConnectedConsole.Size = new System.Drawing.Size(96, 24);
            this.ToolStripLabelConnectedConsole.Text = "PS3 Connected  :";
            // 
            // ToolStripLabelConsole
            // 
            this.ToolStripLabelConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelConsole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelConsole.Name = "ToolStripLabelConsole";
            this.ToolStripLabelConsole.Size = new System.Drawing.Size(26, 24);
            this.ToolStripLabelConsole.Text = "Idle";
            // 
            // ToolStripStatusSeperator0
            // 
            this.ToolStripStatusSeperator0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripStatusSeperator0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripStatusSeperator0.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStripStatusSeperator0.Name = "ToolStripStatusSeperator0";
            this.ToolStripStatusSeperator0.Size = new System.Drawing.Size(6, 27);
            // 
            // ToolStripLabelStatus
            // 
            this.ToolStripLabelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStatus.Name = "ToolStripLabelStatus";
            this.ToolStripLabelStatus.Size = new System.Drawing.Size(85, 24);
            this.ToolStripLabelStatus.Text = "Loading data...";
            // 
            // ToolStripLabelStats
            // 
            this.ToolStripLabelStats.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripLabelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolStripLabelStats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolStripLabelStats.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.ToolStripLabelStats.Name = "ToolStripLabelStats";
            this.ToolStripLabelStats.Size = new System.Drawing.Size(348, 24);
            this.ToolStripLabelStats.Text = "## Mods for ## Games, ## Resources (Last Updated: 00/00/0000)";
            // 
            // LabelSelectSystemType
            // 
            this.LabelSelectSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectSystemType.AutoSize = true;
            this.LabelSelectSystemType.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectSystemType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectSystemType.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectSystemType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectSystemType.Location = new System.Drawing.Point(404, 42);
            this.LabelSelectSystemType.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectSystemType.Name = "LabelSelectSystemType";
            this.LabelSelectSystemType.Size = new System.Drawing.Size(78, 15);
            this.LabelSelectSystemType.TabIndex = 1156;
            this.LabelSelectSystemType.Text = "SYSTEM TYPE";
            // 
            // LabelNoModsFound
            // 
            this.LabelNoModsFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoModsFound.AutoSize = true;
            this.LabelNoModsFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LabelNoModsFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsFound.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoModsFound.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsFound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsFound.Location = new System.Drawing.Point(396, 197);
            this.LabelNoModsFound.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoModsFound.Name = "LabelNoModsFound";
            this.LabelNoModsFound.Size = new System.Drawing.Size(109, 15);
            this.LabelNoModsFound.TabIndex = 1159;
            this.LabelNoModsFound.Text = "NO MODS FOUND";
            // 
            // GridControlMods
            // 
            this.GridControlMods.ContextMenuStrip = this.ContextMenuMods;
            this.GridControlMods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlMods.Location = new System.Drawing.Point(2, 119);
            this.GridControlMods.MainView = this.GridViewMods;
            this.GridControlMods.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.GridControlMods.Name = "GridControlMods";
            this.GridControlMods.Size = new System.Drawing.Size(897, 413);
            this.GridControlMods.TabIndex = 6;
            this.GridControlMods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewMods});
            // 
            // GridViewMods
            // 
            this.GridViewMods.GridControl = this.GridControlMods;
            this.GridViewMods.Name = "GridViewMods";
            this.GridViewMods.OptionsView.ShowGroupPanel = false;
            // 
            // PanelModsLibraryFilters
            // 
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxRegion);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxModType);
            this.PanelModsLibraryFilters.Controls.Add(this.ComboBoxSystemType);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectRegion);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelTitleMods);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelTitleFilterMods);
            this.PanelModsLibraryFilters.Controls.Add(this.TextBoxSearch);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSearch);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectSystemType);
            this.PanelModsLibraryFilters.Controls.Add(this.LabelSelectType);
            this.PanelModsLibraryFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelModsLibraryFilters.Location = new System.Drawing.Point(2, 23);
            this.PanelModsLibraryFilters.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PanelModsLibraryFilters.Name = "PanelModsLibraryFilters";
            this.PanelModsLibraryFilters.Size = new System.Drawing.Size(897, 96);
            this.PanelModsLibraryFilters.TabIndex = 12;
            // 
            // ComboBoxRegion
            // 
            this.ComboBoxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxRegion.Location = new System.Drawing.Point(787, 38);
            this.ComboBoxRegion.MenuManager = this.MainMenu;
            this.ComboBoxRegion.Name = "ComboBoxRegion";
            this.ComboBoxRegion.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxRegion.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxRegion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxRegion.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxRegion.Size = new System.Drawing.Size(104, 22);
            this.ComboBoxRegion.TabIndex = 1166;
            // 
            // MainMenu
            // 
            this.MainMenu.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.MainMenu.DockControls.Add(this.barDockControlTop);
            this.MainMenu.DockControls.Add(this.barDockControlBottom);
            this.MainMenu.DockControls.Add(this.barDockControlLeft);
            this.MainMenu.DockControls.Add(this.barDockControlRight);
            this.MainMenu.Form = this;
            this.MainMenu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ConnectMenuBar,
            this.ToolsMenuBar,
            this.ApplicationMenuBar,
            this.OptionsMenuBar,
            this.HelpMenuBar,
            this.barButtonItem6,
            this.barButtonItem7,
            this.GameBackupFilesButton,
            this.GameUpdateFinderButton,
            this.barSubItem1,
            this.barToolbarsListItem1,
            this.barWorkspaceMenuItem1,
            this.FileManagerButton,
            this.PackageManagerButton,
            this.AddConsoleButton,
            this.EditGameRegionButton,
            this.EditApplicationsButton,
            this.EditYourLists,
            this.barButtonItem16,
            this.skinBarSubItem1,
            this.Exitbutton,
            this.ReportBugButton,
            this.DiscordServerButton,
            this.OfficailSourceButton,
            this.OpenLogFileButton,
            this.OpenLogFolderButton,
            this.HelpSpacer1,
            this.HelpSpacer2,
            this.AboutBar,
            this.WhatsNewButton,
            this.CheckForUpdateButton,
            this.HelpSpacer3,
            this.PS3ConnectMenu,
            this.XBConsole,
            this.PS3ConnectButton,
            this.Xbox360ConnectButton,
            this.barDockingMenuItem1,
            this.WebManControlsMenu,
            this.barButtonItem15,
            this.barButtonItem17,
            this.barSubItem3,
            this.ShutDownButtonBar,
            this.RestartButtonBar,
            this.barButtonItem20,
            this.barButtonItem21,
            this.barSubItem4,
            this.barButtonItem23,
            this.barButtonItem24,
            this.barButtonItem26,
            this.barButtonItem27,
            this.barButtonItem28,
            this.barButtonItem1,
            this.HeaderConsoleConnected,
            this.LabelConsoleConnected,
            this.barToolbarsListItem2});
            this.MainMenu.MainMenu = this.bar2;
            this.MainMenu.MaxItemId = 56;
            this.MainMenu.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.AutoUpdateMergedBars = DevExpress.Utils.DefaultBoolean.True;
            this.bar2.BarItemVertIndent = 5;
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ConnectMenuBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.ToolsMenuBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.ApplicationMenuBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.OptionsMenuBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.HelpMenuBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // ConnectMenuBar
            // 
            this.ConnectMenuBar.ActAsDropDown = true;
            this.ConnectMenuBar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ConnectMenuBar.Caption = "CONNECT";
            this.ConnectMenuBar.DropDownControl = this.ConnectMenu;
            this.ConnectMenuBar.Id = 0;
            this.ConnectMenuBar.Name = "ConnectMenuBar";
            // 
            // ConnectMenu
            // 
            this.ConnectMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.PS3ConnectMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.XBConsole)});
            this.ConnectMenu.Manager = this.MainMenu;
            this.ConnectMenu.Name = "ConnectMenu";
            // 
            // PS3ConnectMenu
            // 
            this.PS3ConnectMenu.Caption = "PS3";
            this.PS3ConnectMenu.Id = 32;
            this.PS3ConnectMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.PS3ConnectButton)});
            this.PS3ConnectMenu.Name = "PS3ConnectMenu";
            // 
            // PS3ConnectButton
            // 
            this.PS3ConnectButton.Caption = "Connect To Console...";
            this.PS3ConnectButton.Id = 34;
            this.PS3ConnectButton.Name = "PS3ConnectButton";
            this.PS3ConnectButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PS3ConnectButton_ItemClick);
            // 
            // XBConsole
            // 
            this.XBConsole.Caption = "Xbox 360";
            this.XBConsole.Id = 33;
            this.XBConsole.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Xbox360ConnectButton)});
            this.XBConsole.Name = "XBConsole";
            // 
            // Xbox360ConnectButton
            // 
            this.Xbox360ConnectButton.Caption = "Connect To Console...";
            this.Xbox360ConnectButton.Id = 35;
            this.Xbox360ConnectButton.Name = "Xbox360ConnectButton";
            // 
            // ToolsMenuBar
            // 
            this.ToolsMenuBar.ActAsDropDown = true;
            this.ToolsMenuBar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ToolsMenuBar.Caption = "TOOLS";
            this.ToolsMenuBar.DropDownControl = this.ToolsMenu;
            this.ToolsMenuBar.Id = 1;
            this.ToolsMenuBar.Name = "ToolsMenuBar";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.GameBackupFilesButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.GameUpdateFinderButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.FileManagerButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.PackageManagerButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.WebManControlsMenu, true)});
            this.ToolsMenu.Manager = this.MainMenu;
            this.ToolsMenu.Name = "ToolsMenu";
            // 
            // GameBackupFilesButton
            // 
            this.GameBackupFilesButton.Caption = "Game Backup Files...";
            this.GameBackupFilesButton.Id = 7;
            this.GameBackupFilesButton.Name = "GameBackupFilesButton";
            this.GameBackupFilesButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GameBackupFilesButton_ItemClick);
            // 
            // GameUpdateFinderButton
            // 
            this.GameUpdateFinderButton.Caption = "Game Update Finder...";
            this.GameUpdateFinderButton.Id = 8;
            this.GameUpdateFinderButton.Name = "GameUpdateFinderButton";
            this.GameUpdateFinderButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GameUpdateFinderButton_ItemClick);
            // 
            // FileManagerButton
            // 
            this.FileManagerButton.Caption = "File Manager...";
            this.FileManagerButton.Id = 12;
            this.FileManagerButton.Name = "FileManagerButton";
            this.FileManagerButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FileManagerButton_ItemClick);
            // 
            // PackageManagerButton
            // 
            this.PackageManagerButton.Caption = "Package Manager...";
            this.PackageManagerButton.Id = 13;
            this.PackageManagerButton.Name = "PackageManagerButton";
            this.PackageManagerButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PackageManagerButton_ItemClick);
            // 
            // WebManControlsMenu
            // 
            this.WebManControlsMenu.Caption = "WebMAN Controls...";
            this.WebManControlsMenu.Id = 37;
            this.WebManControlsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem4),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem15),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem17)});
            this.WebManControlsMenu.Name = "WebManControlsMenu";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Power Functions";
            this.barSubItem3.Id = 40;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ShutDownButtonBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.RestartButtonBar),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem20),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem21)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // ShutDownButtonBar
            // 
            this.ShutDownButtonBar.Caption = "Shutdown...";
            this.ShutDownButtonBar.Id = 41;
            this.ShutDownButtonBar.Name = "ShutDownButtonBar";
            this.ShutDownButtonBar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ShutDownButtonBar_ItemClick);
            // 
            // RestartButtonBar
            // 
            this.RestartButtonBar.Caption = "Restart...";
            this.RestartButtonBar.Id = 42;
            this.RestartButtonBar.Name = "RestartButtonBar";
            this.RestartButtonBar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RestartButtonBar_ItemClick);
            // 
            // barButtonItem20
            // 
            this.barButtonItem20.Caption = "Cold Reboot...";
            this.barButtonItem20.Id = 43;
            this.barButtonItem20.Name = "barButtonItem20";
            this.barButtonItem20.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem20_ItemClick);
            // 
            // barButtonItem21
            // 
            this.barButtonItem21.Caption = "Hard Reboot...";
            this.barButtonItem21.Id = 44;
            this.barButtonItem21.Name = "barButtonItem21";
            this.barButtonItem21.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem21_ItemClick);
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "System Info";
            this.barSubItem4.Id = 45;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem23),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem24),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem26)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem23
            // 
            this.barButtonItem23.Caption = "Show System Information...";
            this.barButtonItem23.Id = 46;
            this.barButtonItem23.Name = "barButtonItem23";
            this.barButtonItem23.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem23_ItemClick);
            // 
            // barButtonItem24
            // 
            this.barButtonItem24.Caption = "Show CPU/RSX Temperature...";
            this.barButtonItem24.Id = 47;
            this.barButtonItem24.Name = "barButtonItem24";
            this.barButtonItem24.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem24_ItemClick);
            // 
            // barButtonItem26
            // 
            this.barButtonItem26.Caption = "Show Minimum Version...";
            this.barButtonItem26.Id = 48;
            this.barButtonItem26.Name = "barButtonItem26";
            this.barButtonItem26.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem26_ItemClick);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Notify Message...";
            this.barButtonItem15.Id = 38;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick_1);
            // 
            // barButtonItem17
            // 
            this.barButtonItem17.Caption = "Virtual Controller...";
            this.barButtonItem17.Id = 39;
            this.barButtonItem17.Name = "barButtonItem17";
            this.barButtonItem17.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem17_ItemClick);
            // 
            // ApplicationMenuBar
            // 
            this.ApplicationMenuBar.ActAsDropDown = true;
            this.ApplicationMenuBar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.ApplicationMenuBar.Caption = "APPLICATIONS";
            this.ApplicationMenuBar.DropDownControl = this.ApplicationsMenu;
            this.ApplicationMenuBar.Id = 2;
            this.ApplicationMenuBar.Name = "ApplicationMenuBar";
            // 
            // ApplicationsMenu
            // 
            this.ApplicationsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem27),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem28)});
            this.ApplicationsMenu.Manager = this.MainMenu;
            this.ApplicationsMenu.Name = "ApplicationsMenu";
            // 
            // barButtonItem27
            // 
            this.barButtonItem27.Caption = "Control Console (CCAPI)";
            this.barButtonItem27.Id = 49;
            this.barButtonItem27.Name = "barButtonItem27";
            // 
            // barButtonItem28
            // 
            this.barButtonItem28.Caption = "FileZilla";
            this.barButtonItem28.Id = 50;
            this.barButtonItem28.Name = "barButtonItem28";
            // 
            // OptionsMenuBar
            // 
            this.OptionsMenuBar.ActAsDropDown = true;
            this.OptionsMenuBar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.OptionsMenuBar.Caption = "OPTIONS";
            this.OptionsMenuBar.DropDownControl = this.OptionsMenu;
            this.OptionsMenuBar.Id = 3;
            this.OptionsMenuBar.Name = "OptionsMenuBar";
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.AddConsoleButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditGameRegionButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditApplicationsButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.EditYourLists),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem16, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.Exitbutton, true)});
            this.OptionsMenu.Manager = this.MainMenu;
            this.OptionsMenu.Name = "OptionsMenu";
            // 
            // AddConsoleButton
            // 
            this.AddConsoleButton.Caption = "Add New Console...";
            this.AddConsoleButton.Id = 14;
            this.AddConsoleButton.Name = "AddConsoleButton";
            this.AddConsoleButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddConsoleButton_ItemClick);
            // 
            // EditGameRegionButton
            // 
            this.EditGameRegionButton.Caption = "Edit Game Regions...";
            this.EditGameRegionButton.Id = 15;
            this.EditGameRegionButton.Name = "EditGameRegionButton";
            this.EditGameRegionButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditGameRegionButton_ItemClick);
            // 
            // EditApplicationsButton
            // 
            this.EditApplicationsButton.Caption = "Edit Applications...";
            this.EditApplicationsButton.Id = 16;
            this.EditApplicationsButton.Name = "EditApplicationsButton";
            this.EditApplicationsButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditApplicationsButton_ItemClick);
            // 
            // EditYourLists
            // 
            this.EditYourLists.Caption = "Edit Your Lists...";
            this.EditYourLists.Id = 17;
            this.EditYourLists.Name = "EditYourLists";
            this.EditYourLists.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditYourLists_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Settings...";
            this.barButtonItem16.Id = 18;
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Settings_ItemClick);
            // 
            // Exitbutton
            // 
            this.Exitbutton.Caption = "Exit Application";
            this.Exitbutton.Id = 20;
            this.Exitbutton.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.True;
            this.Exitbutton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AppExit_ItemClick);
            // 
            // HelpMenuBar
            // 
            this.HelpMenuBar.ActAsDropDown = true;
            this.HelpMenuBar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.HelpMenuBar.Caption = "HELP";
            this.HelpMenuBar.DropDownControl = this.HelpMenu;
            this.HelpMenuBar.Id = 4;
            this.HelpMenuBar.Name = "HelpMenuBar";
            // 
            // HelpMenu
            // 
            this.HelpMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.ReportBugButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.DiscordServerButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.OfficailSourceButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.OpenLogFileButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.OpenLogFolderButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.CheckForUpdateButton, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.WhatsNewButton),
            new DevExpress.XtraBars.LinkPersistInfo(this.skinBarSubItem1, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.AboutBar, true)});
            this.HelpMenu.Manager = this.MainMenu;
            this.HelpMenu.Name = "HelpMenu";
            // 
            // ReportBugButton
            // 
            this.ReportBugButton.Caption = "Report Bug...";
            this.ReportBugButton.Id = 21;
            this.ReportBugButton.Name = "ReportBugButton";
            this.ReportBugButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ReportBugButton_ItemClick);
            // 
            // DiscordServerButton
            // 
            this.DiscordServerButton.Caption = "Discord Server...";
            this.DiscordServerButton.Id = 22;
            this.DiscordServerButton.Name = "DiscordServerButton";
            this.DiscordServerButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DiscordServerButton_ItemClick);
            // 
            // OfficailSourceButton
            // 
            this.OfficailSourceButton.Caption = "Officail Source...";
            this.OfficailSourceButton.Id = 23;
            this.OfficailSourceButton.Name = "OfficailSourceButton";
            this.OfficailSourceButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OfficailSourceButton_ItemClick);
            // 
            // OpenLogFileButton
            // 
            this.OpenLogFileButton.Caption = "Open Log File...";
            this.OpenLogFileButton.Id = 24;
            this.OpenLogFileButton.Name = "OpenLogFileButton";
            this.OpenLogFileButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenLogFileButton_ItemClick);
            // 
            // OpenLogFolderButton
            // 
            this.OpenLogFolderButton.Caption = "Open Log Folder";
            this.OpenLogFolderButton.Id = 25;
            this.OpenLogFolderButton.Name = "OpenLogFolderButton";
            this.OpenLogFolderButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OpenLogFolderButton_ItemClick);
            // 
            // CheckForUpdateButton
            // 
            this.CheckForUpdateButton.Caption = "Check For Updates...";
            this.CheckForUpdateButton.Id = 30;
            this.CheckForUpdateButton.Name = "CheckForUpdateButton";
            this.CheckForUpdateButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CheckForUpdateButton_ItemClick);
            // 
            // WhatsNewButton
            // 
            this.WhatsNewButton.Caption = "What\'s New...";
            this.WhatsNewButton.Id = 29;
            this.WhatsNewButton.Name = "WhatsNewButton";
            this.WhatsNewButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.WhatsNewButton_ItemClick);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Skin Changer...";
            this.skinBarSubItem1.Id = 19;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // AboutBar
            // 
            this.AboutBar.Caption = "About...";
            this.AboutBar.Id = 28;
            this.AboutBar.Name = "AboutBar";
            this.AboutBar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AboutBar_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Winv2";
            this.barButtonItem1.Id = 52;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarItemVertIndent = 6;
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.HeaderConsoleConnected),
            new DevExpress.XtraBars.LinkPersistInfo(this.LabelConsoleConnected)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // HeaderConsoleConnected
            // 
            this.HeaderConsoleConnected.Caption = "Console Connected  :";
            this.HeaderConsoleConnected.Id = 53;
            this.HeaderConsoleConnected.Name = "HeaderConsoleConnected";
            // 
            // LabelConsoleConnected
            // 
            this.LabelConsoleConnected.Caption = "Idle";
            this.LabelConsoleConnected.Id = 54;
            this.LabelConsoleConnected.Name = "LabelConsoleConnected";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.MainMenu;
            this.barDockControlTop.Size = new System.Drawing.Size(1584, 25);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 775);
            this.barDockControlBottom.Manager = this.MainMenu;
            this.barDockControlBottom.Size = new System.Drawing.Size(1584, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 25);
            this.barDockControlLeft.Manager = this.MainMenu;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 750);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1584, 25);
            this.barDockControlRight.Manager = this.MainMenu;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 750);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "PS3";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "XBOX 360";
            this.barButtonItem7.Id = 6;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 9;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barToolbarsListItem1
            // 
            this.barToolbarsListItem1.Caption = "barToolbarsListItem1";
            this.barToolbarsListItem1.Id = 10;
            this.barToolbarsListItem1.Name = "barToolbarsListItem1";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 11;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // HelpSpacer1
            // 
            this.HelpSpacer1.Caption = "_________________________";
            this.HelpSpacer1.DropDownEnabled = false;
            this.HelpSpacer1.Enabled = false;
            this.HelpSpacer1.Id = 26;
            this.HelpSpacer1.Name = "HelpSpacer1";
            // 
            // HelpSpacer2
            // 
            this.HelpSpacer2.Caption = "______";
            this.HelpSpacer2.Enabled = false;
            this.HelpSpacer2.Id = 27;
            this.HelpSpacer2.Name = "HelpSpacer2";
            // 
            // HelpSpacer3
            // 
            this.HelpSpacer3.Caption = "______________________";
            this.HelpSpacer3.Enabled = false;
            this.HelpSpacer3.Id = 31;
            this.HelpSpacer3.Name = "HelpSpacer3";
            // 
            // barDockingMenuItem1
            // 
            this.barDockingMenuItem1.Caption = "barDockingMenuItem1";
            this.barDockingMenuItem1.Id = 36;
            this.barDockingMenuItem1.Name = "barDockingMenuItem1";
            // 
            // barToolbarsListItem2
            // 
            this.barToolbarsListItem2.Caption = "barToolbarsListItem2";
            this.barToolbarsListItem2.Id = 55;
            this.barToolbarsListItem2.Name = "barToolbarsListItem2";
            // 
            // ComboBoxModType
            // 
            this.ComboBoxModType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxModType.Location = new System.Drawing.Point(628, 38);
            this.ComboBoxModType.MenuManager = this.MainMenu;
            this.ComboBoxModType.Name = "ComboBoxModType";
            this.ComboBoxModType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxModType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxModType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxModType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxModType.Size = new System.Drawing.Size(96, 22);
            this.ComboBoxModType.TabIndex = 1165;
            // 
            // ComboBoxSystemType
            // 
            this.ComboBoxSystemType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboBoxSystemType.Location = new System.Drawing.Point(490, 38);
            this.ComboBoxSystemType.MenuManager = this.MainMenu;
            this.ComboBoxSystemType.Name = "ComboBoxSystemType";
            this.ComboBoxSystemType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboBoxSystemType.Properties.Appearance.Options.UseFont = true;
            this.ComboBoxSystemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboBoxSystemType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboBoxSystemType.Size = new System.Drawing.Size(60, 22);
            this.ComboBoxSystemType.TabIndex = 1164;
            // 
            // LabelSelectRegion
            // 
            this.LabelSelectRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSelectRegion.AutoSize = true;
            this.LabelSelectRegion.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSelectRegion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSelectRegion.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSelectRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSelectRegion.Location = new System.Drawing.Point(730, 42);
            this.LabelSelectRegion.Margin = new System.Windows.Forms.Padding(5, 4, 3, 2);
            this.LabelSelectRegion.Name = "LabelSelectRegion";
            this.LabelSelectRegion.Size = new System.Drawing.Size(49, 15);
            this.LabelSelectRegion.TabIndex = 1163;
            this.LabelSelectRegion.Text = "REGION";
            // 
            // LabelTitleMods
            // 
            this.LabelTitleMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleMods.Location = new System.Drawing.Point(7, 70);
            this.LabelTitleMods.Name = "LabelTitleMods";
            this.LabelTitleMods.Size = new System.Drawing.Size(882, 17);
            this.LabelTitleMods.TabIndex = 1161;
            this.LabelTitleMods.Text = "MODS";
            // 
            // LabelTitleFilterMods
            // 
            this.LabelTitleFilterMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelTitleFilterMods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleFilterMods.Location = new System.Drawing.Point(7, 10);
            this.LabelTitleFilterMods.Name = "LabelTitleFilterMods";
            this.LabelTitleFilterMods.Size = new System.Drawing.Size(882, 17);
            this.LabelTitleFilterMods.TabIndex = 1159;
            this.LabelTitleFilterMods.Text = "FILTER MODS";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBoxSearch.Location = new System.Drawing.Point(61, 38);
            this.TextBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(335, 23);
            this.TextBoxSearch.TabIndex = 1158;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelSearch.Location = new System.Drawing.Point(4, 42);
            this.LabelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(51, 15);
            this.LabelSearch.TabIndex = 1157;
            this.LabelSearch.Text = "SEARCH";
            // 
            // ColumnModsId
            // 
            this.ColumnModsId.HeaderText = "Id";
            this.ColumnModsId.MinimumWidth = 6;
            this.ColumnModsId.Name = "ColumnModsId";
            this.ColumnModsId.ReadOnly = true;
            this.ColumnModsId.Visible = false;
            this.ColumnModsId.Width = 125;
            // 
            // ColumnModsName
            // 
            this.ColumnModsName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModsName.HeaderText = "Mod Name";
            this.ColumnModsName.MinimumWidth = 6;
            this.ColumnModsName.Name = "ColumnModsName";
            this.ColumnModsName.ReadOnly = true;
            // 
            // ColumnModsFirmware
            // 
            this.ColumnModsFirmware.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsFirmware.HeaderText = "System Type";
            this.ColumnModsFirmware.MinimumWidth = 6;
            this.ColumnModsFirmware.Name = "ColumnModsFirmware";
            this.ColumnModsFirmware.ReadOnly = true;
            // 
            // ColumnModsType
            // 
            this.ColumnModsType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsType.HeaderText = "Mod Type";
            this.ColumnModsType.MinimumWidth = 6;
            this.ColumnModsType.Name = "ColumnModsType";
            this.ColumnModsType.ReadOnly = true;
            // 
            // ColumnModsRegion
            // 
            this.ColumnModsRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsRegion.HeaderText = "Region";
            this.ColumnModsRegion.MinimumWidth = 6;
            this.ColumnModsRegion.Name = "ColumnModsRegion";
            this.ColumnModsRegion.ReadOnly = true;
            // 
            // ColumnModsVersion
            // 
            this.ColumnModsVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsVersion.HeaderText = "Version";
            this.ColumnModsVersion.MinimumWidth = 6;
            this.ColumnModsVersion.Name = "ColumnModsVersion";
            this.ColumnModsVersion.ReadOnly = true;
            // 
            // ColumnModsAuthor
            // 
            this.ColumnModsAuthor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsAuthor.HeaderText = "Creator";
            this.ColumnModsAuthor.MinimumWidth = 124;
            this.ColumnModsAuthor.Name = "ColumnModsAuthor";
            this.ColumnModsAuthor.ReadOnly = true;
            // 
            // ColumnModsNoFiles
            // 
            this.ColumnModsNoFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsNoFiles.HeaderText = "# of Files";
            this.ColumnModsNoFiles.MinimumWidth = 6;
            this.ColumnModsNoFiles.Name = "ColumnModsNoFiles";
            this.ColumnModsNoFiles.ReadOnly = true;
            // 
            // ColumnModsInstall
            // 
            this.ColumnModsInstall.HeaderText = "";
            this.ColumnModsInstall.MinimumWidth = 6;
            this.ColumnModsInstall.Name = "ColumnModsInstall";
            this.ColumnModsInstall.ReadOnly = true;
            this.ColumnModsInstall.Width = 28;
            // 
            // ColumnModsDownload
            // 
            this.ColumnModsDownload.HeaderText = "";
            this.ColumnModsDownload.MinimumWidth = 6;
            this.ColumnModsDownload.Name = "ColumnModsDownload";
            this.ColumnModsDownload.ReadOnly = true;
            this.ColumnModsDownload.Width = 28;
            // 
            // ColumnModsFavourite
            // 
            this.ColumnModsFavourite.HeaderText = "";
            this.ColumnModsFavourite.MinimumWidth = 6;
            this.ColumnModsFavourite.Name = "ColumnModsFavourite";
            this.ColumnModsFavourite.ReadOnly = true;
            this.ColumnModsFavourite.Width = 28;
            // 
            // SectionGames
            // 
            this.SectionGames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SectionGames.Controls.Add(this.ScrollBarCategories);
            this.SectionGames.Controls.Add(this.FlowPanelCategories);
            this.SectionGames.Cursor = System.Windows.Forms.Cursors.Default;
            this.SectionGames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SectionGames.Location = new System.Drawing.Point(13, 39);
            this.SectionGames.Margin = new System.Windows.Forms.Padding(3, 4, 4, 4);
            this.SectionGames.Name = "SectionGames";
            this.SectionGames.SectionHeader = "CATEGORIES";
            this.SectionGames.Size = new System.Drawing.Size(265, 743);
            this.SectionGames.TabIndex = 0;
            this.SectionGames.Visible = false;
            // 
            // ScrollBarCategories
            // 
            this.ScrollBarCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScrollBarCategories.Location = new System.Drawing.Point(247, 25);
            this.ScrollBarCategories.Margin = new System.Windows.Forms.Padding(0, 4, 3, 0);
            this.ScrollBarCategories.Name = "ScrollBarCategories";
            this.ScrollBarCategories.Size = new System.Drawing.Size(17, 717);
            this.ScrollBarCategories.TabIndex = 1174;
            this.ScrollBarCategories.Text = "darkScrollBar1";
            this.ScrollBarCategories.ViewSize = 1;
            this.ScrollBarCategories.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.ScrollBarCategories_ValueChanged);
            // 
            // FlowPanelCategories
            // 
            this.FlowPanelCategories.AutoScroll = true;
            this.FlowPanelCategories.Controls.Add(this.LabelTitleGames);
            this.FlowPanelCategories.Controls.Add(this.PanelGames);
            this.FlowPanelCategories.Controls.Add(this.LabelTitleHomebrew);
            this.FlowPanelCategories.Controls.Add(this.PanelHomebrew);
            this.FlowPanelCategories.Controls.Add(this.LabelTitleResources);
            this.FlowPanelCategories.Controls.Add(this.PanelResources);
            this.FlowPanelCategories.Controls.Add(this.LabelTitleMyLists);
            this.FlowPanelCategories.Controls.Add(this.PanelLists);
            this.FlowPanelCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanelCategories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowPanelCategories.Location = new System.Drawing.Point(1, 25);
            this.FlowPanelCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FlowPanelCategories.Name = "FlowPanelCategories";
            this.FlowPanelCategories.Padding = new System.Windows.Forms.Padding(2, 6, 0, 11);
            this.FlowPanelCategories.Size = new System.Drawing.Size(263, 717);
            this.FlowPanelCategories.TabIndex = 0;
            this.FlowPanelCategories.WrapContents = false;
            this.FlowPanelCategories.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FlowPanelCategories_MouseWheel);
            // 
            // LabelTitleGames
            // 
            this.LabelTitleGames.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleGames.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleGames.Location = new System.Drawing.Point(7, 9);
            this.LabelTitleGames.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.LabelTitleGames.Name = "LabelTitleGames";
            this.LabelTitleGames.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleGames.TabIndex = 1161;
            this.LabelTitleGames.Text = "GAMES";
            // 
            // PanelGames
            // 
            this.PanelGames.AutoSize = true;
            this.PanelGames.BackColor = System.Drawing.Color.Transparent;
            this.PanelGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGames.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelGames.Location = new System.Drawing.Point(2, 30);
            this.PanelGames.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelGames.Name = "PanelGames";
            this.PanelGames.Size = new System.Drawing.Size(244, 0);
            this.PanelGames.TabIndex = 0;
            // 
            // LabelTitleHomebrew
            // 
            this.LabelTitleHomebrew.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleHomebrew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleHomebrew.Location = new System.Drawing.Point(7, 38);
            this.LabelTitleHomebrew.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleHomebrew.Name = "LabelTitleHomebrew";
            this.LabelTitleHomebrew.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleHomebrew.TabIndex = 1167;
            this.LabelTitleHomebrew.Text = "HOMEBREW PACKAGES";
            // 
            // PanelHomebrew
            // 
            this.PanelHomebrew.AutoSize = true;
            this.PanelHomebrew.BackColor = System.Drawing.Color.Transparent;
            this.PanelHomebrew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHomebrew.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelHomebrew.Location = new System.Drawing.Point(2, 59);
            this.PanelHomebrew.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelHomebrew.Name = "PanelHomebrew";
            this.PanelHomebrew.Size = new System.Drawing.Size(244, 0);
            this.PanelHomebrew.TabIndex = 1168;
            // 
            // LabelTitleResources
            // 
            this.LabelTitleResources.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleResources.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleResources.Location = new System.Drawing.Point(7, 67);
            this.LabelTitleResources.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleResources.Name = "LabelTitleResources";
            this.LabelTitleResources.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleResources.TabIndex = 1163;
            this.LabelTitleResources.Text = "RESOURCES";
            // 
            // PanelResources
            // 
            this.PanelResources.AutoSize = true;
            this.PanelResources.BackColor = System.Drawing.Color.Transparent;
            this.PanelResources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResources.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelResources.Location = new System.Drawing.Point(2, 88);
            this.PanelResources.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelResources.Name = "PanelResources";
            this.PanelResources.Size = new System.Drawing.Size(244, 0);
            this.PanelResources.TabIndex = 1164;
            // 
            // LabelTitleMyLists
            // 
            this.LabelTitleMyLists.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabelTitleMyLists.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTitleMyLists.Location = new System.Drawing.Point(7, 96);
            this.LabelTitleMyLists.Margin = new System.Windows.Forms.Padding(5, 0, 3, 3);
            this.LabelTitleMyLists.Name = "LabelTitleMyLists";
            this.LabelTitleMyLists.Size = new System.Drawing.Size(236, 16);
            this.LabelTitleMyLists.TabIndex = 1165;
            this.LabelTitleMyLists.Text = "MY LISTS";
            // 
            // PanelLists
            // 
            this.PanelLists.AutoSize = true;
            this.PanelLists.BackColor = System.Drawing.Color.Transparent;
            this.PanelLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelLists.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PanelLists.Location = new System.Drawing.Point(2, 117);
            this.PanelLists.Margin = new System.Windows.Forms.Padding(0, 2, 0, 8);
            this.PanelLists.Name = "PanelLists";
            this.PanelLists.Size = new System.Drawing.Size(244, 0);
            this.PanelLists.TabIndex = 1166;
            // 
            // LabelNoModsInstalled
            // 
            this.LabelNoModsInstalled.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelNoModsInstalled.AutoSize = true;
            this.LabelNoModsInstalled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LabelNoModsInstalled.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelNoModsInstalled.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelNoModsInstalled.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelNoModsInstalled.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LabelNoModsInstalled.Location = new System.Drawing.Point(386, 72);
            this.LabelNoModsInstalled.Margin = new System.Windows.Forms.Padding(3, 4, 3, 2);
            this.LabelNoModsInstalled.Name = "LabelNoModsInstalled";
            this.LabelNoModsInstalled.Size = new System.Drawing.Size(128, 15);
            this.LabelNoModsInstalled.TabIndex = 1178;
            this.LabelNoModsInstalled.Text = "NO MODS INSTALLED";
            // 
            // GridControlGameModsInstalled
            // 
            this.GridControlGameModsInstalled.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridControlGameModsInstalled.Location = new System.Drawing.Point(2, 23);
            this.GridControlGameModsInstalled.MainView = this.GridViewGameModsInstalled;
            this.GridControlGameModsInstalled.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.GridControlGameModsInstalled.Name = "GridControlGameModsInstalled";
            this.GridControlGameModsInstalled.Size = new System.Drawing.Size(897, 178);
            this.GridControlGameModsInstalled.TabIndex = 7;
            this.GridControlGameModsInstalled.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridViewGameModsInstalled});
            // 
            // GridViewGameModsInstalled
            // 
            this.GridViewGameModsInstalled.GridControl = this.GridControlGameModsInstalled;
            this.GridViewGameModsInstalled.Name = "GridViewGameModsInstalled";
            this.GridViewGameModsInstalled.OptionsView.ShowGroupPanel = false;
            // 
            // ToolItemGameModsUninstallAll
            // 
            this.ToolItemGameModsUninstallAll.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolItemGameModsUninstallAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ToolItemGameModsUninstallAll.Enabled = false;
            this.ToolItemGameModsUninstallAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.ToolItemGameModsUninstallAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ToolItemGameModsUninstallAll.Image = ((System.Drawing.Image)(resources.GetObject("ToolItemGameModsUninstallAll.Image")));
            this.ToolItemGameModsUninstallAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ToolItemGameModsUninstallAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ToolItemGameModsUninstallAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolItemGameModsUninstallAll.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ToolItemGameModsUninstallAll.Name = "ToolItemGameModsUninstallAll";
            this.ToolItemGameModsUninstallAll.Size = new System.Drawing.Size(98, 26);
            this.ToolItemGameModsUninstallAll.Text = "Uninstall All";
            this.ToolItemGameModsUninstallAll.ToolTipText = "Uninstall All Mods from Console";
            this.ToolItemGameModsUninstallAll.Click += new System.EventHandler(this.ToolItemUninstallAllGameMods_Click);
            // 
            // LabelInstalledGameModsStatus
            // 
            this.LabelInstalledGameModsStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.LabelInstalledGameModsStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelInstalledGameModsStatus.Name = "LabelInstalledGameModsStatus";
            this.LabelInstalledGameModsStatus.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.LabelInstalledGameModsStatus.Size = new System.Drawing.Size(170, 33);
            this.LabelInstalledGameModsStatus.Text = "0 Mods Installed (0 Files Total)";
            // 
            // ColumnModsInstalledId
            // 
            this.ColumnModsInstalledId.HeaderText = "Mod Id";
            this.ColumnModsInstalledId.MinimumWidth = 6;
            this.ColumnModsInstalledId.Name = "ColumnModsInstalledId";
            this.ColumnModsInstalledId.ReadOnly = true;
            this.ColumnModsInstalledId.Visible = false;
            this.ColumnModsInstalledId.Width = 125;
            // 
            // ColumnModsInstalledGameTitle
            // 
            this.ColumnModsInstalledGameTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModsInstalledGameTitle.HeaderText = "Game Title";
            this.ColumnModsInstalledGameTitle.MinimumWidth = 6;
            this.ColumnModsInstalledGameTitle.Name = "ColumnModsInstalledGameTitle";
            this.ColumnModsInstalledGameTitle.ReadOnly = true;
            // 
            // ColumnModsInstalledRegion
            // 
            this.ColumnModsInstalledRegion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledRegion.HeaderText = "Region";
            this.ColumnModsInstalledRegion.MinimumWidth = 6;
            this.ColumnModsInstalledRegion.Name = "ColumnModsInstalledRegion";
            this.ColumnModsInstalledRegion.ReadOnly = true;
            // 
            // ColumnModsInstalledModName
            // 
            this.ColumnModsInstalledModName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnModsInstalledModName.HeaderText = "Mod Name";
            this.ColumnModsInstalledModName.MinimumWidth = 6;
            this.ColumnModsInstalledModName.Name = "ColumnModsInstalledModName";
            this.ColumnModsInstalledModName.ReadOnly = true;
            // 
            // ColumnModsInstalledModType
            // 
            this.ColumnModsInstalledModType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledModType.HeaderText = "Mod Type";
            this.ColumnModsInstalledModType.MinimumWidth = 6;
            this.ColumnModsInstalledModType.Name = "ColumnModsInstalledModType";
            this.ColumnModsInstalledModType.ReadOnly = true;
            // 
            // ColumnModsInstalledVersion
            // 
            this.ColumnModsInstalledVersion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledVersion.HeaderText = "Version";
            this.ColumnModsInstalledVersion.MinimumWidth = 6;
            this.ColumnModsInstalledVersion.Name = "ColumnModsInstalledVersion";
            this.ColumnModsInstalledVersion.ReadOnly = true;
            // 
            // ColumnModsInstalledNoOfFiles
            // 
            this.ColumnModsInstalledNoOfFiles.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledNoOfFiles.HeaderText = "# Files";
            this.ColumnModsInstalledNoOfFiles.MinimumWidth = 6;
            this.ColumnModsInstalledNoOfFiles.Name = "ColumnModsInstalledNoOfFiles";
            this.ColumnModsInstalledNoOfFiles.ReadOnly = true;
            // 
            // ColumnModsInstalledDateTime
            // 
            this.ColumnModsInstalledDateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumnModsInstalledDateTime.HeaderText = "Installed On";
            this.ColumnModsInstalledDateTime.Name = "ColumnModsInstalledDateTime";
            this.ColumnModsInstalledDateTime.ReadOnly = true;
            // 
            // ColumnModsInstalledUninstall
            // 
            this.ColumnModsInstalledUninstall.HeaderText = "";
            this.ColumnModsInstalledUninstall.MinimumWidth = 6;
            this.ColumnModsInstalledUninstall.Name = "ColumnModsInstalledUninstall";
            this.ColumnModsInstalledUninstall.ReadOnly = true;
            this.ColumnModsInstalledUninstall.Width = 28;
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 4";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Custom 4";
            // 
            // GroupModsLibrary
            // 
            this.GroupModsLibrary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupModsLibrary.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupModsLibrary.AppearanceCaption.Options.UseFont = true;
            this.GroupModsLibrary.Controls.Add(this.LabelNoModsFound);
            this.GroupModsLibrary.Controls.Add(this.GridControlMods);
            this.GroupModsLibrary.Controls.Add(this.PanelModsLibraryFilters);
            this.GroupModsLibrary.Location = new System.Drawing.Point(287, 39);
            this.GroupModsLibrary.Name = "GroupModsLibrary";
            this.GroupModsLibrary.Size = new System.Drawing.Size(901, 534);
            this.GroupModsLibrary.TabIndex = 1167;
            this.GroupModsLibrary.Text = "MODS LIBRARY";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.NavGroupGames;
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.NavGroupGames,
            this.NavGroupHomebrewApps,
            this.NavGroupResources,
            this.NavGroupMyLists});
            this.navBarControl1.Location = new System.Drawing.Point(2, 23);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 262;
            this.navBarControl1.Size = new System.Drawing.Size(262, 718);
            this.navBarControl1.SkinExplorerBarViewScrollStyle = DevExpress.XtraNavBar.SkinExplorerBarViewScrollStyle.ScrollBar;
            this.navBarControl1.TabIndex = 1180;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.View = new DevExpress.XtraNavBar.ViewInfo.StandardSkinExplorerBarViewInfoRegistrator("Office 2019 Black");
            // 
            // NavGroupGames
            // 
            this.NavGroupGames.Caption = "GAMES";
            this.NavGroupGames.Expanded = true;
            this.NavGroupGames.Name = "NavGroupGames";
            // 
            // NavGroupHomebrewApps
            // 
            this.NavGroupHomebrewApps.Caption = "HOMEBREW APPLICATIONS";
            this.NavGroupHomebrewApps.Expanded = true;
            this.NavGroupHomebrewApps.Name = "NavGroupHomebrewApps";
            // 
            // NavGroupResources
            // 
            this.NavGroupResources.Caption = "RESOURCES";
            this.NavGroupResources.Expanded = true;
            this.NavGroupResources.Name = "NavGroupResources";
            // 
            // NavGroupMyLists
            // 
            this.NavGroupMyLists.Caption = "MY LISTS";
            this.NavGroupMyLists.Expanded = true;
            this.NavGroupMyLists.Name = "NavGroupMyLists";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.navBarControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 39);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(266, 743);
            this.groupControl1.TabIndex = 1185;
            this.groupControl1.Text = "CATEGORIES";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.LabelNoModsInstalled);
            this.groupControl2.Controls.Add(this.GridControlGameModsInstalled);
            buttonImageOptions1.Location = DevExpress.XtraEditors.ButtonPanel.ImageLocation.AfterText;
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Uninstall All", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", 2, true, null, false, false, true, null, 2)});
            this.groupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl2.Location = new System.Drawing.Point(287, 579);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(901, 203);
            this.groupControl2.TabIndex = 1179;
            this.groupControl2.Text = "MODS INSTALLED";
            // 
            // bar4
            // 
            this.bar4.BarName = "Custom 4";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 1;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Custom 4";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar7});
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockControls.Add(this.barDockControl2);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.StatusBar = this.bar7;
            // 
            // bar7
            // 
            this.bar7.BarName = "Status bar";
            this.bar7.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar7.OptionsBar.AllowQuickCustomization = false;
            this.bar7.OptionsBar.DrawDragBorder = false;
            this.bar7.OptionsBar.UseWholeRow = true;
            this.bar7.Text = "Status bar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Size = new System.Drawing.Size(1584, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 802);
            this.barDockControl2.Manager = this.barManager1;
            this.barDockControl2.Size = new System.Drawing.Size(1584, 19);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager1;
            this.barDockControl3.Size = new System.Drawing.Size(0, 802);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1584, 0);
            this.barDockControl4.Manager = this.barManager1;
            this.barDockControl4.Size = new System.Drawing.Size(0, 802);
            // 
            // MainWindow
            // 
            this.Appearance.ForeColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1584, 821);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GroupModsLibrary);
            this.Controls.Add(this.SectionArchiveInformation);
            this.Controls.Add(this.SectionGames);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainWindow.IconOptions.Icon")));
            this.IconOptions.Image = global::ModioX.Properties.Resources.app_logo;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1586, 853);
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModioX - Beta v1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ContextMenuMods.ResumeLayout(false);
            this.FlowPanelDetails.ResumeLayout(false);
            this.FlowPanelDetails.PerformLayout();
            this.SectionModsInstallFilePaths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlModsInstallFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewModsInstallFiles)).EndInit();
            this.SectionArchiveInformation.ResumeLayout(false);
            this.SectionArchiveInformation.PerformLayout();
            this.PanelModsInstallationPaths.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridControlMods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewMods)).EndInit();
            this.PanelModsLibraryFilters.ResumeLayout(false);
            this.PanelModsLibraryFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRegion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApplicationsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxModType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxSystemType.Properties)).EndInit();
            this.SectionGames.ResumeLayout(false);
            this.FlowPanelCategories.ResumeLayout(false);
            this.FlowPanelCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridControlGameModsInstalled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGameModsInstalled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupModsLibrary)).EndInit();
            this.GroupModsLibrary.ResumeLayout(false);
            this.GroupModsLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelSelectType;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelDetails;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelHeaderAuthor;
        private System.Windows.Forms.Label LabelHeaderVersion;
        private System.Windows.Forms.Label LabelVersion;
        private System.Windows.Forms.Label LabelHeaderGameType;
        private System.Windows.Forms.Label LabelConfig;
        private System.Windows.Forms.Label LabelDescription;
        private DarkUI.Controls.DarkScrollBar ScrollBarDetails;
        private DarkUI.Controls.DarkSectionPanel SectionArchiveInformation;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConnectedConsole;
        private System.Windows.Forms.ToolStripSeparator ToolStripStatusSeperator0;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStatus;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelConsole;
        private DarkUI.Controls.DarkToolStrip ToolStripArchiveInformation;
        private System.Windows.Forms.ToolStripLabel ToolStripLabelStats;
        private System.Windows.Forms.Label LabelHeaderSubmittedBy;
        private System.Windows.Forms.Label LabelSubmittedBy;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.Label LabelHeaderModType;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label LabelSelectSystemType;
        private System.Windows.Forms.Label LabelHeaderFirmware;
        private System.Windows.Forms.Label LabelFirmware;
        private System.Windows.Forms.Label LabelCategory;
        private System.Windows.Forms.Label LabelHeaderCategory;
        private DarkUI.Controls.DarkContextMenu ContextMenuMods;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsInstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsUninstallFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsDownloadArchive;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeparator0;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsReportOnGitHub;
        private System.Windows.Forms.ToolStripButton ToolItemModInstall;
        private System.Windows.Forms.ToolStripButton ToolItemModDownload;
        private DarkUI.Controls.DarkSectionPanel SectionGames;
        private DevExpress.XtraGrid.GridControl GridControlMods;
        private DarkUI.Controls.DarkSectionPanel SectionModsInstallFilePaths;
        private System.Windows.Forms.ToolStripButton ToolItemModUninstall;
        private System.Windows.Forms.ToolStripButton ToolItemModAddToFavorite;
        private System.Windows.Forms.Panel PanelModsInstallationPaths;
        private System.Windows.Forms.Label LabelHeaderName;
        private System.Windows.Forms.Panel PanelModsLibraryFilters;
        private DarkUI.Controls.DarkTextBox TextBoxSearch;
        private System.Windows.Forms.Label LabelSearch;
        private DarkUI.Controls.DarkTitle LabelTitleMods;
        private DarkUI.Controls.DarkTitle LabelTitleFilterMods;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelCategories;
        private DarkUI.Controls.DarkTitle LabelTitleGames;
        private System.Windows.Forms.FlowLayoutPanel PanelGames;
        private DarkUI.Controls.DarkTitle LabelTitleResources;
        private System.Windows.Forms.FlowLayoutPanel PanelResources;
        private DarkUI.Controls.DarkScrollBar ScrollBarCategories;
        private DarkUI.Controls.DarkTitle LabelTitleMyLists;
        private System.Windows.Forms.FlowLayoutPanel PanelLists;
        private DarkUI.Controls.DarkTitle LabelTitleModDetails;
        private DarkUI.Controls.DarkTitle LabelTitleModDescription;
        private DevExpress.XtraGrid.GridControl GridControlGameModsInstalled;
        private DarkUI.Controls.DarkTitle LabelHeaderInstallationFiles;
        private System.Windows.Forms.ToolStripButton ToolItemGameModsUninstallAll;
        private System.Windows.Forms.ToolStripLabel LabelInstalledGameModsStatus;
        private System.Windows.Forms.Label LabelHeaderRegion;
        private System.Windows.Forms.Label LabelRegion;
        private System.Windows.Forms.Label LabelSelectRegion;
        private System.Windows.Forms.Label LabelNoModsFound;
        private System.Windows.Forms.Label LabelNoModsInstalled;
        private DarkUI.Controls.DarkTitle LabelTitleHomebrew;
        private System.Windows.Forms.FlowLayoutPanel PanelHomebrew;
        private DevExpress.XtraGrid.GridControl GridControlModsInstallFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstallationFiles;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsAddToList;
        private System.Windows.Forms.ToolStripSeparator ContextMenuModsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ContextMenuModsRemoveFromList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsFirmware;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsNoFiles;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsInstall;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsDownload;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsFavourite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledGameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledModName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledModType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledNoOfFiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnModsInstalledDateTime;
        private System.Windows.Forms.DataGridViewImageColumn ColumnModsInstalledUninstall;
        private BarManager MainMenu;
        private Bar bar2;
        private BarButtonItem ConnectMenuBar;
        private PopupMenu HelpMenu;
        private BarButtonItem ToolsMenuBar;
        private PopupMenu OptionsMenu;
        private BarButtonItem ApplicationMenuBar;
        private PopupMenu ApplicationsMenu;
        private BarButtonItem OptionsMenuBar;
        private PopupMenu ToolsMenu;
        private BarButtonItem HelpMenuBar;
        private PopupMenu ConnectMenu;
        private Bar bar3;
        private BarDockControl barDockControlTop;
        private BarDockControl barDockControlBottom;
        private BarDockControl barDockControlLeft;
        private BarDockControl barDockControlRight;
        private BarButtonItem barButtonItem6;
        private BarButtonItem barButtonItem7;
        private ComboBoxEdit ComboBoxSystemType;
        private BarButtonItem GameBackupFilesButton;
        private BarButtonItem GameUpdateFinderButton;
        private BarButtonItem FileManagerButton;
        private BarButtonItem PackageManagerButton;
        private BarSubItem barSubItem1;
        private BarToolbarsListItem barToolbarsListItem1;
        private BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private BarButtonItem AddConsoleButton;
        private BarButtonItem EditGameRegionButton;
        private BarButtonItem EditApplicationsButton;
        private BarButtonItem EditYourLists;
        private BarButtonItem barButtonItem16;
        private SkinBarSubItem skinBarSubItem1;
        private BarButtonItem Exitbutton;
        private BarButtonItem ReportBugButton;
        private BarButtonItem DiscordServerButton;
        private BarButtonItem HelpSpacer1;
        private BarButtonItem OfficailSourceButton;
        private BarButtonItem OpenLogFileButton;
        private BarButtonItem OpenLogFolderButton;
        private BarButtonItem HelpSpacer2;
        private BarButtonItem CheckForUpdateButton;
        private BarButtonItem WhatsNewButton;
        private BarButtonItem HelpSpacer3;
        private BarButtonItem AboutBar;
        private BarSubItem PS3ConnectMenu;
        private BarButtonItem PS3ConnectButton;
        private BarSubItem XBConsole;
        private BarButtonItem Xbox360ConnectButton;
        private BarDockingMenuItem barDockingMenuItem1;
        private BarSubItem WebManControlsMenu;
        private BarSubItem barSubItem3;
        private BarButtonItem ShutDownButtonBar;
        private BarButtonItem RestartButtonBar;
        private BarButtonItem barButtonItem20;
        private BarButtonItem barButtonItem21;
        private BarSubItem barSubItem4;
        private BarButtonItem barButtonItem23;
        private BarButtonItem barButtonItem24;
        private BarButtonItem barButtonItem26;
        private BarButtonItem barButtonItem15;
        private BarButtonItem barButtonItem17;
        private BarButtonItem barButtonItem27;
        private BarButtonItem barButtonItem28;
        private Bar bar1;
        private BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewModsInstallFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewMods;
        private DevExpress.XtraGrid.Views.Grid.GridView GridViewGameModsInstalled;
        private ComboBoxEdit ComboBoxRegion;
        private ComboBoxEdit ComboBoxModType;
        private BarHeaderItem HeaderConsoleConnected;
        private BarStaticItem LabelConsoleConnected;
        private BarToolbarsListItem barToolbarsListItem2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupGames;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupHomebrewApps;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupResources;
        private DevExpress.XtraNavBar.NavBarGroup NavGroupMyLists;
        private GroupControl GroupModsLibrary;
        private GroupControl groupControl2;
        private GroupControl groupControl1;
        private Bar bar4;
        private BarDockControl barDockControl3;
        private BarManager barManager1;
        private Bar bar7;
        private BarDockControl barDockControl1;
        private BarDockControl barDockControl2;
        private BarDockControl barDockControl4;
    }
}