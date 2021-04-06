
using System.Windows.Forms;

namespace FirstPass
{
    partial class MasterForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateNewButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFilebutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.NewEntryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.LockButton = new System.Windows.Forms.ToolStripButton();
            this.StegImport = new System.Windows.Forms.ToolStripButton();
            this.StegExort = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewFileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quickGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addingEntriesToTheFielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultThemeOption = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeOption = new System.Windows.Forms.ToolStripMenuItem();
            this.textSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultTextSizeOption = new System.Windows.Forms.ToolStripMenuItem();
            this.smallTextSizeOption = new System.Windows.Forms.ToolStripMenuItem();
            this.largeTextSizeOption = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.SearchbyLabel = new System.Windows.Forms.Label();
            this.SearchByComboBox = new System.Windows.Forms.ComboBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.AddNewEntry = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CopyAndDeleteCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyUserNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyURLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EntryVariablesPanel = new System.Windows.Forms.Panel();
            this.EntryVariablesExpirationTextBox = new System.Windows.Forms.TextBox();
            this.EntryVariablesExpirationLabel = new System.Windows.Forms.Label();
            this.EntryVariablesPasswordTextBox = new System.Windows.Forms.TextBox();
            this.EntryVariablesConfirmButton = new System.Windows.Forms.Button();
            this.EntryVariablesUrlTextBox = new System.Windows.Forms.TextBox();
            this.EntryVariablesUsernameTextBox = new System.Windows.Forms.TextBox();
            this.EntryVariablesTitleTextBox = new System.Windows.Forms.TextBox();
            this.EntryVariablesUrlLabel = new System.Windows.Forms.Label();
            this.EntryVariablesPasswordLabel = new System.Windows.Forms.Label();
            this.EntryVariablesUsernameLabel = new System.Windows.Forms.Label();
            this.EntryVariablesTitleLabel = new System.Windows.Forms.Label();
            this.EntryVariablesHeaderLabel = new System.Windows.Forms.Label();
            this.entryNotes = new System.Windows.Forms.RichTextBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CopyAndDeleteCMS.SuspendLayout();
            this.EntryVariablesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewButton,
            this.OpenFileButton,
            this.SaveFilebutton,
            this.toolStripSeparator4,
            this.NewEntryButton,
            this.toolStripSeparator7,
            this.LockButton,
            this.StegImport,
            this.StegExort});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(972, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "ToolBar";
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CreateNewButton.Image = global::FirstPass.Properties.Resources.plus;
            this.CreateNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(28, 28);
            this.CreateNewButton.Text = "New Password File";
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFileButton.Image = global::FirstPass.Properties.Resources.open_icon;
            this.OpenFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(28, 28);
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // SaveFilebutton
            // 
            this.SaveFilebutton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFilebutton.Image = global::FirstPass.Properties.Resources.save;
            this.SaveFilebutton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFilebutton.Name = "SaveFilebutton";
            this.SaveFilebutton.Size = new System.Drawing.Size(28, 28);
            this.SaveFilebutton.Text = "Save";
            this.SaveFilebutton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // NewEntryButton
            // 
            this.NewEntryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewEntryButton.Image = global::FirstPass.Properties.Resources.editIcon;
            this.NewEntryButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewEntryButton.Name = "NewEntryButton";
            this.NewEntryButton.Size = new System.Drawing.Size(28, 28);
            this.NewEntryButton.Text = "toolStripButton4";
            this.NewEntryButton.ToolTipText = "New Entry";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // LockButton
            // 
            this.LockButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LockButton.Image = global::FirstPass.Properties.Resources._lock;
            this.LockButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LockButton.Name = "LockButton";
            this.LockButton.Size = new System.Drawing.Size(28, 28);
            this.LockButton.Text = "Lock File";
            this.LockButton.ToolTipText = "Lock File";
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // StegImport
            // 
            this.StegImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StegImport.Image = global::FirstPass.Properties.Resources.fileimport;
            this.StegImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StegImport.Name = "StegImport";
            this.StegImport.Size = new System.Drawing.Size(28, 28);
            this.StegImport.Text = "StegImport";
            this.StegImport.ToolTipText = "Import new file through Steganography";
            this.StegImport.Click += new System.EventHandler(this.StegImport_Click);
            // 
            // StegExort
            // 
            this.StegExort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StegExort.Image = global::FirstPass.Properties.Resources.fileexport;
            this.StegExort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StegExort.Name = "StegExort";
            this.StegExort.Size = new System.Drawing.Size(28, 28);
            this.StegExort.Text = "StegExport";
            this.StegExort.ToolTipText = "Export file to image through Steganography.";
            this.StegExort.Click += new System.EventHandler(this.StegExort_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropDown,
            this.helpToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(972, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "Menu Bar";
            // 
            // FileDropDown
            // 
            this.FileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateNewFileDropDown,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem1,
            this.toolStripSeparator2,
            this.printToolStripMenuItem});
            this.FileDropDown.Name = "FileDropDown";
            this.FileDropDown.Size = new System.Drawing.Size(37, 22);
            this.FileDropDown.Text = "File";
            // 
            // CreateNewFileDropDown
            // 
            this.CreateNewFileDropDown.Name = "CreateNewFileDropDown";
            this.CreateNewFileDropDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateNewFileDropDown.Size = new System.Drawing.Size(180, 22);
            this.CreateNewFileDropDown.Text = "New";
            this.CreateNewFileDropDown.Click += new System.EventHandler(this.CreateNewFileDropDown_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileDropDown});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // OpenFileDropDown
            // 
            this.OpenFileDropDown.Name = "OpenFileDropDown";
            this.OpenFileDropDown.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenFileDropDown.Size = new System.Drawing.Size(167, 22);
            this.OpenFileDropDown.Text = "Open File";
            this.OpenFileDropDown.Click += new System.EventHandler(this.OpenFileDropDown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.AccessibleName = "DropDownPrint";
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickGuideToolStripMenuItem,
            this.openingAFileToolStripMenuItem,
            this.addingEntriesToTheFielToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // quickGuideToolStripMenuItem
            // 
            this.quickGuideToolStripMenuItem.Name = "quickGuideToolStripMenuItem";
            this.quickGuideToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.N)));
            this.quickGuideToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.quickGuideToolStripMenuItem.Text = "Creating a new file";
            this.quickGuideToolStripMenuItem.Click += new System.EventHandler(this.quickGuideToolStripMenuItem_Click_1);
            // 
            // openingAFileToolStripMenuItem
            // 
            this.openingAFileToolStripMenuItem.Name = "openingAFileToolStripMenuItem";
            this.openingAFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.O)));
            this.openingAFileToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.openingAFileToolStripMenuItem.Text = "Opening a file";
            this.openingAFileToolStripMenuItem.Click += new System.EventHandler(this.openingAFileToolStripMenuItem_Click);
            // 
            // addingEntriesToTheFielToolStripMenuItem
            // 
            this.addingEntriesToTheFielToolStripMenuItem.Name = "addingEntriesToTheFielToolStripMenuItem";
            this.addingEntriesToTheFielToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.A)));
            this.addingEntriesToTheFielToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.addingEntriesToTheFielToolStripMenuItem.Text = "Adding entries to the file";
            this.addingEntriesToTheFielToolStripMenuItem.Click += new System.EventHandler(this.addingEntriesToTheFielToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.textSizeToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultThemeOption,
            this.darkThemeOption});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // defaultThemeOption
            // 
            this.defaultThemeOption.Name = "defaultThemeOption";
            this.defaultThemeOption.Size = new System.Drawing.Size(112, 22);
            this.defaultThemeOption.Text = "Default";
            this.defaultThemeOption.Click += new System.EventHandler(this.defaultThemeOption_Click);
            // 
            // darkThemeOption
            // 
            this.darkThemeOption.Name = "darkThemeOption";
            this.darkThemeOption.Size = new System.Drawing.Size(112, 22);
            this.darkThemeOption.Text = "Dark";
            this.darkThemeOption.Click += new System.EventHandler(this.darkThemeOption_Click);
            // 
            // textSizeToolStripMenuItem
            // 
            this.textSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultTextSizeOption,
            this.smallTextSizeOption,
            this.largeTextSizeOption});
            this.textSizeToolStripMenuItem.Name = "textSizeToolStripMenuItem";
            this.textSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textSizeToolStripMenuItem.Text = "Text Size";
            // 
            // defaultTextSizeOption
            // 
            this.defaultTextSizeOption.Name = "defaultTextSizeOption";
            this.defaultTextSizeOption.Size = new System.Drawing.Size(112, 22);
            this.defaultTextSizeOption.Text = "Default";
            this.defaultTextSizeOption.Click += new System.EventHandler(this.defaultTextSizeOption_Click);
            // 
            // smallTextSizeOption
            // 
            this.smallTextSizeOption.Name = "smallTextSizeOption";
            this.smallTextSizeOption.Size = new System.Drawing.Size(112, 22);
            this.smallTextSizeOption.Text = "Small";
            this.smallTextSizeOption.Click += new System.EventHandler(this.smallTextSizeOption_Click);
            // 
            // largeTextSizeOption
            // 
            this.largeTextSizeOption.Name = "largeTextSizeOption";
            this.largeTextSizeOption.Size = new System.Drawing.Size(112, 22);
            this.largeTextSizeOption.Text = "Large";
            this.largeTextSizeOption.Click += new System.EventHandler(this.largeTextSizeOption_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(972, 515);
            this.splitContainer1.SplitterDistance = 232;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::FirstPass.Properties.Resources.person;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.SearchbyLabel);
            this.splitContainer2.Panel1.Controls.Add(this.SearchByComboBox);
            this.splitContainer2.Panel1.Controls.Add(this.SearchBox);
            this.splitContainer2.Panel1.Controls.Add(this.SearchLabel);
            this.splitContainer2.Panel1.Controls.Add(this.AddNewEntry);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.EntryVariablesPanel);
            this.splitContainer2.Panel2.Controls.Add(this.entryNotes);
            this.splitContainer2.Size = new System.Drawing.Size(737, 515);
            this.splitContainer2.SplitterDistance = 222;
            this.splitContainer2.SplitterWidth = 2;
            this.splitContainer2.TabIndex = 0;
            // 
            // SearchbyLabel
            // 
            this.SearchbyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchbyLabel.AutoSize = true;
            this.SearchbyLabel.Location = new System.Drawing.Point(589, 3);
            this.SearchbyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchbyLabel.Name = "SearchbyLabel";
            this.SearchbyLabel.Size = new System.Drawing.Size(58, 13);
            this.SearchbyLabel.TabIndex = 7;
            this.SearchbyLabel.Text = "Search by:";
            // 
            // SearchByComboBox
            // 
            this.SearchByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SearchByComboBox.FormattingEnabled = true;
            this.SearchByComboBox.Items.AddRange(new object[] {
            "Title",
            "Username",
            "URL"});
            this.SearchByComboBox.Location = new System.Drawing.Point(649, 1);
            this.SearchByComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchByComboBox.Name = "SearchByComboBox";
            this.SearchByComboBox.Size = new System.Drawing.Size(82, 21);
            this.SearchByComboBox.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(43, 3);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(543, 20);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Location = new System.Drawing.Point(2, 3);
            this.SearchLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(44, 13);
            this.SearchLabel.TabIndex = 4;
            this.SearchLabel.Text = "Search:";
            // 
            // AddNewEntry
            // 
            this.AddNewEntry.AccessibleName = "AddNewEntry";
            this.AddNewEntry.AutoSize = true;
            this.AddNewEntry.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddNewEntry.Location = new System.Drawing.Point(0, 189);
            this.AddNewEntry.Margin = new System.Windows.Forms.Padding(1);
            this.AddNewEntry.Name = "AddNewEntry";
            this.AddNewEntry.Size = new System.Drawing.Size(737, 33);
            this.AddNewEntry.TabIndex = 1;
            this.AddNewEntry.Text = "Add new entry";
            this.AddNewEntry.UseVisualStyleBackColor = true;
            this.AddNewEntry.Click += new System.EventHandler(this.AddNewEntry_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.CopyAndDeleteCMS;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(737, 153);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter_1);
            // 
            // CopyAndDeleteCMS
            // 
            this.CopyAndDeleteCMS.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CopyAndDeleteCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.CopyAndDeleteCMS.Name = "CopyAndDeleteCMS";
            this.CopyAndDeleteCMS.Size = new System.Drawing.Size(182, 48);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete row";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyUserNameToolStripMenuItem,
            this.copyPasswordToolStripMenuItem,
            this.copyURLToolStripMenuItem});
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // copyUserNameToolStripMenuItem
            // 
            this.copyUserNameToolStripMenuItem.Name = "copyUserNameToolStripMenuItem";
            this.copyUserNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.copyUserNameToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.copyUserNameToolStripMenuItem.Text = "Copy user name";
            this.copyUserNameToolStripMenuItem.Click += new System.EventHandler(this.copyUserNameToolStripMenuItem_Click);
            // 
            // copyPasswordToolStripMenuItem
            // 
            this.copyPasswordToolStripMenuItem.Name = "copyPasswordToolStripMenuItem";
            this.copyPasswordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyPasswordToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.copyPasswordToolStripMenuItem.Text = "Copy password";
            this.copyPasswordToolStripMenuItem.Click += new System.EventHandler(this.copyPasswordToolStripMenuItem_Click);
            // 
            // copyURLToolStripMenuItem
            // 
            this.copyURLToolStripMenuItem.Name = "copyURLToolStripMenuItem";
            this.copyURLToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.copyURLToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.copyURLToolStripMenuItem.Text = "Copy URL";
            this.copyURLToolStripMenuItem.Click += new System.EventHandler(this.copyURLToolStripMenuItem_Click);
            // 
            // EntryVariablesPanel
            // 
            this.EntryVariablesPanel.AutoScroll = true;
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesExpirationTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesExpirationLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesPasswordTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesConfirmButton);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUrlTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUsernameTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesTitleTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUrlLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesPasswordLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUsernameLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesTitleLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesHeaderLabel);
            this.EntryVariablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntryVariablesPanel.Location = new System.Drawing.Point(0, 0);
            this.EntryVariablesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.EntryVariablesPanel.Name = "EntryVariablesPanel";
            this.EntryVariablesPanel.Size = new System.Drawing.Size(354, 291);
            this.EntryVariablesPanel.TabIndex = 2;
            // 
            // EntryVariablesExpirationTextBox
            // 
            this.EntryVariablesExpirationTextBox.AccessibleName = "EntryVariablesExpirationTextBox";
            this.EntryVariablesExpirationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesExpirationTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesExpirationTextBox.Location = new System.Drawing.Point(106, 31);
            this.EntryVariablesExpirationTextBox.Name = "EntryVariablesExpirationTextBox";
            this.EntryVariablesExpirationTextBox.Size = new System.Drawing.Size(243, 20);
            this.EntryVariablesExpirationTextBox.TabIndex = 12;
            // 
            // EntryVariablesExpirationLabel
            // 
            this.EntryVariablesExpirationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesExpirationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesExpirationLabel.Location = new System.Drawing.Point(3, 30);
            this.EntryVariablesExpirationLabel.Name = "EntryVariablesExpirationLabel";
            this.EntryVariablesExpirationLabel.Size = new System.Drawing.Size(206, 20);
            this.EntryVariablesExpirationLabel.TabIndex = 11;
            this.EntryVariablesExpirationLabel.Text = "Expiration Date:";
            this.EntryVariablesExpirationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryVariablesPasswordTextBox
            // 
            this.EntryVariablesPasswordTextBox.AccessibleName = "EntryVariablesPasswordTextBox";
            this.EntryVariablesPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesPasswordTextBox.Location = new System.Drawing.Point(106, 162);
            this.EntryVariablesPasswordTextBox.Name = "EntryVariablesPasswordTextBox";
            this.EntryVariablesPasswordTextBox.PasswordChar = '*';
            this.EntryVariablesPasswordTextBox.ReadOnly = true;
            this.EntryVariablesPasswordTextBox.Size = new System.Drawing.Size(243, 20);
            this.EntryVariablesPasswordTextBox.TabIndex = 10;
            this.EntryVariablesPasswordTextBox.Enter += new System.EventHandler(this.EntryVariablesPasswordTextBox_Enter_1);
            // 
            // EntryVariablesConfirmButton
            // 
            this.EntryVariablesConfirmButton.AccessibleName = "EntryVariablesConfirmButton";
            this.EntryVariablesConfirmButton.AutoSize = true;
            this.EntryVariablesConfirmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EntryVariablesConfirmButton.Location = new System.Drawing.Point(0, 268);
            this.EntryVariablesConfirmButton.Margin = new System.Windows.Forms.Padding(2);
            this.EntryVariablesConfirmButton.Name = "EntryVariablesConfirmButton";
            this.EntryVariablesConfirmButton.Size = new System.Drawing.Size(354, 23);
            this.EntryVariablesConfirmButton.TabIndex = 9;
            this.EntryVariablesConfirmButton.Text = "Confirm";
            this.EntryVariablesConfirmButton.UseVisualStyleBackColor = true;
            this.EntryVariablesConfirmButton.Click += new System.EventHandler(this.EntryVariablesConfirmButton_Click);
            // 
            // EntryVariablesUrlTextBox
            // 
            this.EntryVariablesUrlTextBox.AccessibleName = "EntryVariablesUrlTextBox";
            this.EntryVariablesUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesUrlTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesUrlTextBox.Location = new System.Drawing.Point(106, 207);
            this.EntryVariablesUrlTextBox.Name = "EntryVariablesUrlTextBox";
            this.EntryVariablesUrlTextBox.Size = new System.Drawing.Size(243, 20);
            this.EntryVariablesUrlTextBox.TabIndex = 8;
            // 
            // EntryVariablesUsernameTextBox
            // 
            this.EntryVariablesUsernameTextBox.AccessibleName = "EntryVariablesUsernameTextBox";
            this.EntryVariablesUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesUsernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesUsernameTextBox.Location = new System.Drawing.Point(106, 116);
            this.EntryVariablesUsernameTextBox.Name = "EntryVariablesUsernameTextBox";
            this.EntryVariablesUsernameTextBox.Size = new System.Drawing.Size(243, 20);
            this.EntryVariablesUsernameTextBox.TabIndex = 6;
            // 
            // EntryVariablesTitleTextBox
            // 
            this.EntryVariablesTitleTextBox.AccessibleName = "EntryVariablesTitleTextBox";
            this.EntryVariablesTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesTitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesTitleTextBox.Location = new System.Drawing.Point(106, 73);
            this.EntryVariablesTitleTextBox.Name = "EntryVariablesTitleTextBox";
            this.EntryVariablesTitleTextBox.Size = new System.Drawing.Size(243, 20);
            this.EntryVariablesTitleTextBox.TabIndex = 5;
            // 
            // EntryVariablesUrlLabel
            // 
            this.EntryVariablesUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesUrlLabel.Location = new System.Drawing.Point(3, 207);
            this.EntryVariablesUrlLabel.Name = "EntryVariablesUrlLabel";
            this.EntryVariablesUrlLabel.Size = new System.Drawing.Size(225, 20);
            this.EntryVariablesUrlLabel.TabIndex = 4;
            this.EntryVariablesUrlLabel.Text = "URL: ";
            this.EntryVariablesUrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryVariablesPasswordLabel
            // 
            this.EntryVariablesPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesPasswordLabel.Location = new System.Drawing.Point(3, 162);
            this.EntryVariablesPasswordLabel.Name = "EntryVariablesPasswordLabel";
            this.EntryVariablesPasswordLabel.Size = new System.Drawing.Size(206, 20);
            this.EntryVariablesPasswordLabel.TabIndex = 3;
            this.EntryVariablesPasswordLabel.Text = "Password:";
            this.EntryVariablesPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryVariablesUsernameLabel
            // 
            this.EntryVariablesUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesUsernameLabel.Location = new System.Drawing.Point(3, 116);
            this.EntryVariablesUsernameLabel.Name = "EntryVariablesUsernameLabel";
            this.EntryVariablesUsernameLabel.Size = new System.Drawing.Size(206, 20);
            this.EntryVariablesUsernameLabel.TabIndex = 2;
            this.EntryVariablesUsernameLabel.Text = "Username:";
            this.EntryVariablesUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryVariablesTitleLabel
            // 
            this.EntryVariablesTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesTitleLabel.Location = new System.Drawing.Point(3, 72);
            this.EntryVariablesTitleLabel.Name = "EntryVariablesTitleLabel";
            this.EntryVariablesTitleLabel.Size = new System.Drawing.Size(206, 20);
            this.EntryVariablesTitleLabel.TabIndex = 1;
            this.EntryVariablesTitleLabel.Text = "Title:";
            this.EntryVariablesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EntryVariablesHeaderLabel
            // 
            this.EntryVariablesHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryVariablesHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.EntryVariablesHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EntryVariablesHeaderLabel.Name = "EntryVariablesHeaderLabel";
            this.EntryVariablesHeaderLabel.Size = new System.Drawing.Size(354, 19);
            this.EntryVariablesHeaderLabel.TabIndex = 0;
            this.EntryVariablesHeaderLabel.Text = "Entry Variables";
            this.EntryVariablesHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryNotes
            // 
            this.entryNotes.Dock = System.Windows.Forms.DockStyle.Right;
            this.entryNotes.Location = new System.Drawing.Point(354, 0);
            this.entryNotes.Margin = new System.Windows.Forms.Padding(2);
            this.entryNotes.Name = "entryNotes";
            this.entryNotes.Size = new System.Drawing.Size(383, 291);
            this.entryNotes.TabIndex = 1;
            this.entryNotes.Text = "";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 570);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterForm";
            this.Text = "PasswordKeeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MasterForm_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CopyAndDeleteCMS.ResumeLayout(false);
            this.EntryVariablesPanel.ResumeLayout(false);
            this.EntryVariablesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CreateNewButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileDropDown;
        private System.Windows.Forms.ToolStripMenuItem CreateNewFileDropDown;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileDropDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveFilebutton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton NewEntryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton LockButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button AddNewEntry;



        
        private System.Windows.Forms.DataGridView entryVariablesGridView;


        private System.Windows.Forms.RichTextBox entryNotes;

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quickGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addingEntriesToTheFielToolStripMenuItem;
        private System.Windows.Forms.Panel EntryVariablesPanel;
        private System.Windows.Forms.Label EntryVariablesHeaderLabel;
        private System.Windows.Forms.Label EntryVariablesTitleLabel;
        private System.Windows.Forms.Label EntryVariablesUsernameLabel;
        private System.Windows.Forms.Label EntryVariablesPasswordLabel;
        private System.Windows.Forms.Label EntryVariablesUrlLabel;
        private System.Windows.Forms.TextBox EntryVariablesTitleTextBox;
        private System.Windows.Forms.TextBox EntryVariablesUsernameTextBox;
        private System.Windows.Forms.TextBox EntryVariablesUrlTextBox;

        

        private System.Windows.Forms.Button EntryVariablesConfirmButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Label SearchbyLabel;
        private System.Windows.Forms.ComboBox SearchByComboBox;
        private ContextMenuStrip CopyAndDeleteCMS;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem copyUserNameToolStripMenuItem;
        private ToolStripMenuItem copyPasswordToolStripMenuItem;
        private ToolStripMenuItem copyURLToolStripMenuItem;
        private PictureBox pictureBox1;
        public TextBox EntryVariablesPasswordTextBox;
        private Label EntryVariablesExpirationLabel;
        public TextBox EntryVariablesExpirationTextBox;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem darkThemeOption;
        private ToolStripMenuItem textSizeToolStripMenuItem;
        private ToolStripMenuItem smallTextSizeOption;
        private ToolStripMenuItem largeTextSizeOption;
        private ToolStripMenuItem defaultTextSizeOption;
        private ToolStripMenuItem defaultThemeOption;
        private ToolStripButton StegImport;
        private ToolStripButton StegExort;
    }
}

