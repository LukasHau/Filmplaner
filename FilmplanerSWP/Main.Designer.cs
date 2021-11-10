
namespace FilmplanerSWP
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calender = new System.Windows.Forms.Button();
            this.btn_equipment = new System.Windows.Forms.Button();
            this.btn_administration = new System.Windows.Forms.Button();
            this.btn_employee = new System.Windows.Forms.Button();
            this.pB_exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calender
            // 
            this.btn_calender.BackColor = System.Drawing.Color.Transparent;
            this.btn_calender.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_calender.Font = new System.Drawing.Font("Lucida Sans", 21.75F);
            this.btn_calender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_calender.Location = new System.Drawing.Point(82, 190);
            this.btn_calender.Name = "btn_calender";
            this.btn_calender.Size = new System.Drawing.Size(360, 102);
            this.btn_calender.TabIndex = 0;
            this.btn_calender.Text = "Kalender";
            this.btn_calender.UseVisualStyleBackColor = false;
            // 
            // btn_equipment
            // 
            this.btn_equipment.Font = new System.Drawing.Font("Lucida Sans", 21.75F);
            this.btn_equipment.Location = new System.Drawing.Point(448, 190);
            this.btn_equipment.Name = "btn_equipment";
            this.btn_equipment.Size = new System.Drawing.Size(360, 102);
            this.btn_equipment.TabIndex = 1;
            this.btn_equipment.Text = "Equipment";
            this.btn_equipment.UseVisualStyleBackColor = true;
            // 
            // btn_administration
            // 
            this.btn_administration.Font = new System.Drawing.Font("Lucida Sans", 21.75F);
            this.btn_administration.Location = new System.Drawing.Point(82, 298);
            this.btn_administration.Name = "btn_administration";
            this.btn_administration.Size = new System.Drawing.Size(360, 102);
            this.btn_administration.TabIndex = 2;
            this.btn_administration.Text = "Verwaltung";
            this.btn_administration.UseVisualStyleBackColor = true;
            this.btn_administration.Click += new System.EventHandler(this.btn_administration_Click);
            // 
            // btn_employee
            // 
            this.btn_employee.Font = new System.Drawing.Font("Lucida Sans", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee.Location = new System.Drawing.Point(448, 298);
            this.btn_employee.Name = "btn_employee";
            this.btn_employee.Size = new System.Drawing.Size(360, 102);
            this.btn_employee.TabIndex = 3;
            this.btn_employee.Text = "Mitarbeiter";
            this.btn_employee.UseVisualStyleBackColor = true;
            // 
            // pB_exit
            // 
            this.pB_exit.BackColor = System.Drawing.Color.Transparent;
            this.pB_exit.Location = new System.Drawing.Point(35, 519);
            this.pB_exit.Name = "pB_exit";
            this.pB_exit.Size = new System.Drawing.Size(173, 40);
            this.pB_exit.TabIndex = 4;
            this.pB_exit.TabStop = false;
            this.pB_exit.Click += new System.EventHandler(this.pB_exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FilmplanerSWP.Properties.Resources.Main2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(880, 589);
            this.ControlBox = false;
            this.Controls.Add(this.pB_exit);
            this.Controls.Add(this.btn_employee);
            this.Controls.Add(this.btn_administration);
            this.Controls.Add(this.btn_equipment);
            this.Controls.Add(this.btn_calender);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pB_exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calender;
        private System.Windows.Forms.Button btn_equipment;
        private System.Windows.Forms.Button btn_administration;
        private System.Windows.Forms.Button btn_employee;
        private System.Windows.Forms.PictureBox pB_exit;
    }
}