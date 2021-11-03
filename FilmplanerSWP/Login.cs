﻿using System;
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


        private void tB_login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pB_Login_Click(object sender, EventArgs e)
        {
            string username = tB_login_name.Text;
            string password = tB_login_password.Text;

            //userrole = SQLConnection.checkRole(username);

            //Checks if the username and the password are correct
            if (!SQLConnection.CheckUsername(username, password))
            {
                MessageBox.Show("Falsche Anmeldedaten");
            }
            else
            {
                MessageBox.Show("Richtige Anmeldedaten");

                SQLConnection.choosen_username = username;

                Main temp = new Main();
                this.Hide();
                temp.Show();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //user connects to the local database
            try
            {
                SQLConnection.SetConnectionString("server=(localdb)\\MSSQLLocalDB; Integrated Security = true; Database = 'swp4_FilmplanerDB'");
                if (!SQLConnection.TryConnection())
                {
                    SQLConnection.SetConnectionString("server=(localdb)\\MSSQLLocalDB; Integrated Security = true;");
                    SQLConnection.create_database();

                    try
                    {
                        SQLConnection.SetConnectionString("server=(localdb)\\MSSQLLocalDB; Integrated Security = true; Database = 'swp4_FilmplanerDB'");
                        if (SQLConnection.TryConnection())
                        {
                            SQLConnection.create_table();

                            MessageBox.Show("Datenbank und Tabelle wurden erstellt!");
                        }
                        else
                        {
                            MessageBox.Show("Tabelle konnte nicht erstellt werden.");
                        }
                    }
                    catch (Exception ex)

                    {
                        MessageBox.Show("Datenbank konnte nicht erstellt werden.\n" + ex.Message);
                    }
                }
                //The password gets defaced
                tB_login_password.PasswordChar = '*';
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
