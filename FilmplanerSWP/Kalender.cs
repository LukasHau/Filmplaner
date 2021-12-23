using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmplanerSWP
{
    public partial class Kalender : Form
    {
        int month, year;

        public static int static_month, static_year;
        public Kalender()
        {
            InitializeComponent();
        }

        private void Kalender_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_datum.Text = monthname + " " + year;

            static_month = month;
            static_year = year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            for(int i=1; i < dayoftheweek; i++)
            {
                BenutzerKontrolleLeer ucblank = new BenutzerKontrolleLeer();
                flp_daycontainer.Controls.Add(ucblank);
            }

            for(int i = 1; i<=days; i++)
            {
                BenutzerKontrolleTage ucdays = new BenutzerKontrolleTage();
                ucdays.days(i);
                flp_daycontainer.Controls.Add(ucdays);
            }
        }

        private void btn_Vorheriges_Click(object sender, EventArgs e)
        {
            flp_daycontainer.Controls.Clear();

            month--;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_datum.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < dayoftheweek; i++)
            {
                BenutzerKontrolleLeer ucblank = new BenutzerKontrolleLeer();
                flp_daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                BenutzerKontrolleTage ucdays = new BenutzerKontrolleTage();
                ucdays.days(i);
                flp_daycontainer.Controls.Add(ucdays);
            }
        }

        private void btn_Nächstes_Click(object sender, EventArgs e)
        {
            flp_daycontainer.Controls.Clear();

            month++;
            static_month = month;
            static_year = year;
            String monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbl_datum.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);

            int days = DateTime.DaysInMonth(year, month);

            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < dayoftheweek; i++)
            {
                BenutzerKontrolleLeer ucblank = new BenutzerKontrolleLeer();
                flp_daycontainer.Controls.Add(ucblank);
            }

            for (int i = 1; i <= days; i++)
            {
                BenutzerKontrolleTage ucdays = new BenutzerKontrolleTage();
                ucdays.days(i);
                flp_daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
