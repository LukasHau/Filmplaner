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
    public partial class BenutzerKontrolleTage : UserControl
    {
        public BenutzerKontrolleTage()
        {
            InitializeComponent();
        }

        private void BenutzerKontrolleTage_Load(object sender, EventArgs e)
        {

        }

        public void days(int numday)
        {
            lbl_days.Text = numday + "";
        }
    }
}
