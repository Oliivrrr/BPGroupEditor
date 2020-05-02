using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Drawing.Html;
using MetroFramework.Forms;

namespace BPGroupEditor
{
    public partial class BPGroupsEditor : MetroForm
    {
        public BPGroupsEditor()
        {
            InitializeComponent();
            if (File.Exists("groups.json"))
            {
                GroupEditorTab.TabPages.Remove(template);
                string groupsjsonraw = File.ReadAllText("groups.json");
                Variables.gr = JsonConvert.DeserializeObject<Group[]>(groupsjsonraw).ToList();
                string helpraw = File.ReadAllText("groups.json");
                string nuts = helpraw.Substring(helpraw.IndexOf(' '), helpraw.LastIndexOf('/') - 3);
                label1.Text = nuts + "\n";

                LoadGroups();
            }
            else
            {
                MetroMessageBox.Show(this,
                    "Could not locate \"groups.json\" file. Make sure you are running this application in your \"BROKE PROTOCOL\" Folder");
                Close();
            }
        }

        public void LoadGroups()
        {
            for (int i = 1; i < GroupEditorTab.TabPages.Count;)
            {
                GroupEditorTab.TabPages.RemoveAt(i);
            }
            foreach (var group in Variables.gr)
            {
                MetroTabPage tpg = new MetroTabPage();
                tpg.Text = group.Name;
                tpg.Name = group.Name + "Tab";
                tpg.Enter += Tpg_Enter;
                GroupEditorTab.TabPages.Add(tpg);
            }
        }

        public void Tpg_Enter(object sender, EventArgs e)
        {
            Variables.recentMemberList.Clear();
            Variables.recentPermList.Clear();
            Variables.recentInheritList.Clear();

            var tabPage = (MetroTabPage)sender;
            Variables.activeTab = tabPage;

            tabPage.Location = new Point(4, 22);
            tabPage.Padding = new Padding(3);
            tabPage.Size = new Size(777, 403);
            tabPage.UseVisualStyleBackColor = true;

            tabPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPage.Controls.Add(tagGroup);
            tabPage.Controls.Add(GroupTag);
            tabPage.Controls.Add(groupNameTitle);
            tabPage.Controls.Add(groupType);
            tabPage.Controls.Add(InheritPerms);
            tabPage.Controls.Add(membersBox);
            tabPage.Controls.Add(permissionsBox);
            tabPage.Controls.Add(member);
            tabPage.Controls.Add(permissions);
            tabPage.Controls.Add(typeComboBox);
            tabPage.Controls.Add(previewTag);
            tabPage.Controls.Add(tagPreview);
            tabPage.Controls.Add(inheritListBox);
            tabPage.Controls.Add(metroButton4);
            tabPage.Controls.Add(metroButton3);
            tabPage.Location = new Point(0, 0);
            tabPage.Size = new Size(771, 403);
            tabPage.TabIndex = 1;
            inheritListBox.Items.Clear();
            membersBox.Items.Clear();
            permissionsBox.Items.Clear();

            Variables.activeGroup = Variables.gr[GroupEditorTab.TabPages.IndexOf(tabPage) - 1];
            
            foreach (var perm in Variables.activeGroup.Permissions)
            {
                permissionsBox.Items.Add(perm, true);
            }

            foreach (var inperm in Variables.activeGroup.Inherits)
            {
                inheritListBox.Items.Add(inperm, true);
            }

            foreach (var member in Variables.activeGroup.Members)
            {
                membersBox.Items.Add(member, true);
            }

            GroupTag.Text = Variables.activeGroup.Tag;
            foreach (var item in typeComboBox.Items)
            {
                if (item.ToString() == Variables.activeGroup.Type.ToString())
                    typeComboBox.SelectedItem = item;
            }

            foreach (var grp in Variables.gr)
            {
                if (!inheritListBox.Items.Contains(grp.Name) && grp != Variables.activeGroup)
                {
                    inheritListBox.Items.Add(grp.Name, false);
                    Variables.recentInheritList.Add(grp.Name);
                }
            }
                    
            groupNameTitle.Text = Variables.activeGroup.Name;
            tagPreview.Text = Variables.activeGroup.Tag;

            foreach (var colorCode in Colors.ColorList)
            {
                string lpl = tagPreview.Text.Replace($"&{colorCode.Key}", $"<color={colorCode.Value}>");
                tagPreview.Text = lpl;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            File.WriteAllText("groups.json", $"/*{label1.Text}*/\n" + JsonConvert.SerializeObject(Variables.gr, Formatting.Indented));
            MetroMessageBox.Show(this,"Successfully saved changes!");
        }

        private void GroupTag_TextChanged(object sender, EventArgs e)
        {
            var tagsender = (TextBox)sender;
            Variables.activeGroup.Tag = GroupTag.Text;
            tagPreview.Text = GroupTag.Text;
            foreach (var colorCode in Colors.ColorList)
            {
                string lpl = tagPreview.Text.Replace($"&{colorCode.Key}", $"<color={colorCode.Value}>") + "</color>";
                tagPreview.Text = lpl;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            AddPlayer addPlayer = new AddPlayer(this);
            addPlayer.ShowDialog();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            ConfirmationBox cmf = new ConfirmationBox(this, "Are you sure you want to undo? All Unsaved progress will be lost.");
            cmf.ShowDialog(this);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            AddPermission addPermission = new AddPermission(this);
            addPermission.ShowDialog();
        }

        private void membersBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var snd = (CheckedListBox)sender;
            foreach (var group in Variables.gr)
            {
                if (e.NewValue != e.CurrentValue && groupNameTitle.Text == group.Name)
                {
                    if (e.NewValue == CheckState.Unchecked)
                    {
                        string name = snd.Items[e.Index].ToString();
                        group.Members.Remove(name);
                        Variables.recentMemberList.Add(name);
                    }

                    if (e.NewValue == CheckState.Checked && Variables.recentMemberList.Contains(snd.Items[e.Index].ToString()))
                    {
                        string name = snd.Items[e.Index].ToString();
                        group.Members.Add(name);
                        Variables.recentMemberList.Remove(name);
                    }
                }
            }
        }

        private void permissionsBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var snd = (CheckedListBox)sender;
            foreach (var group in Variables.gr)
            {
                if (e.NewValue != e.CurrentValue && groupNameTitle.Text == group.Name)
                {
                    if (e.NewValue == CheckState.Unchecked)
                    {
                        string name = snd.Items[e.Index].ToString();
                        group.Permissions.Remove(name);
                        Variables.recentPermList.Add(name);
                    }

                    if (e.NewValue == CheckState.Checked && Variables.recentPermList.Contains(snd.Items[e.Index].ToString()))
                    {
                        string name = snd.Items[e.Index].ToString();
                        group.Permissions.Add(name);
                        Variables.recentPermList.Remove(name);
                    }
                }
            }
        }

        private void inheritListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inheritListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var snd = (CheckedListBox)sender;
            foreach (var group in Variables.gr)
            {
                if (e.NewValue != e.CurrentValue && groupNameTitle.Text == group.Name)
                {
                    if (e.NewValue == CheckState.Unchecked)
                    {
                        string name = snd.Items[e.Index].ToString();
                        group.Inherits.Remove(name);
                        Console.WriteLine(name);
                        Variables.recentInheritList.Add(name);
                    }

                    if (e.NewValue == CheckState.Checked && Variables.recentInheritList.Contains(snd.Items[e.Index].ToString()))
                    {
                        string name = snd.Items[e.Index].ToString();
                        group.Inherits.Add(name);
                        Console.WriteLine(name);
                        Variables.recentInheritList.Remove(name);
                    }
                }
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            AddGroup addgrp = new AddGroup(this);
            addgrp.ShowDialog(this);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            if (File.Exists("groups.json"))
            {
                string groupsjsonraw = File.ReadAllText("groups.json");
                Variables.gr = JsonConvert.DeserializeObject<Group[]>(groupsjsonraw).ToList();
                string helpraw = File.ReadAllText("groups.json");
                string nuts = helpraw.Substring(helpraw.IndexOf(' '), helpraw.LastIndexOf('/') - 3);
                label1.Text = nuts + "\n";
                LoadGroups();
                MetroMessageBox.Show(this,"Successfully reloaded all Groups!");
            }
            else
            {
                MetroMessageBox.Show(this,
                    "Could not locate \"groups.json\" file. Make sure you are running this application in your \"BROKE PROTOCOL\" Folder.");
                Close();
            }
        }

        private void typeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sendr = (ComboBox)sender;
            Variables.activeGroup.Type = sendr.SelectedItem.ToString();
        }
    }
}
