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
using MetroFramework.Forms;

namespace BPGroupEditor
{
    public partial class AddPlayer : MetroForm
    {
        BPGroupsEditor bpge;
        public AddPlayer(BPGroupsEditor groupeditor)
        {
            InitializeComponent();
            bpge = groupeditor;
        }

        private void AddPlayer_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (metroTextBox1.Text != null)
            {
                foreach (var group in Variables.gr)
                {
                    if (bpge.groupNameTitle.Text == group.Name)
                    {
                        if (!group.Members.Contains(metroTextBox1.Text))
                        {
                            group.Members.Add(metroTextBox1.Text);
                            bpge.membersBox.Items.Add(metroTextBox1.Text, true);
                            MetroMessageBox.Show(this, "Member Added Successfully!");
                            Close();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Error: Member already exists in " + group.Name);
                        }
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Error: Invalid Member Value Entered");
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
