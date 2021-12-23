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

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
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
            btn_add.Enabled = true;
            btn_save.Enabled = false;

            if (cB_addStaff.Checked)
            {
                btn_add.Enabled = true;
                btn_save.Enabled = false;
                btn_load.Enabled = false;
                cB_indexStaff.Enabled = false;
                btn_delete.Enabled = false;
            }
            else
            {
                btn_add.Enabled = false;
                btn_save.Enabled = true;
                btn_load.Enabled = true;
                cB_indexStaff.Enabled = true;
                btn_delete.Enabled = true;
            }
        }
    }
}

