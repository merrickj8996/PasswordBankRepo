
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CreateNewButton = new System.Windows.Forms.ToolStripButton();
            this.OpenFileButton = new System.Windows.Forms.ToolStripButton();
            this.SaveFilebutton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.NewEntryButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyUsernameButton = new System.Windows.Forms.ToolStripButton();
            this.CopyPassword = new System.Windows.Forms.ToolStripButton();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.SearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.LockButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateNewFileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.passwordFileSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settignsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quickGuideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openingAFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addingEntriesToTheFielToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.EditRowButton = new System.Windows.Forms.Button();
            this.AddNewEntry = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EntryVariablesPanel = new System.Windows.Forms.Panel();
            this.EntryVariablesConfirmButton = new System.Windows.Forms.Button();
            this.EntryVariablesUrlTextBox = new System.Windows.Forms.TextBox();
            this.EntryVariablesPasswordTextBox = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStripSeparator5,
            this.CopyUsernameButton,
            this.CopyPassword,
            this.CopyButton,
            this.toolStripSeparator6,
            this.SearchButton,
            this.toolStripSeparator7,
            this.LockButton});
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
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // CopyUsernameButton
            // 
            this.CopyUsernameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyUsernameButton.Image = global::FirstPass.Properties.Resources.copyUsername;
            this.CopyUsernameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyUsernameButton.Name = "CopyUsernameButton";
            this.CopyUsernameButton.Size = new System.Drawing.Size(28, 28);
            this.CopyUsernameButton.Text = "Copy Username";
            // 
            // CopyPassword
            // 
            this.CopyPassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyPassword.Image = global::FirstPass.Properties.Resources.copyPassword;
            this.CopyPassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyPassword.Name = "CopyPassword";
            this.CopyPassword.Size = new System.Drawing.Size(28, 28);
            this.CopyPassword.Text = "Copy Password";
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = global::FirstPass.Properties.Resources.copyLink;
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(28, 28);
            this.CopyButton.Text = "Copy URL";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // SearchButton
            // 
            this.SearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SearchButton.Image = global::FirstPass.Properties.Resources.MagnifyingGlass;
            this.SearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(28, 28);
            this.SearchButton.Text = "Search";
            this.SearchButton.ToolTipText = "Search";
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileDropDown,
            this.groupToolStripMenuItem,
            this.helpToolStripMenuItem});
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
            this.passwordFileSettingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.printToolStripMenuItem});
            this.FileDropDown.Name = "FileDropDown";
            this.FileDropDown.Size = new System.Drawing.Size(37, 22);
            this.FileDropDown.Text = "File";
            // 
            // CreateNewFileDropDown
            // 
            this.CreateNewFileDropDown.Name = "CreateNewFileDropDown";
            this.CreateNewFileDropDown.Size = new System.Drawing.Size(186, 22);
            this.CreateNewFileDropDown.Text = "New";
            this.CreateNewFileDropDown.Click += new System.EventHandler(this.CreateNewFileDropDown_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileDropDown});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // OpenFileDropDown
            // 
            this.OpenFileDropDown.Name = "OpenFileDropDown";
            this.OpenFileDropDown.Size = new System.Drawing.Size(124, 22);
            this.OpenFileDropDown.Text = "Open File";
            this.OpenFileDropDown.Click += new System.EventHandler(this.OpenFileDropDown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem1.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(183, 6);
            // 
            // passwordFileSettingsToolStripMenuItem
            // 
            this.passwordFileSettingsToolStripMenuItem.Name = "passwordFileSettingsToolStripMenuItem";
            this.passwordFileSettingsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.passwordFileSettingsToolStripMenuItem.Text = "PasswordFile settings";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(183, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addGroupToolStripMenuItem,
            this.editGroupToolStripMenuItem});
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.groupToolStripMenuItem.Text = "Group";
            // 
            // addGroupToolStripMenuItem
            // 
            this.addGroupToolStripMenuItem.Name = "addGroupToolStripMenuItem";
            this.addGroupToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.addGroupToolStripMenuItem.Text = "Add Group";
            // 
            // editGroupToolStripMenuItem
            // 
            this.editGroupToolStripMenuItem.Name = "editGroupToolStripMenuItem";
            this.editGroupToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.editGroupToolStripMenuItem.Text = "Edit Group";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settignsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // settignsToolStripMenuItem
            // 
            this.settignsToolStripMenuItem.Name = "settignsToolStripMenuItem";
            this.settignsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settignsToolStripMenuItem.Text = "Settings";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickGuideToolStripMenuItem,
            this.openingAFileToolStripMenuItem,
            this.addingEntriesToTheFielToolStripMenuItem});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // quickGuideToolStripMenuItem
            // 
            this.quickGuideToolStripMenuItem.Name = "quickGuideToolStripMenuItem";
            this.quickGuideToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.quickGuideToolStripMenuItem.Text = "Creating a new file";
            this.quickGuideToolStripMenuItem.Click += new System.EventHandler(this.quickGuideToolStripMenuItem_Click_1);
            // 
            // openingAFileToolStripMenuItem
            // 
            this.openingAFileToolStripMenuItem.Name = "openingAFileToolStripMenuItem";
            this.openingAFileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openingAFileToolStripMenuItem.Text = "Opening a file";
            // 
            // addingEntriesToTheFielToolStripMenuItem
            // 
            this.addingEntriesToTheFielToolStripMenuItem.Name = "addingEntriesToTheFielToolStripMenuItem";
            this.addingEntriesToTheFielToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.addingEntriesToTheFielToolStripMenuItem.Text = "Adding entries to the file";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(972, 515);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "";
            treeNode1.Text = "Node4";
            treeNode2.Name = "";
            treeNode2.Text = "Node5";
            treeNode3.Name = "";
            treeNode3.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(236, 515);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.EditRowButton);
            this.splitContainer2.Panel1.Controls.Add(this.AddNewEntry);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.EntryVariablesPanel);
            this.splitContainer2.Panel2.Controls.Add(this.entryNotes);
            this.splitContainer2.Size = new System.Drawing.Size(732, 515);
            this.splitContainer2.SplitterDistance = 236;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // EditRowButton
            // 
            this.EditRowButton.Location = new System.Drawing.Point(358, 212);
            this.EditRowButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditRowButton.Name = "EditRowButton";
            this.EditRowButton.Size = new System.Drawing.Size(372, 24);
            this.EditRowButton.TabIndex = 2;
            this.EditRowButton.Text = "Edit selected row";
            this.EditRowButton.UseVisualStyleBackColor = true;
            // 
            // AddNewEntry
            // 
            this.AddNewEntry.AutoSize = true;
            this.AddNewEntry.Location = new System.Drawing.Point(0, 212);
            this.AddNewEntry.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.AddNewEntry.Name = "AddNewEntry";
            this.AddNewEntry.Size = new System.Drawing.Size(355, 23);
            this.AddNewEntry.TabIndex = 1;
            this.AddNewEntry.Text = "Add new entry";
            this.AddNewEntry.UseVisualStyleBackColor = true;
            this.AddNewEntry.Click += new System.EventHandler(this.AddNewEntry_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(732, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // EntryVariablesPanel
            // 
            this.EntryVariablesPanel.AutoScroll = true;
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesConfirmButton);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUrlTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesPasswordTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUsernameTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesTitleTextBox);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUrlLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesPasswordLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesUsernameLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesTitleLabel);
            this.EntryVariablesPanel.Controls.Add(this.EntryVariablesHeaderLabel);
            this.EntryVariablesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EntryVariablesPanel.Location = new System.Drawing.Point(0, 0);
            this.EntryVariablesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EntryVariablesPanel.Name = "EntryVariablesPanel";
            this.EntryVariablesPanel.Size = new System.Drawing.Size(368, 276);
            this.EntryVariablesPanel.TabIndex = 2;
            // 
            // EntryVariablesConfirmButton
            // 
            this.EntryVariablesConfirmButton.AutoSize = true;
            this.EntryVariablesConfirmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EntryVariablesConfirmButton.Location = new System.Drawing.Point(0, 253);
            this.EntryVariablesConfirmButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EntryVariablesConfirmButton.Name = "EntryVariablesConfirmButton";
            this.EntryVariablesConfirmButton.Size = new System.Drawing.Size(368, 23);
            this.EntryVariablesConfirmButton.TabIndex = 9;
            this.EntryVariablesConfirmButton.Text = "Confirm";
            this.EntryVariablesConfirmButton.UseVisualStyleBackColor = true;
            this.EntryVariablesConfirmButton.Click += new System.EventHandler(this.EntryVariablesConfirmButton_Click);
            // 
            // EntryVariablesUrlTextBox
            // 
            this.EntryVariablesUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesUrlTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesUrlTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntryVariablesUrlTextBox.Location = new System.Drawing.Point(36, 117);
            this.EntryVariablesUrlTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EntryVariablesUrlTextBox.Name = "EntryVariablesUrlTextBox";
            this.EntryVariablesUrlTextBox.Size = new System.Drawing.Size(324, 13);
            this.EntryVariablesUrlTextBox.TabIndex = 8;
            this.EntryVariablesUrlTextBox.Text = "www.testurl.com";
            // 
            // EntryVariablesPasswordTextBox
            // 
            this.EntryVariablesPasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesPasswordTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntryVariablesPasswordTextBox.Location = new System.Drawing.Point(63, 88);
            this.EntryVariablesPasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EntryVariablesPasswordTextBox.Name = "EntryVariablesPasswordTextBox";
            this.EntryVariablesPasswordTextBox.Size = new System.Drawing.Size(297, 13);
            this.EntryVariablesPasswordTextBox.TabIndex = 7;
            this.EntryVariablesPasswordTextBox.Text = "************";
            // 
            // EntryVariablesUsernameTextBox
            // 
            this.EntryVariablesUsernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesUsernameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesUsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntryVariablesUsernameTextBox.Location = new System.Drawing.Point(66, 58);
            this.EntryVariablesUsernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EntryVariablesUsernameTextBox.Name = "EntryVariablesUsernameTextBox";
            this.EntryVariablesUsernameTextBox.Size = new System.Drawing.Size(294, 13);
            this.EntryVariablesUsernameTextBox.TabIndex = 6;
            this.EntryVariablesUsernameTextBox.Text = "TestUsername";
            // 
            // EntryVariablesTitleTextBox
            // 
            this.EntryVariablesTitleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesTitleTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.EntryVariablesTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EntryVariablesTitleTextBox.Location = new System.Drawing.Point(36, 29);
            this.EntryVariablesTitleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EntryVariablesTitleTextBox.Name = "EntryVariablesTitleTextBox";
            this.EntryVariablesTitleTextBox.Size = new System.Drawing.Size(324, 13);
            this.EntryVariablesTitleTextBox.TabIndex = 5;
            this.EntryVariablesTitleTextBox.Text = "Test Title";
            // 
            // EntryVariablesUrlLabel
            // 
            this.EntryVariablesUrlLabel.AutoSize = true;
            this.EntryVariablesUrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesUrlLabel.Location = new System.Drawing.Point(2, 117);
            this.EntryVariablesUrlLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EntryVariablesUrlLabel.Name = "EntryVariablesUrlLabel";
            this.EntryVariablesUrlLabel.Size = new System.Drawing.Size(40, 13);
            this.EntryVariablesUrlLabel.TabIndex = 4;
            this.EntryVariablesUrlLabel.Text = "URL: ";
            this.EntryVariablesUrlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntryVariablesPasswordLabel
            // 
            this.EntryVariablesPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesPasswordLabel.AutoSize = true;
            this.EntryVariablesPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesPasswordLabel.Location = new System.Drawing.Point(2, 88);
            this.EntryVariablesPasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EntryVariablesPasswordLabel.Name = "EntryVariablesPasswordLabel";
            this.EntryVariablesPasswordLabel.Size = new System.Drawing.Size(65, 13);
            this.EntryVariablesPasswordLabel.TabIndex = 3;
            this.EntryVariablesPasswordLabel.Text = "Password:";
            this.EntryVariablesPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntryVariablesUsernameLabel
            // 
            this.EntryVariablesUsernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesUsernameLabel.AutoSize = true;
            this.EntryVariablesUsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesUsernameLabel.Location = new System.Drawing.Point(2, 58);
            this.EntryVariablesUsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EntryVariablesUsernameLabel.Name = "EntryVariablesUsernameLabel";
            this.EntryVariablesUsernameLabel.Size = new System.Drawing.Size(67, 13);
            this.EntryVariablesUsernameLabel.TabIndex = 2;
            this.EntryVariablesUsernameLabel.Text = "Username:";
            this.EntryVariablesUsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntryVariablesTitleLabel
            // 
            this.EntryVariablesTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntryVariablesTitleLabel.AutoSize = true;
            this.EntryVariablesTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesTitleLabel.Location = new System.Drawing.Point(2, 29);
            this.EntryVariablesTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EntryVariablesTitleLabel.Name = "EntryVariablesTitleLabel";
            this.EntryVariablesTitleLabel.Size = new System.Drawing.Size(36, 13);
            this.EntryVariablesTitleLabel.TabIndex = 1;
            this.EntryVariablesTitleLabel.Text = "Title:";
            this.EntryVariablesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EntryVariablesHeaderLabel
            // 
            this.EntryVariablesHeaderLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryVariablesHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryVariablesHeaderLabel.Location = new System.Drawing.Point(0, 0);
            this.EntryVariablesHeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EntryVariablesHeaderLabel.Name = "EntryVariablesHeaderLabel";
            this.EntryVariablesHeaderLabel.Size = new System.Drawing.Size(368, 13);
            this.EntryVariablesHeaderLabel.TabIndex = 0;
            this.EntryVariablesHeaderLabel.Text = "Entry Variables";
            this.EntryVariablesHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryNotes
            // 
            this.entryNotes.Dock = System.Windows.Forms.DockStyle.Right;
            this.entryNotes.Location = new System.Drawing.Point(368, 0);
            this.entryNotes.Name = "entryNotes";
            this.entryNotes.Size = new System.Drawing.Size(364, 276);
            this.entryNotes.TabIndex = 1;
            this.entryNotes.Text = "These are test notes";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 570);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MasterForm";
            this.Text = "PasswordKeeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MasterForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem passwordFileSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton OpenFileButton;
        private System.Windows.Forms.ToolStripButton SaveFilebutton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton NewEntryButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton CopyUsernameButton;
        private System.Windows.Forms.ToolStripButton CopyPassword;
        private System.Windows.Forms.ToolStripButton CopyButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton SearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton LockButton;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editGroupToolStripMenuItem;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settignsToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button AddNewEntry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox entryNotes;

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quickGuideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openingAFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addingEntriesToTheFielToolStripMenuItem;
        private System.Windows.Forms.Button EditRowButton;
        private System.Windows.Forms.Panel EntryVariablesPanel;
        private System.Windows.Forms.Label EntryVariablesHeaderLabel;
        private System.Windows.Forms.Label EntryVariablesTitleLabel;
        private System.Windows.Forms.Label EntryVariablesUsernameLabel;
        private System.Windows.Forms.Label EntryVariablesPasswordLabel;
        private System.Windows.Forms.Label EntryVariablesUrlLabel;
        private System.Windows.Forms.TextBox EntryVariablesTitleTextBox;
        private System.Windows.Forms.TextBox EntryVariablesPasswordTextBox;
        private System.Windows.Forms.TextBox EntryVariablesUsernameTextBox;
        private System.Windows.Forms.TextBox EntryVariablesUrlTextBox;
        private System.Windows.Forms.Button EntryVariablesConfirmButton;
    }
}

