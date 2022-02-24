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

            foreach (int x in SQLConnection.SelectStaffID())
            {
                x.ToString();
                SQLConnection.SelectStaffSurname(x);
                SQLConnection.SelectStaffName(x);

                cLBWork.Items.Add(SQLConnection.SurnameSelectStaff + " " + SQLConnection.NameSelectStaff);
            }

            foreach (int x in SQLConnection.SelectEquipmentID())
            {
                x.ToString();
                SQLConnection.SelectEquipmentName(x);
                SQLConnection.SelectEquipmentDescription(x);

                cLBEquip.Items.Add(x + " " + SQLConnection.DescriptionEquipment + " -- " + SQLConnection.NameSelectEquipment);
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

            //foreach (object control in )
            //{
            //    if (control.GetType() == typeof(CheckBox))
            //    {
            //        MessageBox.Show("true " + t.Name);
            //    }
            //}

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
