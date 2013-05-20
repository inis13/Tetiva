using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
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
            string connect =@"Data Source=161.53.120.217\VARAZDIN,1433;Initial Catalog=pi2013tetivadb;User ID=pi2013tetiva;Password=pi2013tetiva";
            SqlConnection connection = new SqlConnection(connect);
            try{
                connection.Open();
                MessageBox.Show("uspjeh");
            }
            catch{
                MessageBox.Show("neuspjeh");
            }

            string userText = txtUsername.Text;
            string passText = txtPassword.Text;

            SqlCommand cmd = new SqlCommand("SELECT Ime,Sifra FROM Zaposlenici WHERE Ime='" + txtUsername.Text + "' and Sifra='" + txtPassword.Text + "'",connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                new glavna().Show();
                this.Hide();
              
                connection.Close();
            }
            else
            {
                MessageBox.Show("Access Denied!!");
                connection.Close();
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
