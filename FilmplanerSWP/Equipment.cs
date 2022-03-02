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
    public partial class Equipment : Form
    {
        public int ID = 0;
        public Equipment()
        {
            InitializeComponent();
        }

        private void dG_Equipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
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
            cB_description.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_state.DropDownStyle = ComboBoxStyle.DropDownList;

            //clear all fields and imports the index
            ClearEquipment();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //saves the current changes
            SQLConnection.ChangeEqipment(tB_name.Text, cB_description.Text, Convert.ToDecimal(tB_price.Text), dTP_installation.Value.Date, cB_state.Text, Convert.ToInt32(tB_warrnaty.Text), rTB_info.Text, ID);

            SQLConnection.LoadEqipment(ID);

            tB_name.Text = SQLConnection.EqipmentName;
            cB_description.Text = SQLConnection.EqipmentDescription;
            tB_price.Text = SQLConnection.EqipmentPrice;
            dTP_installation.Value = Convert.ToDateTime(SQLConnection.EqipmentInstallation);
            cB_state.Text = SQLConnection.EqipmentState;
            tB_warrnaty.Text = SQLConnection.EqipmentWarranty;
            rTB_info.Text = SQLConnection.EqipmentInfo;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            ClearEquipment();
            Main temp = new Main();
            this.Close();
            temp.Show();
        }

        private void cB_addEquipment_CheckedChanged(object sender, EventArgs e)
        {
            //endable and disable buttons
            btn_add.Enabled = true;
            btn_save.Enabled = false;

            if (cB_addEquipment.Checked)
            {
                btn_add.Enabled = true;
                btn_add.FlatAppearance.BorderColor = Color.CornflowerBlue;
                btn_save.Enabled = false;
                btn_save.FlatAppearance.BorderColor = Color.Gray;
                btn_load.Enabled = false;
                btn_load.FlatAppearance.BorderColor = Color.Gray;
                cB_indexEquipment.Enabled = false;
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
                cB_indexEquipment.Enabled = true;
                btn_delete.Enabled = true;
                btn_delete.FlatAppearance.BorderColor = Color.CornflowerBlue;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //adds a equipment
            SQLConnection.errormessage = true;

            try
            {
                SQLConnection.FillEquipment(tB_name.Text, cB_description.Text, Convert.ToDecimal(tB_price.Text), dTP_installation.Value.Date, cB_state.Text, Convert.ToInt32(tB_warrnaty.Text), rTB_info.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (SQLConnection.errormessage == false)
            {
                ClearEquipment();
            }
        }

        public void ClearEquipment()
        {
            tB_name.Clear();
            cB_description.SelectedIndex = -1;
            tB_price.Clear();
            dTP_installation.Value = DateTime.Now;
            cB_state.SelectedIndex = -1;
            tB_warrnaty.Clear();
            rTB_info.Clear();
            cB_indexEquipment.SelectedIndex = -1;
            cB_indexEquipment.Items.Clear();

            foreach (int x in SQLConnection.SelectEquipmentID())
            {
                x.ToString();
                SQLConnection.SelectEquipmentName(x);
                cB_indexEquipment.Items.Add(x + " - " + SQLConnection.NameSelectEquipment);
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            //for the dropdown, inserts all objects to the list
            ID = Convert.ToInt32(cB_indexEquipment.SelectedItem.ToString().Substring(0, 2));
            SQLConnection.LoadEqipment(ID);

            tB_name.Text = SQLConnection.EqipmentName;
            cB_description.Text = SQLConnection.EqipmentDescription;
            tB_price.Text = SQLConnection.EqipmentPrice;
            dTP_installation.Value = Convert.ToDateTime(SQLConnection.EqipmentInstallation);
            cB_state.Text = SQLConnection.EqipmentState;
            tB_warrnaty.Text = SQLConnection.EqipmentWarranty;
            rTB_info.Text = SQLConnection.EqipmentInfo;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //delete a equipment
            ID = Convert.ToInt32(cB_indexEquipment.SelectedItem.ToString().Substring(0, 2));
            SQLConnection.LoadEqipment(ID);

            DialogResult result = MessageBox.Show("Wollen Sie " + SQLConnection.EqipmentName + " wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SQLConnection.DeleteEqipment(ID);
            }

            ClearEquipment();
        }

        private void cB_indexEquipment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
