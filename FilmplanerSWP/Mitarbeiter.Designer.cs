
namespace FilmplanerSWP
{
    partial class Mitarbeiter
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.cB_indexStaff = new System.Windows.Forms.ComboBox();
            this.lbl_index = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.cB_job = new System.Windows.Forms.ComboBox();
            this.rTB_info = new System.Windows.Forms.RichTextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_surname = new System.Windows.Forms.TextBox();
            this.dTP_StartingDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_addStaff = new System.Windows.Forms.CheckBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dTP_age = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_adress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(533, 286);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 45);
            this.btn_delete.TabIndex = 50;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // cB_indexStaff
            // 
            this.cB_indexStaff.FormattingEnabled = true;
            this.cB_indexStaff.Location = new System.Drawing.Point(422, 10);
            this.cB_indexStaff.Name = "cB_indexStaff";
            this.cB_indexStaff.Size = new System.Drawing.Size(200, 21);
            this.cB_indexStaff.TabIndex = 49;
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(347, 13);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(36, 13);
            this.lbl_index.TabIndex = 48;
            this.lbl_index.Text = "Index:";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(233, 286);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 45);
            this.btn_add.TabIndex = 47;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(333, 286);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(94, 45);
            this.btn_load.TabIndex = 46;
            this.btn_load.Text = "Laden";
            this.btn_load.UseVisualStyleBackColor = true;
            // 
            // cB_job
            // 
            this.cB_job.Items.AddRange(new object[] {
            "Kamera",
            "Objektiv",
            "Mikrofon",
            "SD Karte",
            "C-Fast Karte",
            "Licht",
            "Laptop",
            "Akku",
            "Stativ",
            "Gimbal",
            "Drohne",
            "Fernsteuerung",
            "Ladegerät",
            "Pelicase",
            "Zubehör"});
            this.cB_job.Location = new System.Drawing.Point(422, 52);
            this.cB_job.Name = "cB_job";
            this.cB_job.Size = new System.Drawing.Size(200, 21);
            this.cB_job.TabIndex = 44;
            // 
            // rTB_info
            // 
            this.rTB_info.Location = new System.Drawing.Point(422, 95);
            this.rTB_info.Name = "rTB_info";
            this.rTB_info.Size = new System.Drawing.Size(200, 141);
            this.rTB_info.TabIndex = 43;
            this.rTB_info.Text = "";
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(107, 52);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(200, 20);
            this.tB_name.TabIndex = 42;
            // 
            // tB_surname
            // 
            this.tB_surname.Location = new System.Drawing.Point(107, 95);
            this.tB_surname.Name = "tB_surname";
            this.tB_surname.Size = new System.Drawing.Size(200, 20);
            this.tB_surname.TabIndex = 41;
            // 
            // dTP_StartingDate
            // 
            this.dTP_StartingDate.Location = new System.Drawing.Point(107, 210);
            this.dTP_StartingDate.Name = "dTP_StartingDate";
            this.dTP_StartingDate.Size = new System.Drawing.Size(200, 20);
            this.dTP_StartingDate.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(347, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Info:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Geburtsdatum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Einstellung:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(9, 98);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(62, 13);
            this.lbl_surname.TabIndex = 34;
            this.lbl_surname.Text = "Nachname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Job:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name:";
            // 
            // cB_addStaff
            // 
            this.cB_addStaff.AutoSize = true;
            this.cB_addStaff.Location = new System.Drawing.Point(12, 12);
            this.cB_addStaff.Name = "cB_addStaff";
            this.cB_addStaff.Size = new System.Drawing.Size(130, 17);
            this.cB_addStaff.TabIndex = 31;
            this.cB_addStaff.Text = "Mitarbeiter hinzufügen";
            this.cB_addStaff.UseVisualStyleBackColor = true;
            this.cB_addStaff.CheckedChanged += new System.EventHandler(this.cB_addWorker_CheckedChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 286);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(189, 45);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(433, 286);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 45);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dTP_age
            // 
            this.dTP_age.Location = new System.Drawing.Point(107, 131);
            this.dTP_age.Name = "dTP_age";
            this.dTP_age.Size = new System.Drawing.Size(200, 20);
            this.dTP_age.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Adresse:";
            // 
            // tB_adress
            // 
            this.tB_adress.Location = new System.Drawing.Point(107, 173);
            this.tB_adress.Name = "tB_adress";
            this.tB_adress.Size = new System.Drawing.Size(200, 20);
            this.tB_adress.TabIndex = 53;
            // 
            // Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 341);
            this.Controls.Add(this.tB_adress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dTP_age);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cB_indexStaff);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.cB_job);
            this.Controls.Add(this.rTB_info);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.tB_surname);
            this.Controls.Add(this.dTP_StartingDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_addStaff);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Name = "Mitarbeiter";
            this.Text = "Mitarbeiter";
            this.Load += new System.EventHandler(this.Mitarbeiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cB_indexStaff;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.ComboBox cB_job;
        private System.Windows.Forms.RichTextBox rTB_info;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_surname;
        private System.Windows.Forms.DateTimePicker dTP_StartingDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cB_addStaff;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker dTP_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_adress;
    }
}