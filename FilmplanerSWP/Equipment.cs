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
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SQLConnection.SaveTable();
            Equipment temp = new Equipment();
            this.Close();
            temp.Show();

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
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
            }
            else
            {
                btn_add.Enabled = false;
                btn_save.Enabled = true;
                btn_load.Enabled = true;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SQLConnection.FillEquipment(tB_name.Text, cB_description.Text, Convert.ToDecimal(tB_price.Text), dTP_installation.Value, cB_state.Text, Convert.ToInt32(tB_warrnaty.Text), rTB_info.Text);
        }
    }
}
