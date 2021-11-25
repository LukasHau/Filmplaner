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
        public Equipment()
        {
            InitializeComponent();
        }

        private void dG_Equipment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            btn_add.Enabled = false;
            cB_description.DropDownStyle = ComboBoxStyle.DropDownList;
            cB_state.DropDownStyle = ComboBoxStyle.DropDownList;

            //clear all fields and imports the index
            ClearEquipment();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Equipment temp = new Equipment();
            this.Close();
            temp.Show();
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
            btn_add.Enabled = true;
            btn_save.Enabled = false;

            if (cB_addEquipment.Checked)
            {
                btn_add.Enabled = true;
                btn_save.Enabled = false;
                btn_load.Enabled = false;
                cB_indexEquipment.Enabled = false;
            }
            else
            {
                btn_add.Enabled = false;
                btn_save.Enabled = true;
                btn_load.Enabled = true;
                cB_indexEquipment.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
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
            string temp = cB_indexEquipment.SelectedItem.ToString();
            int x = Convert.ToInt32(temp.Substring(0, 2));
            SQLConnection.LoadEqipment(x);
            MessageBox.Show(SQLConnection.EqipmentLoad);
        }
    }
}
