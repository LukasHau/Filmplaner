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
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.FlatAppearance.BorderColor = Color.CornflowerBlue;

            txtb_date.Text =BenutzerKontrolleTage.static_day + "/" + Kalender.static_month + "/" + Kalender.static_year;
            
            int lblH = 45;
            int lblB = 385;

            foreach (int x in SQLConnection.SelectStaffID())
            {
                x.ToString();
                SQLConnection.SelectStaffSurname(x);
                SQLConnection.SelectStaffName(x);

                Label l = new Label();
                CheckBox c = new CheckBox();
                l.Text = SQLConnection.SurnameSelectStaff + " " + SQLConnection.NameSelectStaff;
                l.Location = new Point(lblB, lblH);
                l.Name = "Label" + x;
                this.Controls.Add(l);
                System.Diagnostics.Debug.WriteLine(l.Text);
                
                c.Name = "CB" + x;
                c.Location = new Point(lblB + 50, lblH);
                c.Text = "Test";
                this.Controls.Add(c);


                lblH = lblH + 25;
            }
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
