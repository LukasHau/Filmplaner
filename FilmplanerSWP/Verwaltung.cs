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
    public partial class Verwaltung : Form
    {
        public Verwaltung()
        {
            InitializeComponent();
        }

        //Loads Data-Source-Grid and wirtes the Content from the Login table into it.
        private void Verwaltung_Load(object sender, EventArgs e)
        {
            dG_table.DataSource = SQLConnection.LoadDataInDG();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Main temp = new Main();
            this.Close();
            temp.Show();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SQLConnection.SaveDG();
        }
    }
}
