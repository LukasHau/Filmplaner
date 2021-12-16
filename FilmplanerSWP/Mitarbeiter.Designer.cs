
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
            this.cB_indexWorker = new System.Windows.Forms.ComboBox();
            this.lbl_index = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.tB_warrnaty = new System.Windows.Forms.TextBox();
            this.cB_description = new System.Windows.Forms.ComboBox();
            this.rTB_info = new System.Windows.Forms.RichTextBox();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_price = new System.Windows.Forms.TextBox();
            this.dTP_installation = new System.Windows.Forms.DateTimePicker();
            this.cB_state = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cB_addWorker = new System.Windows.Forms.CheckBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
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
            // cB_indexWorker
            // 
            this.cB_indexWorker.FormattingEnabled = true;
            this.cB_indexWorker.Location = new System.Drawing.Point(422, 10);
            this.cB_indexWorker.Name = "cB_indexWorker";
            this.cB_indexWorker.Size = new System.Drawing.Size(200, 21);
            this.cB_indexWorker.TabIndex = 49;
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
            // tB_warrnaty
            // 
            this.tB_warrnaty.Location = new System.Drawing.Point(422, 52);
            this.tB_warrnaty.Name = "tB_warrnaty";
            this.tB_warrnaty.Size = new System.Drawing.Size(200, 20);
            this.tB_warrnaty.TabIndex = 45;
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
            this.cB_description.Location = new System.Drawing.Point(107, 95);
            this.cB_description.Name = "cB_description";
            this.cB_description.Size = new System.Drawing.Size(200, 21);
            this.cB_description.TabIndex = 44;
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
            // tB_price
            // 
            this.tB_price.Location = new System.Drawing.Point(107, 134);
            this.tB_price.Name = "tB_price";
            this.tB_price.Size = new System.Drawing.Size(200, 20);
            this.tB_price.TabIndex = 41;
            // 
            // dTP_installation
            // 
            this.dTP_installation.Location = new System.Drawing.Point(107, 173);
            this.dTP_installation.Name = "dTP_installation";
            this.dTP_installation.Size = new System.Drawing.Size(200, 20);
            this.dTP_installation.TabIndex = 40;
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
            this.cB_state.Location = new System.Drawing.Point(107, 215);
            this.cB_state.Name = "cB_state";
            this.cB_state.Size = new System.Drawing.Size(200, 21);
            this.cB_state.TabIndex = 39;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Garantie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Zustand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Inbetriebnahme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Preis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Beschreibung:";
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
            // cB_addWorker
            // 
            this.cB_addWorker.AutoSize = true;
            this.cB_addWorker.Location = new System.Drawing.Point(12, 12);
            this.cB_addWorker.Name = "cB_addWorker";
            this.cB_addWorker.Size = new System.Drawing.Size(130, 17);
            this.cB_addWorker.TabIndex = 31;
            this.cB_addWorker.Text = "Mitarbeiter hinzufügen";
            this.cB_addWorker.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 286);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(189, 45);
            this.btn_back.TabIndex = 30;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(433, 286);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 45);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Speichern";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // Mitarbeiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 341);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cB_indexWorker);
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
            this.Controls.Add(this.cB_addWorker);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_save);
            this.Name = "Mitarbeiter";
            this.Text = "Mitarbeiter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cB_indexWorker;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.TextBox tB_warrnaty;
        private System.Windows.Forms.ComboBox cB_description;
        private System.Windows.Forms.RichTextBox rTB_info;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_price;
        private System.Windows.Forms.DateTimePicker dTP_installation;
        private System.Windows.Forms.ComboBox cB_state;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cB_addWorker;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_save;
    }
}