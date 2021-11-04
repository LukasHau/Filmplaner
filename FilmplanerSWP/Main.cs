﻿using System;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pB_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                if (Login.userrole == "none")
                {
                    btn_administration.Enabled = false;
                    btn_employee.Enabled = false;
                    btn_equipment.Enabled = false;
                    btn_calender.Enabled = false;
                }
                else if (Login.userrole == "user")
                {
                    btn_administration.Enabled = false;
                    btn_employee.Enabled = false;
                    btn_equipment.Enabled = false;
                }
                else
                {
                    btn_administration.Enabled = true;
                    btn_employee.Enabled = true;
                    btn_equipment.Enabled = true;
                    btn_calender.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
