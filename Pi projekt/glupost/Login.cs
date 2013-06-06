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


            {   
                string sqlUpit = ("SELECT Ime,Sifra FROM Zaposlenici WHERE Ime='" + txtUsername.Text + "' and Sifra='" + txtPassword.Text + "'");

                SqlDataReader re = PI.Spajanje.Instance.DohvatiDataReader(sqlUpit);
           
                //ako je pronađen upit izvrsi if
                if (re.Read())
                {
                    //spremanje imena u klasu userinformation koja je public da mogu druge forme citat
                    UserInformation.CurrentLoggedInUser = (string)re["Ime"];
                    new glavna().Show();
                    this.Hide();
                    MessageBox.Show("Welcome " + UserInformation.CurrentLoggedInUser);
                }
                else
                    MessageBox.Show("inavlid username and password");
                re.Close();
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
//klasa da mogu u svim formama procitat ime korisnika
internal class UserInformation
{
    public static string CurrentLoggedInUser
    {
        get;
        set;
    }
}