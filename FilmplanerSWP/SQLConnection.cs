using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;

namespace FilmplanerSWP
{
    public class SQLConnection
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        public static DataTable dt = new DataTable();
        private static SqlDataAdapter adp = new SqlDataAdapter();
        public static bool errormessage;
        public static string choosen_username;


        #region Connection
        //sets the conncetion string
        public static void SetConnectionString(string userCon)
        {
            try
            {
                con.ConnectionString = userCon;
                cmd.Connection = con;
            }
            catch
            {
                errormessage = true;
            }
        }

        //Before the User connects to a Database, the program double checks the connection to the Database
        public static bool TryConnection()
        {
            try
            {
                con.Open();
                con.Close();
                return true;
            }

            catch (Exception e)
            {
                MessageBox.Show("Test at TryConnection\n"+e.Message);
                return false;
            }
        }

        public static void TryConnectTODB()
        {
            try
            {
                SetConnectionString("server = (localdb)\\MSSQLLocalDB; Integrated Security = true;");
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("if not exists(select * from sys.databases where name = 'swp4_FilmplanerDB') begin create database [swp4_FilmplanerDB] end");
                cmd.ExecuteNonQuery();
                con.Close();


                SetConnectionString("server=(localdb)\\MSSQLLocalDB; Integrated Security = true; Database = 'swp4_FilmplanerDB'");


                con.Open();
                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp4_login') CREATE TABLE swp4_login ([Id] INT IDENTITY (1, 1) NOT NULL, [username] VARCHAR(50) NULL,[password] VARCHAR(200) NULL, [role] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();



                //cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp3_protocol') CREATE TABLE swp3_protocol ([Id] INT IDENTITY (1, 1) NOT NULL, [date] VARCHAR(50) NULL,[content] VARCHAR(1500) NULL, [loginID] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                //cmd.ExecuteNonQuery();



                //cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp3_vmaterial') CREATE TABLE swp3_vmaterial ([Id] INT IDENTITY(1, 1) NOT NULL, [date] DATETIME NULL, [vidpath] VARCHAR(50) NULL,[loginID] INT NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                //cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion


        public static bool CheckUsername(string chosen_username, string password)
        {
            //checks if the username and password are correct
            string hashedpw;

            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("SELECT password FROM swp4_login WHERE username = '" + chosen_username + "';");
                hashedpw = (string)cmd.ExecuteScalar();
                con.Close();

                if (hashedpw != null)
                {
                    if (BCrypt.CheckPassword(password, hashedpw))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Das Passwort ist falsch!");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Dieser Benutzername existiert nicht!");
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static void create_user(string username, string password)
        {
            string salt;
            string hashedpw;
            //creates a user and proofs if the username or password are empty
            try
            {
                if (username == "" || password == "")
                {
                    MessageBox.Show("Falsche Eingabe");
                }
                else
                {
                    con.Open();
                    cmd.CommandText = ("SELECT password FROM swp4_login WHERE username = '" + username + "';");
                    string temp = (string)cmd.ExecuteScalar();
                    con.Close();



                    if (temp == null)
                    {
                        salt = BCrypt.GenerateSalt();
                        hashedpw = BCrypt.HashPassword(password, salt);



                        con.Open();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = ("INSERT INTO swp4_login (username, password, role) VALUES ('" + username + "', '" + hashedpw + "', 'none');");
                        cmd.ExecuteNonQuery();
                        con.Close();



                        MessageBox.Show("Benutzer wurde erfolgreich erstellt!");
                    }
                    else
                    {
                        MessageBox.Show("Der Benutzername wird bereits verwendet!");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static string checkRole(string username)
        {
            //Checks the Role from a user
            string userRole;

            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("SELECT role FROM swp4_login WHERE username = '" + username + "';");
            userRole = (string)cmd.ExecuteScalar();
            con.Close();

            return userRole;
        }
    }
}
