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
           
            btn_calender.FlatStyle = FlatStyle.Flat;    //the buttons are converted into flatstyle buttons
            btn_calender.FlatAppearance.BorderColor = Color.CornflowerBlue; //the now converted button is getting a certain border colour

            btn_equipment.FlatStyle = FlatStyle.Flat;
            btn_equipment.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_employee.FlatStyle = FlatStyle.Flat;
            btn_employee.FlatAppearance.BorderColor = Color.CornflowerBlue;

            btn_administration.FlatStyle = FlatStyle.Flat;
            btn_administration.FlatAppearance.BorderColor = Color.CornflowerBlue;

            rolegetter(); //jumps into the class 

        }

        private void btn_administration_Click(object sender, EventArgs e)
        {

        }

        private void rolegetter()
        {
            //endables and disables the buttons for individual users
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_calender_Click(object sender, EventArgs e) //opens the calendar form and hides the current form
        {
            Kalender temp = new Kalender(); 
            this.Hide();
            temp.Show();
        }

        private void btn_equipment_Click(object sender, EventArgs e) //opens the equipment form and hides the current form
        {
            Equipment temp = new Equipment();
            this.Hide();
            temp.Show();
        }

        private void btn_employee_Click(object sender, EventArgs e) //opens the employee form and hides the current form
        {
            Mitarbeiter temp = new Mitarbeiter();
            this.Hide();
            temp.Show();
        }
    }
}
