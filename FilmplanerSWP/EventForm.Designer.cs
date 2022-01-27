﻿
namespace FilmplanerSWP
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.txtb_date = new System.Windows.Forms.TextBox();
            this.txtb_event = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_event = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_client = new System.Windows.Forms.Label();
            this.lbl_contact_person = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtb_location = new System.Windows.Forms.TextBox();
            this.txtb_time = new System.Windows.Forms.TextBox();
            this.txtb_client = new System.Windows.Forms.TextBox();
            this.txtb_contact_person = new System.Windows.Forms.TextBox();
            this.txtb_description = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_date
            // 
            this.txtb_date.Enabled = false;
            this.txtb_date.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_date.Location = new System.Drawing.Point(12, 37);
            this.txtb_date.Name = "txtb_date";
            this.txtb_date.Size = new System.Drawing.Size(147, 27);
            this.txtb_date.TabIndex = 0;
            // 
            // txtb_event
            // 
            this.txtb_event.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_event.Location = new System.Drawing.Point(12, 129);
            this.txtb_event.Multiline = true;
            this.txtb_event.Name = "txtb_event";
            this.txtb_event.Size = new System.Drawing.Size(364, 40);
            this.txtb_event.TabIndex = 3;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(12, 20);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(41, 14);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "Datum";
            // 
            // lbl_event
            // 
            this.lbl_event.AutoSize = true;
            this.lbl_event.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_event.Location = new System.Drawing.Point(12, 113);
            this.lbl_event.Name = "lbl_event";
            this.lbl_event.Size = new System.Drawing.Size(80, 14);
            this.lbl_event.TabIndex = 3;
            this.lbl_event.Text = "Bezeichnung";
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_save.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.Location = new System.Drawing.Point(279, 352);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(97, 38);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_location.Location = new System.Drawing.Point(12, 67);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(24, 14);
            this.lbl_location.TabIndex = 5;
            this.lbl_location.Text = "Ort";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(190, 67);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(28, 14);
            this.lbl_time.TabIndex = 6;
            this.lbl_time.Text = "Zeit";
            // 
            // lbl_client
            // 
            this.lbl_client.AutoSize = true;
            this.lbl_client.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_client.Location = new System.Drawing.Point(12, 171);
            this.lbl_client.Name = "lbl_client";
            this.lbl_client.Size = new System.Drawing.Size(78, 14);
            this.lbl_client.TabIndex = 7;
            this.lbl_client.Text = "Auftraggeber";
            // 
            // lbl_contact_person
            // 
            this.lbl_contact_person.AutoSize = true;
            this.lbl_contact_person.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contact_person.Location = new System.Drawing.Point(12, 230);
            this.lbl_contact_person.Name = "lbl_contact_person";
            this.lbl_contact_person.Size = new System.Drawing.Size(86, 14);
            this.lbl_contact_person.TabIndex = 8;
            this.lbl_contact_person.Text = "Kontaktperson";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(12, 289);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(83, 14);
            this.lbl_description.TabIndex = 9;
            this.lbl_description.Text = "Beschreibung";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_back.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.Black;
            this.btn_back.Location = new System.Drawing.Point(12, 352);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 38);
            this.btn_back.TabIndex = 8;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtb_location
            // 
            this.txtb_location.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_location.Location = new System.Drawing.Point(12, 83);
            this.txtb_location.Name = "txtb_location";
            this.txtb_location.Size = new System.Drawing.Size(175, 27);
            this.txtb_location.TabIndex = 1;
            // 
            // txtb_time
            // 
            this.txtb_time.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_time.Location = new System.Drawing.Point(193, 83);
            this.txtb_time.Name = "txtb_time";
            this.txtb_time.Size = new System.Drawing.Size(183, 27);
            this.txtb_time.TabIndex = 2;
            // 
            // txtb_client
            // 
            this.txtb_client.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_client.Location = new System.Drawing.Point(12, 188);
            this.txtb_client.Multiline = true;
            this.txtb_client.Name = "txtb_client";
            this.txtb_client.Size = new System.Drawing.Size(364, 40);
            this.txtb_client.TabIndex = 4;
            // 
            // txtb_contact_person
            // 
            this.txtb_contact_person.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_contact_person.Location = new System.Drawing.Point(12, 247);
            this.txtb_contact_person.Multiline = true;
            this.txtb_contact_person.Name = "txtb_contact_person";
            this.txtb_contact_person.Size = new System.Drawing.Size(364, 40);
            this.txtb_contact_person.TabIndex = 5;
            // 
            // txtb_description
            // 
            this.txtb_description.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_description.Location = new System.Drawing.Point(12, 306);
            this.txtb_description.Multiline = true;
            this.txtb_description.Name = "txtb_description";
            this.txtb_description.Size = new System.Drawing.Size(364, 40);
            this.txtb_description.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::FilmplanerSWP.Properties.Resources.Filmplaner_logo_transparent;
            this.pictureBox1.Location = new System.Drawing.Point(279, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 399);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtb_description);
            this.Controls.Add(this.txtb_contact_person);
            this.Controls.Add(this.txtb_client);
            this.Controls.Add(this.txtb_time);
            this.Controls.Add(this.txtb_location);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_contact_person);
            this.Controls.Add(this.lbl_client);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_event);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txtb_event);
            this.Controls.Add(this.txtb_date);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventForm";
            this.Text = "Event";
            this.Load += new System.EventHandler(this.EventForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_date;
        private System.Windows.Forms.TextBox txtb_event;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_event;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_client;
        private System.Windows.Forms.Label lbl_contact_person;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtb_location;
        private System.Windows.Forms.TextBox txtb_time;
        private System.Windows.Forms.TextBox txtb_client;
        private System.Windows.Forms.TextBox txtb_contact_person;
        private System.Windows.Forms.TextBox txtb_description;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}