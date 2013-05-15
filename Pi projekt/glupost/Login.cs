using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace glupost
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
                if (txtUsername.Text == "user")
                {
                    if (txtPassword.Text == "11")
                    {
                       
                            new glavna().Show();
                            this.Hide();
                       
                    }
                    else
                    {
                        MessageBox.Show("krivi password");

                    }
                }
                else
                {
                    MessageBox.Show("krivi username");
                }
           
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
