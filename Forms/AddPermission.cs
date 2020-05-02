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
    public partial class AddPermission : MetroForm
    {
        BPGroupsEditor bpge;
        public AddPermission(BPGroupsEditor groupeditor)
        {
            InitializeComponent();
            bpge = groupeditor;
        }

        private void AddPermission_Load(object sender, EventArgs e)
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
                        if (!group.Permissions.Contains(metroTextBox1.Text))
                        {
                            group.Permissions.Add(metroTextBox1.Text);
                            bpge.permissionsBox.Items.Add(metroTextBox1.Text, true);
                            MetroMessageBox.Show(this, "Permission Added Successfully!");
                            Close();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Error: Permission already exists in " + group.Name);
                        }
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Error: Invalid Permission Entered");
            }
        }
    }
}
