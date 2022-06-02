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

            tB_login_password.Text = string.Empty;

        }

        private void Login_Load(object sender, EventArgs e)
        {
            SQLConnection.TryConnectTODB();
            //hides the Password
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
            Regestrieren temp = new Regestrieren();
            //this.Hide();

            temp.Show();
        }

        private void tB_login_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

                tB_login_password.Text = "";

                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void tB_login_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
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

                tB_login_password.Text = "";

                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tB_login_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
