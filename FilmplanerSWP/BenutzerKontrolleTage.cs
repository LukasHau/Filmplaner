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
    public partial class BenutzerKontrolleTage : UserControl
    {
        //String connString = "server=localhost; user id=root; database=db_calendar;sslmode=none";
        public static string static_day;
        public BenutzerKontrolleTage()
        {
            InitializeComponent();
        }

        private void BenutzerKontrolleTage_Load(object sender, EventArgs e)
        {
          
        }

        public void days(int numday)
        {
            lbl_days.Text = numday + "";
        }

        private void BenutzerKontrolleTage_Click(object sender, EventArgs e)
        {
            static_day = lbl_days.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        private void displayEvent()
        {
            //SQLConnection conn = new SQLConnection(connString);
            //conn.Open();
            //String sql = "SELECT * FROM  tbl_calendar where date = ?";
            //SQLConnection cmd = conn.CreateCommand();
            //cmd.CommandText = sql;
            //cmd.Parameters.AddWithValue("date", lbl_days.Text+"/" + Kalender.static_month + "/" + Kalender.static_year);
            //SqlDatareader reader = cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    lbl_event.Text = reader["event"].ToString();
            //}
            //reader.Dispose();
            //cmd.Dispose();
            //conn.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            displayEvent();
        }

        private void lbl_event_Click(object sender, EventArgs e)
        {
            static_day = lbl_days.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }

        private void lbl_days_Click(object sender, EventArgs e)
        {
            static_day = lbl_days.Text;
            timer1.Start();
            EventForm eventform = new EventForm();
            eventform.Show();
        }
    }
}
