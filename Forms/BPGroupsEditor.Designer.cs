namespace BPGroupEditor
{
    partial class BPGroupsEditor
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.GroupEditorTab = new MetroFramework.Controls.MetroTabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.template = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.permissionsBox = new System.Windows.Forms.CheckedListBox();
            this.membersBox = new System.Windows.Forms.CheckedListBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.inheritListBox = new System.Windows.Forms.CheckedListBox();
            this.groupNameTitle = new MetroFramework.Controls.MetroLabel();
            this.previewTag = new MetroFramework.Controls.MetroLabel();
            this.tagGroup = new MetroFramework.Controls.MetroLabel();
            this.groupType = new MetroFramework.Controls.MetroLabel();
            this.InheritPerms = new MetroFramework.Controls.MetroLabel();
            this.permissions = new MetroFramework.Controls.MetroLabel();
            this.tagPreview = new MetroFramework.Drawing.Html.HtmlLabel();
            this.member = new MetroFramework.Controls.MetroLabel();
            this.typeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.GroupTag = new System.Windows.Forms.TextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.GroupEditorTab.SuspendLayout();
            this.home.SuspendLayout();
            this.panel1.SuspendLayout();
            this.template.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(950, 573);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(143, 31);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Save Changes";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // GroupEditorTab
            // 
            this.GroupEditorTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.GroupEditorTab.Controls.Add(this.home);
            this.GroupEditorTab.Controls.Add(this.template);
            this.GroupEditorTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupEditorTab.Location = new System.Drawing.Point(20, 60);
            this.GroupEditorTab.Name = "GroupEditorTab";
            this.GroupEditorTab.SelectedIndex = 1;
            this.GroupEditorTab.Size = new System.Drawing.Size(1090, 507);
            this.GroupEditorTab.Style = MetroFramework.MetroColorStyle.Teal;
            this.GroupEditorTab.TabIndex = 0;
            this.GroupEditorTab.Theme = MetroFramework.MetroThemeStyle.Light;
            this.GroupEditorTab.UseSelectable = true;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.SystemColors.Control;
            this.home.Controls.Add(this.panel1);
            this.home.Location = new System.Drawing.Point(4, 41);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(1082, 462);
            this.home.TabIndex = 0;
            this.home.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 462);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Unable to load";
            // 
            // template
            // 
            this.template.BackColor = System.Drawing.SystemColors.Control;
            this.template.Controls.Add(this.panel2);
            this.template.Location = new System.Drawing.Point(4, 41);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(1082, 462);
            this.template.TabIndex = 1;
            this.template.Text = "Template";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.permissionsBox);
            this.panel2.Controls.Add(this.membersBox);
            this.panel2.Controls.Add(this.metroButton4);
            this.panel2.Controls.Add(this.metroButton3);
            this.panel2.Controls.Add(this.inheritListBox);
            this.panel2.Controls.Add(this.groupNameTitle);
            this.panel2.Controls.Add(this.previewTag);
            this.panel2.Controls.Add(this.tagGroup);
            this.panel2.Controls.Add(this.groupType);
            this.panel2.Controls.Add(this.InheritPerms);
            this.panel2.Controls.Add(this.permissions);
            this.panel2.Controls.Add(this.tagPreview);
            this.panel2.Controls.Add(this.member);
            this.panel2.Controls.Add(this.typeComboBox);
            this.panel2.Controls.Add(this.GroupTag);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1076, 459);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // permissionsBox
            // 
            this.permissionsBox.FormattingEnabled = true;
            this.permissionsBox.Location = new System.Drawing.Point(226, 59);
            this.permissionsBox.Name = "permissionsBox";
            this.permissionsBox.Size = new System.Drawing.Size(182, 304);
            this.permissionsBox.TabIndex = 5;
            this.permissionsBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.permissionsBox_ItemCheck);
            // 
            // membersBox
            // 
            this.membersBox.FormattingEnabled = true;
            this.membersBox.Location = new System.Drawing.Point(17, 60);
            this.membersBox.Name = "membersBox";
            this.membersBox.Size = new System.Drawing.Size(182, 304);
            this.membersBox.TabIndex = 2;
            this.membersBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.membersBox_ItemCheck);
            // 
            // metroButton4
            // 
            this.metroButton4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroButton4.Location = new System.Drawing.Point(226, 370);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(93, 23);
            this.metroButton4.TabIndex = 6;
            this.metroButton4.Text = "Add Permission";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(17, 370);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(89, 23);
            this.metroButton3.TabIndex = 3;
            this.metroButton3.Text = "Add Member";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // inheritListBox
            // 
            this.inheritListBox.FormattingEnabled = true;
            this.inheritListBox.Items.AddRange(new object[] {
            "Test"});
            this.inheritListBox.Location = new System.Drawing.Point(447, 60);
            this.inheritListBox.Name = "inheritListBox";
            this.inheritListBox.Size = new System.Drawing.Size(160, 304);
            this.inheritListBox.TabIndex = 8;
            this.inheritListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.inheritListBox_ItemCheck);
            this.inheritListBox.SelectedIndexChanged += new System.EventHandler(this.inheritListBox_SelectedIndexChanged);
            // 
            // groupNameTitle
            // 
            this.groupNameTitle.AutoSize = true;
            this.groupNameTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.groupNameTitle.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.groupNameTitle.Location = new System.Drawing.Point(7, 0);
            this.groupNameTitle.Name = "groupNameTitle";
            this.groupNameTitle.Size = new System.Drawing.Size(120, 25);
            this.groupNameTitle.TabIndex = 1;
            this.groupNameTitle.Text = "Group Name";
            // 
            // previewTag
            // 
            this.previewTag.AutoSize = true;
            this.previewTag.Location = new System.Drawing.Point(779, 88);
            this.previewTag.Name = "previewTag";
            this.previewTag.Size = new System.Drawing.Size(78, 19);
            this.previewTag.TabIndex = 13;
            this.previewTag.Text = "Tag Preview";
            // 
            // tagGroup
            // 
            this.tagGroup.AutoSize = true;
            this.tagGroup.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tagGroup.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.tagGroup.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.tagGroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tagGroup.Location = new System.Drawing.Point(779, 32);
            this.tagGroup.Name = "tagGroup";
            this.tagGroup.Size = new System.Drawing.Size(39, 25);
            this.tagGroup.TabIndex = 11;
            this.tagGroup.Text = "Tag";
            this.tagGroup.UseCustomBackColor = true;
            this.tagGroup.UseCustomForeColor = true;
            // 
            // groupType
            // 
            this.groupType.AutoSize = true;
            this.groupType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupType.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.groupType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.groupType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupType.Location = new System.Drawing.Point(630, 31);
            this.groupType.Name = "groupType";
            this.groupType.Size = new System.Drawing.Size(121, 25);
            this.groupType.TabIndex = 9;
            this.groupType.Text = "Member Type";
            this.groupType.UseCustomBackColor = true;
            this.groupType.UseCustomForeColor = true;
            // 
            // InheritPerms
            // 
            this.InheritPerms.AutoSize = true;
            this.InheritPerms.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InheritPerms.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.InheritPerms.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.InheritPerms.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InheritPerms.Location = new System.Drawing.Point(447, 32);
            this.InheritPerms.Name = "InheritPerms";
            this.InheritPerms.Size = new System.Drawing.Size(160, 25);
            this.InheritPerms.TabIndex = 7;
            this.InheritPerms.Text = "InheritGroupPerms";
            this.InheritPerms.UseCustomBackColor = true;
            this.InheritPerms.UseCustomForeColor = true;
            // 
            // permissions
            // 
            this.permissions.AutoSize = true;
            this.permissions.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.permissions.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.permissions.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.permissions.ForeColor = System.Drawing.SystemColors.ControlText;
            this.permissions.Location = new System.Drawing.Point(226, 31);
            this.permissions.Name = "permissions";
            this.permissions.Size = new System.Drawing.Size(105, 25);
            this.permissions.TabIndex = 4;
            this.permissions.Text = "Permissions";
            this.permissions.UseCustomBackColor = true;
            this.permissions.UseCustomForeColor = true;
            // 
            // tagPreview
            // 
            this.tagPreview.AutoScroll = true;
            this.tagPreview.AutoScrollMinSize = new System.Drawing.Size(49, 23);
            this.tagPreview.AutoSize = false;
            this.tagPreview.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tagPreview.Location = new System.Drawing.Point(779, 110);
            this.tagPreview.Name = "tagPreview";
            this.tagPreview.Size = new System.Drawing.Size(287, 82);
            this.tagPreview.TabIndex = 14;
            this.tagPreview.Text = "preview";
            // 
            // member
            // 
            this.member.AutoSize = true;
            this.member.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.member.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.member.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.member.ForeColor = System.Drawing.SystemColors.ControlText;
            this.member.Location = new System.Drawing.Point(7, 31);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(87, 25);
            this.member.TabIndex = 2;
            this.member.Text = "Members";
            this.member.UseCustomBackColor = true;
            this.member.UseCustomForeColor = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.ItemHeight = 23;
            this.typeComboBox.Items.AddRange(new object[] {
            "AccountID",
            "ConnectionIP",
            "JobIndex",
            "JobName",
            "JobGroupIndex",
            "ScriptableTrigger"});
            this.typeComboBox.Location = new System.Drawing.Point(630, 59);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(124, 29);
            this.typeComboBox.TabIndex = 10;
            this.typeComboBox.UseSelectable = true;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            this.typeComboBox.SelectedValueChanged += new System.EventHandler(this.typeComboBox_SelectedValueChanged);
            // 
            // GroupTag
            // 
            this.GroupTag.Location = new System.Drawing.Point(779, 59);
            this.GroupTag.Name = "GroupTag";
            this.GroupTag.Size = new System.Drawing.Size(287, 20);
            this.GroupTag.TabIndex = 12;
            this.GroupTag.TextChanged += new System.EventHandler(this.GroupTag_TextChanged);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(752, 573);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(143, 31);
            this.metroButton2.TabIndex = 16;
            this.metroButton2.Text = "Undo Changes";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Visible = false;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(24, 569);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(143, 31);
            this.metroButton5.TabIndex = 17;
            this.metroButton5.Text = "Create Group";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(789, 573);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(143, 31);
            this.metroButton6.TabIndex = 18;
            this.metroButton6.Text = "Reload Groups";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(321, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(215, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Created by CoffeeTime for BPv1.05";
            // 
            // BPGroupsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 619);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton6);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.GroupEditorTab);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "BPGroupsEditor";
            this.Resizable = false;
            this.Text = "Broke Protocol Groups Editor";
            this.GroupEditorTab.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.template.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage template;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox typeComboBox;
        private MetroFramework.Controls.MetroLabel permissions;
        private MetroFramework.Drawing.Html.HtmlLabel tagPreview;
        private MetroFramework.Controls.MetroLabel member;
        private MetroFramework.Controls.MetroLabel InheritPerms;
        private MetroFramework.Controls.MetroLabel groupType;
        private MetroFramework.Controls.MetroLabel tagGroup;
        private MetroFramework.Controls.MetroLabel previewTag;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.TextBox GroupTag;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.CheckedListBox inheritListBox;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        public System.Windows.Forms.CheckedListBox membersBox;
        public System.Windows.Forms.CheckedListBox permissionsBox;
        public MetroFramework.Controls.MetroLabel groupNameTitle;
        private MetroFramework.Controls.MetroButton metroButton5;
        public MetroFramework.Controls.MetroTabControl GroupEditorTab;
        private MetroFramework.Controls.MetroButton metroButton6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}

