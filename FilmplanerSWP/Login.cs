using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmplanerSWP
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        public static string userrole;

        private void pB_Login_Click(object sender, EventArgs e)
        {
            string username = tB_login_name.Text;
            string password = tB_login_password.Text;

            userrole = SQLConnection.checkRole(username);

            //Checks if the username and the password are correct
            if (SQLConnection.CheckUsername(username, password))
            {
                SQLConnection.choosen_username = username;

                Main temp = new Main();
                this.Hide();
                temp.Show();
            }
        
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQLConnection.TryConnectTODB();

            tB_login_password.PasswordChar = '*';
        }


        private void cB_passwordChar_CheckedChanged(object sender, EventArgs e)
        {
            //shows the user his password before pressing any button
            if (cB_passwordChar.Checked)
            {
                tB_login_password.PasswordChar = '\0';
            }
            else
            {
                tB_login_password.PasswordChar = '*';
            }
        }

        private void pB_addUser_Click(object sender, EventArgs e)
        {
            string username = tB_login_name.Text;
            string password = tB_login_password.Text;

            SQLConnection.create_user(username, password);
        }
    }
}
