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

        public EventForm()
        {
            InitializeComponent();
        }

        public void EventForm_Load(object sender, EventArgs e)
        {
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.FlatAppearance.BorderColor = Color.CornflowerBlue;

            txtb_date.Text = BenutzerKontrolleTage.static_day + "/" + Kalender.static_month + "/" + Kalender.static_year;
            
            int lblH = 45;
            int lblB = 390;


            foreach (int x in SQLConnection.SelectStaffID())
            {
                x.ToString();
                SQLConnection.SelectStaffSurname(x);
                SQLConnection.SelectStaffName(x);

                CheckBox c = new CheckBox();
                c.Height = 30;
                c.Text = SQLConnection.SurnameSelectStaff + " " + SQLConnection.NameSelectStaff;
                c.Name = "CBStaff" + x;               
                c.Location = new Point(lblB, lblH);
                this.Controls.Add(c);

                lblH = lblH + 25;
            }

            int lblH2 = 45;
            int lblB2 = 550;

            foreach (int x in SQLConnection.SelectEquipmentID())
            {
                x.ToString();
                SQLConnection.SelectEquipmentName(x);
                SQLConnection.SelectEquipmentDescription(x);

                CheckBox t = new CheckBox();
                t.Width = 500;
                t.Height = 30;
                t.Text = x + " " + SQLConnection.DescriptionEquipment + " -- " + SQLConnection.NameSelectEquipment;
                t.Name = "CBEquip" + x;
                t.Location = new Point(lblB2, lblH2);
                this.Controls.Add(t);


                lblH2 = lblH2 + 25;
            }

            UpdateForm();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(SQLConnection.CheckEvent(txtb_date.Text) == true)
            {
                SQLConnection.CreateEvent(txtb_date.Text, txtb_location.Text, txtb_time.Text, txtb_event.Text, txtb_client.Text, txtb_contact_person.Text, txtb_description.Text);
            }
            else
            {
                SQLConnection.ChangeEvent(txtb_date.Text, txtb_location.Text, txtb_time.Text, txtb_event.Text, txtb_client.Text, txtb_contact_person.Text, txtb_description.Text);
            }


            UpdateForm();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateForm()
        {
            SQLConnection.LoadEvent(txtb_date.Text);

            txtb_location.Text = SQLConnection.EventPlace;
            txtb_time.Text = SQLConnection.EventTime;
            txtb_event.Text = SQLConnection.EventeventName;
            txtb_client.Text = SQLConnection.EventClient;
            txtb_contact_person.Text = SQLConnection.EventContactPerson;
            txtb_description.Text = SQLConnection.EventDescription;
        }
    }
}
