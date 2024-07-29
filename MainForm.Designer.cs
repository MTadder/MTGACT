﻿namespace MTGAM;

partial class MainForm {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        this.TC_Main = new TabControl();
        this.TP_Config = new TabPage();
        this.B_Reload = new Button();
        this.B_SaveChanges = new Button();
        this.L_Script = new Label();
        this.L_Version = new Label();
        this.L_Author = new Label();
        this.L_Name = new Label();
        this.TB_Script = new TextBox();
        this.CB_ValidPath = new CheckBox();
        this.TB_PluginRoot = new TextBox();
        this.TB_Description = new TextBox();
        this.TB_Version = new TextBox();
        this.TB_Author = new TextBox();
        this.TB_Name = new TextBox();
        this.TP_Types = new TabPage();
        this.TP_Scenes = new TabPage();
        this.TP_Singletons = new TabPage();
        this.button2 = new Button();
        this.button1 = new Button();
        this.checkedListBox1 = new CheckedListBox();
        this.MS_Controls = new MenuStrip();
        this.TSMI_Addon = new ToolStripMenuItem();
        this.TSMI_New = new ToolStripMenuItem();
        this.TSMI_NewAddon = new ToolStripMenuItem();
        this.toolStripSeparator1 = new ToolStripSeparator();
        this.TSMI_NewSingleton = new ToolStripMenuItem();
        this.TSMI_NewType = new ToolStripMenuItem();
        this.TSS_0 = new ToolStripSeparator();
        this.TSMI_Save = new ToolStripMenuItem();
        this.TSMI_Load = new ToolStripMenuItem();
        this.TSS_1 = new ToolStripSeparator();
        this.TSMI_Package = new ToolStripMenuItem();
        this.TSMI_Sync = new ToolStripMenuItem();
        this.TSMI_StartSync = new ToolStripMenuItem();
        this.TSMI_StopSync = new ToolStripMenuItem();
        this.TSMI_Edit = new ToolStripMenuItem();
        this.TSMI_IncVer = new ToolStripMenuItem();
        this.majorToolStripMenuItem = new ToolStripMenuItem();
        this.minorToolStripMenuItem = new ToolStripMenuItem();
        this.revisionToolStripMenuItem = new ToolStripMenuItem();
        this.TSMI_DecVer = new ToolStripMenuItem();
        this.majorToolStripMenuItem1 = new ToolStripMenuItem();
        this.minorToolStripMenuItem1 = new ToolStripMenuItem();
        this.revisionToolStripMenuItem1 = new ToolStripMenuItem();
        this.TSS_2 = new ToolStripSeparator();
        this.TSMI_Tools = new ToolStripMenuItem();
        this.TSMI_Links = new ToolStripMenuItem();
        this.TSMI_GAL = new ToolStripMenuItem();
        this.TSMI_Exit = new ToolStripMenuItem();
        this.TC_Main.SuspendLayout();
        this.TP_Config.SuspendLayout();
        this.TP_Singletons.SuspendLayout();
        this.MS_Controls.SuspendLayout();
        this.SuspendLayout();
        // 
        // TC_Main
        // 
        this.TC_Main.Controls.Add(this.TP_Config);
        this.TC_Main.Controls.Add(this.TP_Types);
        this.TC_Main.Controls.Add(this.TP_Scenes);
        this.TC_Main.Controls.Add(this.TP_Singletons);
        this.TC_Main.Dock = DockStyle.Fill;
        this.TC_Main.Location = new Point(0, 24);
        this.TC_Main.Name = "TC_Main";
        this.TC_Main.SelectedIndex = 0;
        this.TC_Main.Size = new Size(384, 437);
        this.TC_Main.TabIndex = 0;
        // 
        // TP_Config
        // 
        this.TP_Config.Controls.Add(this.B_Reload);
        this.TP_Config.Controls.Add(this.B_SaveChanges);
        this.TP_Config.Controls.Add(this.L_Script);
        this.TP_Config.Controls.Add(this.L_Version);
        this.TP_Config.Controls.Add(this.L_Author);
        this.TP_Config.Controls.Add(this.L_Name);
        this.TP_Config.Controls.Add(this.TB_Script);
        this.TP_Config.Controls.Add(this.CB_ValidPath);
        this.TP_Config.Controls.Add(this.TB_PluginRoot);
        this.TP_Config.Controls.Add(this.TB_Description);
        this.TP_Config.Controls.Add(this.TB_Version);
        this.TP_Config.Controls.Add(this.TB_Author);
        this.TP_Config.Controls.Add(this.TB_Name);
        this.TP_Config.Location = new Point(4, 24);
        this.TP_Config.Name = "TP_Config";
        this.TP_Config.Padding = new Padding(3);
        this.TP_Config.Size = new Size(376, 409);
        this.TP_Config.TabIndex = 0;
        this.TP_Config.Text = "Configuration";
        this.TP_Config.UseVisualStyleBackColor = true;
        // 
        // B_Reload
        // 
        this.B_Reload.Enabled = false;
        this.B_Reload.Location = new Point(6, 210);
        this.B_Reload.Name = "B_Reload";
        this.B_Reload.Size = new Size(249, 23);
        this.B_Reload.TabIndex = 14;
        this.B_Reload.Text = "reload";
        this.B_Reload.UseVisualStyleBackColor = true;
        this.B_Reload.Click += this.B_Reload_Click;
        // 
        // B_SaveChanges
        // 
        this.B_SaveChanges.Enabled = false;
        this.B_SaveChanges.Location = new Point(261, 210);
        this.B_SaveChanges.Name = "B_SaveChanges";
        this.B_SaveChanges.Size = new Size(109, 23);
        this.B_SaveChanges.TabIndex = 13;
        this.B_SaveChanges.Text = "save changes";
        this.B_SaveChanges.UseVisualStyleBackColor = true;
        // 
        // L_Script
        // 
        this.L_Script.AutoSize = true;
        this.L_Script.Location = new Point(6, 184);
        this.L_Script.Name = "L_Script";
        this.L_Script.Size = new Size(36, 15);
        this.L_Script.TabIndex = 12;
        this.L_Script.Text = "script";
        // 
        // L_Version
        // 
        this.L_Version.AutoSize = true;
        this.L_Version.Location = new Point(6, 155);
        this.L_Version.Name = "L_Version";
        this.L_Version.Size = new Size(45, 15);
        this.L_Version.TabIndex = 11;
        this.L_Version.Text = "version";
        // 
        // L_Author
        // 
        this.L_Author.AutoSize = true;
        this.L_Author.Location = new Point(6, 126);
        this.L_Author.Name = "L_Author";
        this.L_Author.Size = new Size(42, 15);
        this.L_Author.TabIndex = 10;
        this.L_Author.Text = "author";
        // 
        // L_Name
        // 
        this.L_Name.AutoSize = true;
        this.L_Name.Location = new Point(6, 9);
        this.L_Name.Name = "L_Name";
        this.L_Name.Size = new Size(37, 15);
        this.L_Name.TabIndex = 9;
        this.L_Name.Text = "name";
        // 
        // TB_Script
        // 
        this.TB_Script.Location = new Point(54, 181);
        this.TB_Script.Name = "TB_Script";
        this.TB_Script.ReadOnly = true;
        this.TB_Script.Size = new Size(316, 23);
        this.TB_Script.TabIndex = 8;
        this.TB_Script.Click += this.TB_Script_Click;
        this.TB_Script.TextChanged += this.submitChange;
        // 
        // CB_ValidPath
        // 
        this.CB_ValidPath.AutoSize = true;
        this.CB_ValidPath.Enabled = false;
        this.CB_ValidPath.Location = new Point(314, 382);
        this.CB_ValidPath.Name = "CB_ValidPath";
        this.CB_ValidPath.Size = new Size(56, 19);
        this.CB_ValidPath.TabIndex = 7;
        this.CB_ValidPath.Text = "Valid?";
        this.CB_ValidPath.UseVisualStyleBackColor = true;
        // 
        // TB_PluginRoot
        // 
        this.TB_PluginRoot.Location = new Point(6, 380);
        this.TB_PluginRoot.Name = "TB_PluginRoot";
        this.TB_PluginRoot.ReadOnly = true;
        this.TB_PluginRoot.Size = new Size(302, 23);
        this.TB_PluginRoot.TabIndex = 6;
        this.TB_PluginRoot.Click += this.TB_PluginRoot_Click;
        // 
        // TB_Description
        // 
        this.TB_Description.Location = new Point(6, 35);
        this.TB_Description.Multiline = true;
        this.TB_Description.Name = "TB_Description";
        this.TB_Description.PlaceholderText = "description";
        this.TB_Description.Size = new Size(364, 82);
        this.TB_Description.TabIndex = 5;
        this.TB_Description.TextChanged += this.submitChange;
        // 
        // TB_Version
        // 
        this.TB_Version.Location = new Point(54, 152);
        this.TB_Version.Name = "TB_Version";
        this.TB_Version.Size = new Size(316, 23);
        this.TB_Version.TabIndex = 4;
        this.TB_Version.TextChanged += this.submitChange;
        // 
        // TB_Author
        // 
        this.TB_Author.Location = new Point(54, 123);
        this.TB_Author.Name = "TB_Author";
        this.TB_Author.Size = new Size(316, 23);
        this.TB_Author.TabIndex = 3;
        this.TB_Author.TextChanged += this.submitChange;
        // 
        // TB_Name
        // 
        this.TB_Name.Location = new Point(54, 6);
        this.TB_Name.Name = "TB_Name";
        this.TB_Name.Size = new Size(316, 23);
        this.TB_Name.TabIndex = 2;
        this.TB_Name.TextChanged += this.submitChange;
        // 
        // TP_Types
        // 
        this.TP_Types.Location = new Point(4, 24);
        this.TP_Types.Name = "TP_Types";
        this.TP_Types.Padding = new Padding(3);
        this.TP_Types.Size = new Size(376, 409);
        this.TP_Types.TabIndex = 1;
        this.TP_Types.Text = "Types";
        this.TP_Types.UseVisualStyleBackColor = true;
        // 
        // TP_Scenes
        // 
        this.TP_Scenes.Location = new Point(4, 24);
        this.TP_Scenes.Name = "TP_Scenes";
        this.TP_Scenes.Padding = new Padding(3);
        this.TP_Scenes.Size = new Size(376, 409);
        this.TP_Scenes.TabIndex = 2;
        this.TP_Scenes.Text = "Scenes";
        this.TP_Scenes.UseVisualStyleBackColor = true;
        // 
        // TP_Singletons
        // 
        this.TP_Singletons.Controls.Add(this.button2);
        this.TP_Singletons.Controls.Add(this.button1);
        this.TP_Singletons.Controls.Add(this.checkedListBox1);
        this.TP_Singletons.Location = new Point(4, 24);
        this.TP_Singletons.Name = "TP_Singletons";
        this.TP_Singletons.Padding = new Padding(3);
        this.TP_Singletons.Size = new Size(376, 409);
        this.TP_Singletons.TabIndex = 3;
        this.TP_Singletons.Text = "Singletons";
        this.TP_Singletons.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        this.button2.Location = new Point(293, 188);
        this.button2.Name = "button2";
        this.button2.Size = new Size(75, 23);
        this.button2.TabIndex = 3;
        this.button2.Text = "remove";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        this.button1.Location = new Point(8, 188);
        this.button1.Name = "button1";
        this.button1.Size = new Size(279, 23);
        this.button1.TabIndex = 2;
        this.button1.Text = "new Singleton";
        this.button1.UseVisualStyleBackColor = true;
        // 
        // checkedListBox1
        // 
        this.checkedListBox1.FormattingEnabled = true;
        this.checkedListBox1.Location = new Point(8, 217);
        this.checkedListBox1.Name = "checkedListBox1";
        this.checkedListBox1.Size = new Size(360, 184);
        this.checkedListBox1.TabIndex = 0;
        // 
        // MS_Controls
        // 
        this.MS_Controls.Items.AddRange(new ToolStripItem[] { this.TSMI_Addon, this.TSMI_Edit, this.TSMI_Tools, this.TSMI_Exit });
        this.MS_Controls.Location = new Point(0, 0);
        this.MS_Controls.Name = "MS_Controls";
        this.MS_Controls.Size = new Size(384, 24);
        this.MS_Controls.TabIndex = 1;
        this.MS_Controls.Text = "menuStrip1";
        // 
        // TSMI_Addon
        // 
        this.TSMI_Addon.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_New, this.TSS_0, this.TSMI_Save, this.TSMI_Load, this.TSS_1, this.TSMI_Package, this.TSMI_Sync });
        this.TSMI_Addon.Name = "TSMI_Addon";
        this.TSMI_Addon.Size = new Size(55, 20);
        this.TSMI_Addon.Text = "Addon";
        // 
        // TSMI_New
        // 
        this.TSMI_New.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_NewAddon, this.toolStripSeparator1, this.TSMI_NewSingleton, this.TSMI_NewType });
        this.TSMI_New.Name = "TSMI_New";
        this.TSMI_New.Size = new Size(138, 22);
        this.TSMI_New.Text = "New";
        // 
        // TSMI_NewAddon
        // 
        this.TSMI_NewAddon.Name = "TSMI_NewAddon";
        this.TSMI_NewAddon.Size = new Size(178, 22);
        this.TSMI_NewAddon.Text = "Addon";
        this.TSMI_NewAddon.Click += this.TSMI_NewAddon_Click;
        // 
        // toolStripSeparator1
        // 
        this.toolStripSeparator1.Name = "toolStripSeparator1";
        this.toolStripSeparator1.Size = new Size(175, 6);
        // 
        // TSMI_NewSingleton
        // 
        this.TSMI_NewSingleton.Name = "TSMI_NewSingleton";
        this.TSMI_NewSingleton.Size = new Size(178, 22);
        this.TSMI_NewSingleton.Text = "Singleton/Autoload";
        // 
        // TSMI_NewType
        // 
        this.TSMI_NewType.Name = "TSMI_NewType";
        this.TSMI_NewType.Size = new Size(178, 22);
        this.TSMI_NewType.Text = "Type/Class";
        // 
        // TSS_0
        // 
        this.TSS_0.Name = "TSS_0";
        this.TSS_0.Size = new Size(135, 6);
        // 
        // TSMI_Save
        // 
        this.TSMI_Save.Name = "TSMI_Save";
        this.TSMI_Save.Size = new Size(138, 22);
        this.TSMI_Save.Text = "Save";
        // 
        // TSMI_Load
        // 
        this.TSMI_Load.Name = "TSMI_Load";
        this.TSMI_Load.Size = new Size(138, 22);
        this.TSMI_Load.Text = "Load";
        this.TSMI_Load.Click += this.TSMI_Load_Click;
        // 
        // TSS_1
        // 
        this.TSS_1.Name = "TSS_1";
        this.TSS_1.Size = new Size(135, 6);
        // 
        // TSMI_Package
        // 
        this.TSMI_Package.Name = "TSMI_Package";
        this.TSMI_Package.Size = new Size(138, 22);
        this.TSMI_Package.Text = "Package";
        // 
        // TSMI_Sync
        // 
        this.TSMI_Sync.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_StartSync, this.TSMI_StopSync });
        this.TSMI_Sync.Name = "TSMI_Sync";
        this.TSMI_Sync.Size = new Size(138, 22);
        this.TSMI_Sync.Text = "Synchronize";
        // 
        // TSMI_StartSync
        // 
        this.TSMI_StartSync.Name = "TSMI_StartSync";
        this.TSMI_StartSync.Size = new Size(107, 22);
        this.TSMI_StartSync.Text = "Start...";
        this.TSMI_StartSync.Click += this.TSMI_StartSync_Click;
        // 
        // TSMI_StopSync
        // 
        this.TSMI_StopSync.Enabled = false;
        this.TSMI_StopSync.Name = "TSMI_StopSync";
        this.TSMI_StopSync.Size = new Size(107, 22);
        this.TSMI_StopSync.Text = "Stop";
        // 
        // TSMI_Edit
        // 
        this.TSMI_Edit.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_IncVer, this.TSMI_DecVer, this.TSS_2 });
        this.TSMI_Edit.Name = "TSMI_Edit";
        this.TSMI_Edit.Size = new Size(39, 20);
        this.TSMI_Edit.Text = "Edit";
        // 
        // TSMI_IncVer
        // 
        this.TSMI_IncVer.DropDownItems.AddRange(new ToolStripItem[] { this.majorToolStripMenuItem, this.minorToolStripMenuItem, this.revisionToolStripMenuItem });
        this.TSMI_IncVer.Name = "TSMI_IncVer";
        this.TSMI_IncVer.Size = new Size(173, 22);
        this.TSMI_IncVer.Text = "Increment Version";
        // 
        // majorToolStripMenuItem
        // 
        this.majorToolStripMenuItem.Name = "majorToolStripMenuItem";
        this.majorToolStripMenuItem.Size = new Size(118, 22);
        this.majorToolStripMenuItem.Text = "Major";
        // 
        // minorToolStripMenuItem
        // 
        this.minorToolStripMenuItem.Name = "minorToolStripMenuItem";
        this.minorToolStripMenuItem.Size = new Size(118, 22);
        this.minorToolStripMenuItem.Text = "Minor";
        // 
        // revisionToolStripMenuItem
        // 
        this.revisionToolStripMenuItem.Name = "revisionToolStripMenuItem";
        this.revisionToolStripMenuItem.Size = new Size(118, 22);
        this.revisionToolStripMenuItem.Text = "Revision";
        // 
        // TSMI_DecVer
        // 
        this.TSMI_DecVer.DropDownItems.AddRange(new ToolStripItem[] { this.majorToolStripMenuItem1, this.minorToolStripMenuItem1, this.revisionToolStripMenuItem1 });
        this.TSMI_DecVer.Name = "TSMI_DecVer";
        this.TSMI_DecVer.Size = new Size(173, 22);
        this.TSMI_DecVer.Text = "Decrement Version";
        // 
        // majorToolStripMenuItem1
        // 
        this.majorToolStripMenuItem1.Name = "majorToolStripMenuItem1";
        this.majorToolStripMenuItem1.Size = new Size(118, 22);
        this.majorToolStripMenuItem1.Text = "Major";
        // 
        // minorToolStripMenuItem1
        // 
        this.minorToolStripMenuItem1.Name = "minorToolStripMenuItem1";
        this.minorToolStripMenuItem1.Size = new Size(118, 22);
        this.minorToolStripMenuItem1.Text = "Minor";
        // 
        // revisionToolStripMenuItem1
        // 
        this.revisionToolStripMenuItem1.Name = "revisionToolStripMenuItem1";
        this.revisionToolStripMenuItem1.Size = new Size(118, 22);
        this.revisionToolStripMenuItem1.Text = "Revision";
        // 
        // TSS_2
        // 
        this.TSS_2.Name = "TSS_2";
        this.TSS_2.Size = new Size(170, 6);
        // 
        // TSMI_Tools
        // 
        this.TSMI_Tools.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_Links });
        this.TSMI_Tools.Name = "TSMI_Tools";
        this.TSMI_Tools.Size = new Size(46, 20);
        this.TSMI_Tools.Text = "Tools";
        // 
        // TSMI_Links
        // 
        this.TSMI_Links.DropDownItems.AddRange(new ToolStripItem[] { this.TSMI_GAL });
        this.TSMI_Links.Name = "TSMI_Links";
        this.TSMI_Links.Size = new Size(101, 22);
        this.TSMI_Links.Text = "Links";
        // 
        // TSMI_GAL
        // 
        this.TSMI_GAL.Name = "TSMI_GAL";
        this.TSMI_GAL.Size = new Size(177, 22);
        this.TSMI_GAL.Text = "Godot Asset Library";
        // 
        // TSMI_Exit
        // 
        this.TSMI_Exit.Name = "TSMI_Exit";
        this.TSMI_Exit.Size = new Size(38, 20);
        this.TSMI_Exit.Text = "Exit";
        this.TSMI_Exit.Click += this.TSMI_Exit_Click;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(384, 461);
        this.Controls.Add(this.TC_Main);
        this.Controls.Add(this.MS_Controls);
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.Icon = (Icon) resources.GetObject("$this.Icon");
        this.MaximumSize = new Size(400, 500);
        this.MinimumSize = new Size(400, 500);
        this.Name = "MainForm";
        this.Text = "MT's Godot Addon Manager";
        this.Load += this.MainForm_Load;
        this.TC_Main.ResumeLayout(false);
        this.TP_Config.ResumeLayout(false);
        this.TP_Config.PerformLayout();
        this.TP_Singletons.ResumeLayout(false);
        this.MS_Controls.ResumeLayout(false);
        this.MS_Controls.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private TabControl TC_Main;
    private TabPage TP_Config;
    private TabPage TP_Types;
    private MenuStrip MS_Controls;
    private ToolStripMenuItem TSMI_Addon;
    private ToolStripMenuItem TSMI_Edit;
    private ToolStripMenuItem TSMI_Tools;
    private TabPage TP_Scenes;
    private TabPage TP_Singletons;
    private ToolStripMenuItem TSMI_Exit;
    private Button button2;
    private Button button1;
    private CheckedListBox checkedListBox1;
    private TextBox TB_Version;
    private TextBox TB_Author;
    private TextBox TB_Name;
    private TextBox TB_Description;
    private ToolStripMenuItem TSMI_Save;
    private ToolStripMenuItem TSMI_Load;
    private ToolStripMenuItem TSMI_Package;
    private ToolStripMenuItem TSMI_Links;
    private ToolStripMenuItem TSMI_IncVer;
    private ToolStripMenuItem majorToolStripMenuItem;
    private ToolStripMenuItem minorToolStripMenuItem;
    private ToolStripMenuItem revisionToolStripMenuItem;
    private ToolStripMenuItem TSMI_DecVer;
    private ToolStripMenuItem majorToolStripMenuItem1;
    private ToolStripMenuItem minorToolStripMenuItem1;
    private ToolStripMenuItem revisionToolStripMenuItem1;
    private ToolStripSeparator TSS_2;
    private ToolStripSeparator TSS_1;
    private ToolStripMenuItem TSMI_GAL;
    private ToolStripMenuItem TSMI_Sync;
    private ToolStripMenuItem TSMI_StartSync;
    private ToolStripMenuItem TSMI_StopSync;
    private ToolStripMenuItem TSMI_New;
    private ToolStripSeparator TSS_0;
    private ToolStripMenuItem TSMI_NewAddon;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem TSMI_NewSingleton;
    private ToolStripMenuItem TSMI_NewType;
    private TextBox TB_PluginRoot;
    private CheckBox CB_ValidPath;
    private TextBox TB_Script;
    private Label L_Author;
    private Label L_Name;
    private Label L_Script;
    private Label L_Version;
    private Button B_Reload;
    private Button B_SaveChanges;
}
