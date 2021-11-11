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
            dG_Equipment.DataSource = SQLConnection.ShowData("swp4_equipment");
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
    }
}
