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
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_Nächstes.FlatStyle = FlatStyle.Flat;
            btn_Nächstes.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_Vorheriges.FlatStyle = FlatStyle.Flat;
            btn_Vorheriges.FlatAppearance.BorderColor = Color.CornflowerBlue;


            displayDays();
        }
        
       
        private void displayDays() //shows the single days of the month and adds it to the canvas, it gets the information for the boxes form "BenuterKontrolleLeer" and "BenutzerKontrolleTag"
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


            for(int i=1; i < dayoftheweek; i++) //adds the blank canvace for the days
            {
                BenutzerKontrolleLeer ucblank = new BenutzerKontrolleLeer();
                flp_daycontainer.Controls.Add(ucblank);
            }

            for(int i = 1; i<=days; i++) //adds the days 
            {
                BenutzerKontrolleTage ucdays = new BenutzerKontrolleTage();
                ucdays.days(i);
                if (i == now.Day && month == now.Month && year == now.Year)
                {
                    ucdays.BackColor = Color.FromArgb(25, Color.Green);
                }
                flp_daycontainer.Controls.Add(ucdays);
                

            }


        }

        private void btn_back_Click(object sender, EventArgs e)//puts you back to the overview form
        {
            Main temp = new Main();
            this.Close();
            temp.Show();
        }

        private void pb_x_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void pb_x_Click(object sender, EventArgs e)
        {

        }

        private void btn_Vorheriges_Click(object sender, EventArgs e)//jumps one month back and resets all the days and adapts to the month selected 
        {
            flp_daycontainer.Controls.Clear();
            DateTime now = DateTime.Now;

            if (month == 1)
            {
                year--;
                month = 12;

            }
            else
            {
                month--;

            }


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
                if (i == now.Day && month == now.Month && year == now.Year)
                {
                    ucdays.BackColor = Color.FromArgb(25, Color.Green);
                }
                flp_daycontainer.Controls.Add(ucdays);
            }
        }

        private void btn_Nächstes_Click(object sender, EventArgs e)//jumps one month forward and resets all the days and adapts to the month selected 
        {
            flp_daycontainer.Controls.Clear();
            DateTime now = DateTime.Now;


            if (month == 12)
            {
                year++;
                month = 1;

            }
            else
            {
                month++;

            }
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
                if (i == now.Day && month == now.Month && year == now.Year)
                {

                    ucdays.BackColor = Color.FromArgb(25, Color.Green);
                }
                flp_daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
