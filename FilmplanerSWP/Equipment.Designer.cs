
namespace FilmplanerSWP
{
    partial class Equipment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipment));
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.cB_addEquipment = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cB_state = new System.Windows.Forms.ComboBox();
            this.dTP_installation = new System.Windows.Forms.DateTimePicker();
            this.tB_price = new System.Windows.Forms.TextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.rTB_info = new System.Windows.Forms.RichTextBox();
            this.cB_description = new System.Windows.Forms.ComboBox();
            this.tB_warrnaty = new System.Windows.Forms.TextBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_index = new System.Windows.Forms.Label();
            this.cB_indexEquipment = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pb_x = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_x)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.Location = new System.Drawing.Point(438, 302);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 45);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.Location = new System.Drawing.Point(17, 302);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(189, 45);
            this.btn_back.TabIndex = 14;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cB_addEquipment
            // 
            this.cB_addEquipment.AutoSize = true;
            this.cB_addEquipment.Location = new System.Drawing.Point(17, 28);
            this.cB_addEquipment.Name = "cB_addEquipment";
            this.cB_addEquipment.Size = new System.Drawing.Size(131, 17);
            this.cB_addEquipment.TabIndex = 1;
            this.cB_addEquipment.Text = "Equipment hinzufügen";
            this.cB_addEquipment.UseVisualStyleBackColor = true;
            this.cB_addEquipment.CheckedChanged += new System.EventHandler(this.cB_addEquipment_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Beschreibung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Preis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inbetriebnahme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Zustand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Garantie:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Info:";
            // 
            // cB_state
            // 
            this.cB_state.FormattingEnabled = true;
            this.cB_state.Items.AddRange(new object[] {
            "Sehr Gut",
            "Gut",
            "Ok",
            "Schlecht",
            "Sehr Schlecht"});
            this.cB_state.Location = new System.Drawing.Point(112, 231);
            this.cB_state.Name = "cB_state";
            this.cB_state.Size = new System.Drawing.Size(200, 21);
            this.cB_state.TabIndex = 6;
            // 
            // dTP_installation
            // 
            this.dTP_installation.Location = new System.Drawing.Point(112, 189);
            this.dTP_installation.Name = "dTP_installation";
            this.dTP_installation.Size = new System.Drawing.Size(200, 20);
            this.dTP_installation.TabIndex = 5;
            // 
            // tB_price
            // 
            this.tB_price.Location = new System.Drawing.Point(112, 150);
            this.tB_price.Name = "tB_price";
            this.tB_price.Size = new System.Drawing.Size(200, 20);
            this.tB_price.TabIndex = 4;
            // 
            // tB_name
            // 
            this.tB_name.Location = new System.Drawing.Point(112, 68);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(200, 20);
            this.tB_name.TabIndex = 2;
            // 
            // rTB_info
            // 
            this.rTB_info.Location = new System.Drawing.Point(427, 111);
            this.rTB_info.Name = "rTB_info";
            this.rTB_info.Size = new System.Drawing.Size(200, 141);
            this.rTB_info.TabIndex = 9;
            this.rTB_info.Text = "";
            // 
            // cB_description
            // 
            this.cB_description.Items.AddRange(new object[] {
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
            this.cB_description.Location = new System.Drawing.Point(112, 111);
            this.cB_description.Name = "cB_description";
            this.cB_description.Size = new System.Drawing.Size(200, 21);
            this.cB_description.TabIndex = 3;
            // 
            // tB_warrnaty
            // 
            this.tB_warrnaty.Location = new System.Drawing.Point(427, 68);
            this.tB_warrnaty.Name = "tB_warrnaty";
            this.tB_warrnaty.Size = new System.Drawing.Size(200, 20);
            this.tB_warrnaty.TabIndex = 8;
            // 
            // btn_load
            // 
            this.btn_load.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_load.BackgroundImage")));
            this.btn_load.Location = new System.Drawing.Point(338, 302);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(94, 45);
            this.btn_load.TabIndex = 11;
            this.btn_load.Text = "Laden";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_add.BackgroundImage")));
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(238, 302);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 45);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(352, 29);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(36, 13);
            this.lbl_index.TabIndex = 26;
            this.lbl_index.Text = "Index:";
            // 
            // cB_indexEquipment
            // 
            this.cB_indexEquipment.FormattingEnabled = true;
            this.cB_indexEquipment.Location = new System.Drawing.Point(427, 26);
            this.cB_indexEquipment.Name = "cB_indexEquipment";
            this.cB_indexEquipment.Size = new System.Drawing.Size(200, 21);
            this.cB_indexEquipment.TabIndex = 7;
            // 
            // btn_delete
            // 
            this.btn_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_delete.BackgroundImage")));
            this.btn_delete.Location = new System.Drawing.Point(538, 302);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 45);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pb_x
            // 
            this.pb_x.BackColor = System.Drawing.SystemColors.Control;
            this.pb_x.BackgroundImage = global::FilmplanerSWP.Properties.Resources.x_button;
            this.pb_x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_x.Location = new System.Drawing.Point(618, 4);
            this.pb_x.Name = "pb_x";
            this.pb_x.Size = new System.Drawing.Size(18, 16);
            this.pb_x.TabIndex = 27;
            this.pb_x.TabStop = false;
            this.pb_x.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pb_x_MouseClick);
            // 
            // Equipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 359);
            this.Controls.Add(this.pb_x);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cB_indexEquipment);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.tB_warrnaty);
            this.Controls.Add(this.cB_description);
            this.Controls.Add(this.rTB_info);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.tB_price);
            this.Controls.Add(this.dTP_installation);
            this.Controls.Add(this.cB_state);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_addEquipment);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Equipment";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.Equipment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_x)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.CheckBox cB_addEquipment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cB_state;
        private System.Windows.Forms.DateTimePicker dTP_installation;
        private System.Windows.Forms.TextBox tB_price;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.RichTextBox rTB_info;
        private System.Windows.Forms.TextBox tB_warrnaty;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cB_description;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.ComboBox cB_indexEquipment;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pb_x;
    }
}