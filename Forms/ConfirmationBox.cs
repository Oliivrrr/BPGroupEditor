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
    public partial class ConfirmationBox : MetroForm
    {
        private BPGroupsEditor bpge;
        public ConfirmationBox(BPGroupsEditor bpsge, string message)
        {
            InitializeComponent();
            textBox1.Text = message;
            bpge = bpsge;
        }

        private void ConfirmationBox_Load(object sender, EventArgs e)
        {
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
