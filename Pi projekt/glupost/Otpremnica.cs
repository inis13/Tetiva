using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public partial class Otpremnica : Form
    {
        public Otpremnica()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new glupost.glavna().Show();
            this.Hide();
        }

        private void toolStripContainer2_ContentPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
