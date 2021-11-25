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
        public static SqlCommandBuilder CommandBuilder = new SqlCommandBuilder(adp);
        public static bool errormessage;
        public static string choosen_username;
        public static List<int> IDSelectEquipment = new List<int>();
        public static string NameSelectEquipment;
        public static string EqipmentLoad;


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



                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp4_equipment') CREATE TABLE swp4_equipment ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL, [description] VARCHAR(50) NULL, [price] DECIMAL NULL, [installation] DATETIME NULL, [state] VARCHAR(50) NULL, [warranty] INT NULL, [info] VARCHAR(500) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();



                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp4_staff') CREATE TABLE swp4_staff ([Id] INT IDENTITY(1, 1) NOT NULL, [name] VARCHAR(50) NULL, [surname] VARCHAR(50) NULL, [age] INT NULL, [adress] VARCHAR(50) NULL, [starting_date] DATE NULL, [job] VARCHAR(50) NULL, [info] VARCHAR(500) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        #endregion

        #region Login
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

        #endregion

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

        #region EQIPMENT
        public static void FillEquipment(string name, string description, decimal price, DateTime installation, string state, int warranty, string info)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description) || price == 0 || String.IsNullOrEmpty(state))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
                errormessage = true;
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("INSERT INTO swp4_equipment(name, description, price, installation, state, warranty, info) VALUES('" + name + "', '" +
                        description + "', '" + price + "', '" + installation.ToString() + "', '" + state + "', '" + warranty + "', '" + info + "');");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    errormessage = false;
                    MessageBox.Show(name + " wurde hinzugefügt!");
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void LoadEqipment(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT * FROM swp4_equipment where ID = '" + ID + "';");              
                EqipmentLoad = Convert.ToString(cmd.ExecuteScalar());
                con.Close();             
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());               
            }
        }

        #region GetEquipmentIndex

        public static List<int> SelectEquipmentID()
        {
            try
            {
                IDSelectEquipment.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID FROM swp4_equipment";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDSelectEquipment.Add(temp);
                    }
                }
                else
                {
                    
                }
                con.Close();
                return IDSelectEquipment;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDSelectEquipment;
            }
        }

        public static void SelectEquipmentName(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp4_equipment where ID = '" + ID + "';");
                NameSelectEquipment = (string)cmd.ExecuteScalar();
                con.Close();             
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }
        #endregion

        #endregion
    }
}
