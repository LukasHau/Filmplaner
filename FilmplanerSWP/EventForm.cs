using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FilmplanerSWP
{
    public partial class EventForm : Form
    {
        private int ID_equip;
        private int ID_staff;

        public EventForm()
        {
            InitializeComponent();
        }

        public void EventForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (Login.userrole == "admin")
                {
                    btn_save.Enabled = true;
                    cLBEquip.Enabled = true;
                    cLBWork.Enabled = true;

                }
                else if (Login.userrole == "user")
                {
                    btn_save.Enabled = true;
                    cLBEquip.Enabled = true;
                    cLBWork.Enabled = true;
                }
                else
                {
                    btn_save.Enabled = false;
                    cLBEquip.Enabled = false;
                    cLBWork.Enabled = false;
                    txtb_client.Enabled = false;
                    txtb_contact_person.Enabled = false;
                    txtb_description.Enabled = false;
                    txtb_event.Enabled = false;
                    txtb_location.Enabled = false;
                    txtb_time.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.FlatAppearance.BorderColor = Color.CornflowerBlue;

            txtb_date.Text = BenutzerKontrolleTage.static_day + "/" + Kalender.static_month + "/" + Kalender.static_year;

            //load all objects of Staff in the Checklist Box
            foreach (int x in SQLConnection.SelectStaffID())
            {
                x.ToString();
                SQLConnection.SelectStaffSurname(x);
                SQLConnection.SelectStaffName(x);

                cLBWork.Items.Add(x + ". " + SQLConnection.SurnameSelectStaff + " " + SQLConnection.NameSelectStaff);
            }

            //load all objects of Equipment in the Checklist Box
            foreach (int x in SQLConnection.SelectEquipmentID())
            {
                x.ToString();
                SQLConnection.SelectEquipmentName(x);
                SQLConnection.SelectEquipmentDescription(x);

                cLBEquip.Items.Add(x + ". " + SQLConnection.DescriptionEquipment + " -- " + SQLConnection.NameSelectEquipment);
            }
           
            UpdateForm();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //creates an Event if there is no existing one or changes it
            if(SQLConnection.CheckEvent(txtb_date.Text) == true)
            {
                SQLConnection.CreateEvent(txtb_date.Text, txtb_location.Text, txtb_time.Text, txtb_event.Text, txtb_client.Text, txtb_contact_person.Text, txtb_description.Text);
            }
            else
            {
                SQLConnection.ChangeEvent(txtb_date.Text, txtb_location.Text, txtb_time.Text, txtb_event.Text, txtb_client.Text, txtb_contact_person.Text, txtb_description.Text);
            }

            //delets all items with the same date
            SQLConnection.DeleteStaffInUse(txtb_date.Text);
            SQLConnection.DeleteEquipInUse(txtb_date.Text);

            if (cLBWork.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.
                
                for (int x = 0; x < cLBWork.CheckedItems.Count; x++)
                {
                    //cuts the string after the point, to get the ID of the subject
                    ID_staff = Convert.ToInt32(cLBWork.CheckedItems[x].ToString().Substring(0, cLBWork.CheckedItems[x].ToString().IndexOf(".")));

                    SQLConnection.AddStaffInUse(ID_staff, txtb_date.Text);

                }
            }
            
            if (cLBEquip.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                
                for (int x = 0; x < cLBEquip.CheckedItems.Count; x++)
                {
                    //cuts the string after the point, to get the ID of the subject
                    ID_equip = Convert.ToInt32(cLBEquip.CheckedItems[x].ToString().Substring(0, cLBEquip.CheckedItems[x].ToString().IndexOf(".")));

                    SQLConnection.AddEquipInUse(ID_equip, txtb_date.Text);

                }
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

            //checks if the database contains a data with the right date
            foreach (int x in SQLConnection.LoadStaffInUse(txtb_date.Text))
            {
                //for every item in the CheckedListBox
                for (int i = 0; i < cLBWork.Items.Count; i++)
                {
                    //checks if the value of the item before the '.' = the Index, is the same, if so it checks the value
                    if (cLBWork.Items[i].ToString().Substring(0, cLBWork.Items[i].ToString().IndexOf(".")).Contains(x.ToString()))
                    {
                        cLBWork.SetItemChecked(i, true);
                    }
                }
            }

            //checks if the database contains a data with the right date
            foreach (int x in SQLConnection.LoadEquipInUse(txtb_date.Text))
            {
                //for every item in the CheckedListBox
                for (int i = 0; i < cLBEquip.Items.Count; i++)
                {
                    //checks if the value of the item before the '.' = the Index, is the same, if so it checks the value
                    if (cLBEquip.Items[i].ToString().Substring(0, cLBEquip.Items[i].ToString().IndexOf(".")).Contains(x.ToString()))
                    {
                        cLBEquip.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void cLBWork_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cLBEquip_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
