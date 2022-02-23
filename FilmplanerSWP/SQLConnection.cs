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


        #region VariablesForEquipmentLoad
        public static string EqipmentName;
        public static string EqipmentDescription;
        public static string EqipmentPrice;
        public static string EqipmentInstallation;
        public static string EqipmentState;
        public static string EqipmentWarranty;
        public static string EqipmentInfo;

        public static List<int> IDSelectEquipment = new List<int>();
        public static string NameSelectEquipment;
        public static string DescriptionEquipment;
        #endregion

        #region VaiablesForStaffLoad
        public static string StaffName;
        public static string StaffSurname;
        public static string StaffAge;
        public static string StaffAdress;
        public static string StaffStartingDate;
        public static string StaffJob;
        public static string StaffInfo;

        public static List<int> IDSelectStaff = new List<int>();
        public static string SurnameSelectStaff;
        public static string NameSelectStaff;
        #endregion

        #region VariablesForEventLoad
        public static string EventPlace;
        public static string EventTime;
        public static string EventeventName;
        public static string EventClient;
        public static string EventContactPerson;
        public static string EventDescription;
        #endregion

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

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp4_equipment') CREATE TABLE swp4_equipment ([Id] INT IDENTITY (1, 1) NOT NULL, [name] VARCHAR(50) NULL, [description] VARCHAR(50) NULL, [price] DECIMAL NULL, [installation] VARCHAR(50) NULL, [state] VARCHAR(50) NULL, [warranty] INT NULL, [info] VARCHAR(500) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp4_staff') CREATE TABLE swp4_staff ([Id] INT IDENTITY(1, 1) NOT NULL, [name] VARCHAR(50) NULL, [surname] VARCHAR(50) NULL, [age] VARCHAR(50) NULL, [adress] VARCHAR(500) NULL, [starting_date] VARCHAR(50) NULL, [job] VARCHAR(50) NULL, [info] VARCHAR(500) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp4_event') CREATE TABLE swp4_event ([Id] INT IDENTITY(1, 1) NOT NULL, [date] VARCHAR(50) NOT NULL, [place] VARCHAR(100) NULL, [time] VARCHAR(50) NULL, [eventName] VARCHAR(50) NULL, [client] VARCHAR(50) NULL, [contactPerson] VARCHAR(50) NULL, [description] VARCHAR(500) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
                cmd.ExecuteNonQuery();

                cmd.CommandText = ("IF NOT EXISTS (SELECT * FROM sys.tables WHERE [name] = 'swp4_staffInUse') CREATE TABLE swp4_staffInUse ([Id] INT IDENTITY(1, 1) NOT NULL, [staffID] INT NULL, [date] VARCHAR(50) NULL, PRIMARY KEY CLUSTERED([Id] ASC))");
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
                        cmd.CommandText = ("INSERT INTO swp4_login (username, password, role) VALUES ('" + username + "', '" + hashedpw + "', 'admin');");
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
                cmd.CommandText = ("SELECT name FROM swp4_equipment where ID = '" + ID + "';");
                EqipmentName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT description FROM swp4_equipment where ID = '" + ID + "';");
                EqipmentDescription = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT price FROM swp4_equipment where ID = '" + ID + "';");
                EqipmentPrice = Convert.ToString((decimal)cmd.ExecuteScalar());

                cmd.CommandText = ("SELECT installation FROM swp4_equipment where ID = '" + ID + "';");
                EqipmentInstallation = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT state FROM swp4_equipment where ID = '" + ID + "';");
                EqipmentState = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT warranty FROM swp4_equipment where ID = '" + ID + "';");
                EqipmentWarranty = Convert.ToString((int)cmd.ExecuteScalar());

                cmd.CommandText = ("SELECT info FROM swp4_equipment where ID = '" + ID + "';");
                EqipmentInfo = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch(Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());               
            }
        }

        public static void ChangeEqipment(string name, string description, decimal price, DateTime installation, string state, int warranty, string info, int ID)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(description) || price == 0 || String.IsNullOrEmpty(state))
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus!");
            }
            else
            {
                try
                {
                    con.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("UPDATE swp4_equipment set name = '" + name + "', description = '" + description + "', price = '" + price + "', installation = '" + installation.ToString() + "', state = '" + state + "', warranty = '" + warranty + "', info = '" + info + "' where ID = '" + ID + "';");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(name + " wurde bearbeitet!");
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void DeleteEqipment(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp4_equipment WHERE ID = '" + ID + "';");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(EqipmentName + " wurde gelöscht!");
            }
            catch (Exception e)
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

        public static void SelectEquipmentDescription(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT description FROM swp4_equipment where ID = '" + ID + "';");
                DescriptionEquipment = (string)cmd.ExecuteScalar();
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

        #region WORKERS
        public static void FillStaff(string name, string surname, DateTime age, string adress, DateTime startingDate, string job, string info)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(job))
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
                    cmd.CommandText = ("INSERT INTO swp4_staff(name, surname, age, adress, starting_date, job, info) VALUES('" + name + "', '" +
                        surname + "', '" + age.ToString() + "', '" + adress + "', '" + startingDate.ToString() + "', '" + job + "', '" + info + "');");
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

        public static void LoadStaff(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp4_staff where ID = '" + ID + "';");
                StaffName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT surname FROM swp4_staff where ID = '" + ID + "';");
                StaffSurname = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT age FROM swp4_staff where ID = '" + ID + "';");
                StaffAge = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT adress FROM swp4_staff where ID = '" + ID + "';");
                StaffAdress = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT starting_date FROM swp4_staff where ID = '" + ID + "';");
                StaffStartingDate = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT job FROM swp4_staff where ID = '" + ID + "';");
                StaffJob = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT info FROM swp4_staff where ID = '" + ID + "';");
                StaffInfo = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void ChangeStaff(string name, string surname, DateTime age, string adress, DateTime startingDate, string job, string info, int ID)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || String.IsNullOrEmpty(job))
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
                    cmd.CommandText = ("UPDATE swp4_staff set name = '" + name + "', surname = '" + surname + "', age = '" + age.ToString() + "', adress = '" + adress + "', starting_date = '" + startingDate.ToString() + "', info = '" + info + "' where ID = '" + ID + "';");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(name + " wurde bearbeitet!");
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void DeleteStaff(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("DELETE FROM swp4_staff WHERE ID = '" + ID + "';");
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(StaffName + " wurde gelöscht!");
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        #region GetStaffIndex

        public static List<int> SelectStaffID()
        {
            try
            {
                IDSelectStaff.Clear();
                con.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ID FROM swp4_staff";
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int temp = reader.GetInt32(0);
                        IDSelectStaff.Add(temp);
                    }
                }
                else
                {

                }
                con.Close();
                return IDSelectStaff;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return IDSelectStaff;
            }
        }

        public static void SelectStaffSurname(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT surname FROM swp4_staff where ID = '" + ID + "';");
                SurnameSelectStaff = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void SelectStaffName(int ID)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT name FROM swp4_staff where ID = '" + ID + "';");
                NameSelectStaff = (string)cmd.ExecuteScalar();
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

        #region EVENT

        public static bool CheckEvent(string date)
        {
            con.Open();
            cmd.CommandText = ("SELECT Id FROM swp4_event where date = '" + date + "';");
            string temp = Convert.ToString(cmd.ExecuteScalar());
            con.Close();

            if (String.IsNullOrEmpty(temp))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void CreateEvent(string date, string place, string time, string eventName, string client, string contactPerson, string description)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(place) || String.IsNullOrEmpty(time) || String.IsNullOrEmpty(eventName) || String.IsNullOrEmpty(client))
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
                    cmd.CommandText = ("INSERT INTO swp4_event(date, place, time, eventName, client, contactPerson, description) VALUES('" + date + "', '" + place + "', '" + time + "', '" + eventName + "', '" + client + "', '" + contactPerson + "', '" + description + "');");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    errormessage = false;
                    MessageBox.Show(eventName + " wurde hinzugefügt!");
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.ToString());
                }
            }
        }

        public static void LoadEvent(string date)
        {
            try
            {
                con.Open();
                cmd.CommandText = ("SELECT place FROM swp4_event where date = '" + date + "';");
                EventPlace = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT time FROM swp4_event where date = '" + date + "';");
                EventTime = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT eventName FROM swp4_event where date = '" + date + "';");
                EventeventName = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT client FROM swp4_event where date = '" + date + "';");
                EventClient = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT contactPerson FROM swp4_event where date = '" + date + "';");
                EventContactPerson = (string)cmd.ExecuteScalar();

                cmd.CommandText = ("SELECT description FROM swp4_event where date = '" + date + "';");
                EventDescription = (string)cmd.ExecuteScalar();
                con.Close();
            }
            catch (Exception e)
            {
                con.Close();
                MessageBox.Show(e.ToString());
            }
        }

        public static void ChangeEvent(string date, string place, string time, string eventName, string client, string contactPerson, string description)
        {
            //checks if all required data is filled
            if (String.IsNullOrEmpty(place) || String.IsNullOrEmpty(time) || String.IsNullOrEmpty(eventName) || String.IsNullOrEmpty(client))
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
                    cmd.CommandText = ("UPDATE swp4_event set place = '" + place + "', time = '" + time + "', eventName = '" + eventName + "', client = '" + client + "', contactPerson = '" + contactPerson + "', description = '" + description + "' where date = '" + date + "';");
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(eventName + " wurde bearbeitet!");
                }
                catch (Exception e)
                {
                    con.Close();
                    MessageBox.Show(e.ToString());
                }
            }
        }
        #endregion
    }
}
