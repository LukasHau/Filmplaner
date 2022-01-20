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
    public partial class EventForm : Form
    {

        //String connString = "server=localhost;user id=root;database=db_xalendar;sslmode=none";
        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            txtb_date.Text =BenutzerKontrolleTage.static_day + "/" + Kalender.static_month + "/" + Kalender.static_year;
        }

        private void btn_save_Click(object sender, EventArgs e) //work in progress sql connection
        {
            //MySqlConnection conn = new MySqlconnection(connString);
            //conn.Open();
            //String sql =  "INSERT INTO tbl_calendar(date,event)value(?,?)";
            //MySqlCommand cmd = conn.CreateCommand();
            //cmd.CommandText = sql;
            //cmd.Parameters.AddWithValue("date",txdate.Text);
            //cmd.Parameters.AddWithValue("event",txdate.Text);
            //cmd.ExecuteNonQuery();
            MessageBox.Show("saved");
            //cmd.Dispose();
            //conn.Close();


        }

        private void btn_back_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
