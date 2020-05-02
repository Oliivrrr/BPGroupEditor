using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace BPGroupEditor
{
    public partial class AddGroup : MetroForm
    {
        BPGroupsEditor bpge;
        private bool addGroup = true;
        public AddGroup(BPGroupsEditor groupeditor)
        {
            InitializeComponent();
            bpge = groupeditor;
        }

        private void AddGroup_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                foreach (var group in Variables.gr)
                {
                    if (group.Name == textBox1.Text)
                    {
                        MetroMessageBox.Show(this, "Error: A Group with that Name already exists.");
                        addGroup = false;
                    }
                }

                if (addGroup)
                {
                    Console.WriteLine(Variables.gr.Count);
                    Group grp = new Group();
                    grp.Name = textBox1.Text;
                    grp.Tag = "";
                    grp.CustomData = new CustomData();
                    grp.Inherits = new List<string>();
                    grp.Permissions = new List<string>();
                    grp.Members = new List<string>();
                    grp.Type = typeComboBox.SelectedValue.ToString();
                    Variables.gr.Add(grp);
                    Console.WriteLine(Variables.gr.Count);
                    bpge.LoadGroups();
                    Console.WriteLine(Variables.gr.Count);
                    MetroMessageBox.Show(this, "Group Added Successfully!");
                    Close();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Error: Invalid Group Name Entered");
            }
        }
    }
}
