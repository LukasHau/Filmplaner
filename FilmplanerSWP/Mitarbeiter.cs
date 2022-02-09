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
    public partial class Mitarbeiter : Form
    {
        public int ID = 0;
        public Mitarbeiter()
        {
            InitializeComponent();
        }

        private void Mitarbeiter_Load(object sender, EventArgs e)
        {

            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_load.FlatStyle = FlatStyle.Flat;
            btn_load.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.FlatAppearance.BorderColor = Color.Gray;

            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_add.Enabled = false;
            cB_job.DropDownStyle = ComboBoxStyle.DropDownList;

            //clear all fields and imports the index
            ClearStaff();
        }

        public void ClearStaff()
        {
            tB_name.Clear();
            tB_surname.Clear();
            dTP_age.Value = DateTime.Now;
            tB_adress.Clear();
            dTP_StartingDate.Value = DateTime.Now;
            cB_job.SelectedIndex = -1;
            rTB_info.Clear();
            cB_indexStaff.SelectedIndex = -1;
            cB_indexStaff.Items.Clear();

            foreach (int x in SQLConnection.SelectStaffID())
            {
                x.ToString();
                SQLConnection.SelectStaffSurname(x);
                cB_indexStaff.Items.Add(x + " - " + SQLConnection.SurnameSelectStaff);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //saves the current changes
            SQLConnection.ChangeStaff(tB_name.Text, tB_surname.Text, dTP_age.Value, tB_adress.Text, dTP_StartingDate.Value, cB_job.Text, rTB_info.Text, ID);

            SQLConnection.LoadStaff(ID);

            tB_name.Text = SQLConnection.StaffName;
            tB_surname.Text = SQLConnection.StaffSurname;
            dTP_age.Value = Convert.ToDateTime(SQLConnection.StaffAge);
            tB_adress.Text = SQLConnection.StaffAdress;
            dTP_StartingDate.Value = Convert.ToDateTime(SQLConnection.StaffStartingDate);
            cB_job.Text = SQLConnection.StaffJob;
            rTB_info.Text = SQLConnection.StaffInfo;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //adds a staff member
            SQLConnection.errormessage = true;

            try
            {
                SQLConnection.FillStaff(tB_name.Text, tB_surname.Text, dTP_age.Value.Date, tB_adress.Text, dTP_StartingDate.Value.Date, cB_job.Text, rTB_info.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (SQLConnection.errormessage == false)
            {
                ClearStaff();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ClearStaff();
            Main temp = new Main();
            this.Close();
            temp.Show();
        }

        private void cB_addWorker_CheckedChanged(object sender, EventArgs e)
        {
            //endable and disable buttons
            btn_add.Enabled = true;
            btn_save.Enabled = false;

            if (cB_addStaff.Checked)
            {
                btn_add.Enabled = true;
                btn_add.FlatAppearance.BorderColor = Color.CornflowerBlue;
                btn_save.Enabled = false;
                btn_save.FlatAppearance.BorderColor = Color.Gray;
                btn_load.Enabled = false;
                btn_load.FlatAppearance.BorderColor = Color.Gray;
                cB_indexStaff.Enabled = false;
                btn_delete.Enabled = false;
                btn_delete.FlatAppearance.BorderColor = Color.Gray;
            }
            else
            {
                btn_add.Enabled = false;
                btn_add.FlatAppearance.BorderColor = Color.Gray;
                btn_save.Enabled = true;
                btn_save.FlatAppearance.BorderColor = Color.CornflowerBlue;
                btn_load.Enabled = true;
                btn_load.FlatAppearance.BorderColor = Color.CornflowerBlue;
                cB_indexStaff.Enabled = true;
                btn_delete.Enabled = true;
                btn_delete.FlatAppearance.BorderColor = Color.CornflowerBlue;
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //for the dropdown, inserts all objects to the list
            ID = Convert.ToInt32(cB_indexStaff.SelectedItem.ToString().Substring(0, 2));
            SQLConnection.LoadStaff(ID);

            tB_name.Text = SQLConnection.StaffName;
            tB_surname.Text = SQLConnection.StaffSurname;
            dTP_age.Value = Convert.ToDateTime(SQLConnection.StaffAge);
            tB_adress.Text = SQLConnection.StaffAdress;
            dTP_StartingDate.Value = Convert.ToDateTime(SQLConnection.StaffStartingDate);
            cB_job.Text = SQLConnection.StaffJob;
            rTB_info.Text = SQLConnection.StaffInfo;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //delete a staff member
            ID = Convert.ToInt32(cB_indexStaff.SelectedItem.ToString().Substring(0, 2));
            SQLConnection.LoadStaff(ID);

            DialogResult result = MessageBox.Show("Wollen Sie " + SQLConnection.StaffName + " wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SQLConnection.DeleteStaff(ID);
            }

            ClearStaff();
        }

        private void cB_indexStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

