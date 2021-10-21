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

        public static string GetConnectionString()
        {
            return con.ConnectionString;
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
                MessageBox.Show(e.Message);
                return false;
            }
        }
        #endregion

        public static void create_database()
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "CREATE database swp4_FilmplanerDB";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public static void create_table()
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "create table swp4_login (id int identity (1, 1) not null, username varchar(50) null, password varchar(200) null);";
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

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
                        return false;
                    }
                }
                else
                {
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
                    salt = BCrypt.GenerateSalt();
                    hashedpw = BCrypt.HashPassword(password, salt);

                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("INSERT INTO swp4_login (username, password) VALUES ('" + username + "', '" + hashedpw + "');");
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
