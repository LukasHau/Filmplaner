
namespace FilmplanerSWP
{
    partial class Kalender
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
            this.flp_daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Vorheriges = new System.Windows.Forms.Button();
            this.btn_Nächstes = new System.Windows.Forms.Button();
            this.lbl_sonntag = new System.Windows.Forms.Label();
            this.lbl_montag = new System.Windows.Forms.Label();
            this.lbl_mittwoch = new System.Windows.Forms.Label();
            this.lbl_dienstag = new System.Windows.Forms.Label();
            this.lbl_freitag = new System.Windows.Forms.Label();
            this.lbl_donnerstag = new System.Windows.Forms.Label();
            this.lbl_samstag = new System.Windows.Forms.Label();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flp_daycontainer
            // 
            this.flp_daycontainer.Location = new System.Drawing.Point(12, 55);
            this.flp_daycontainer.Name = "flp_daycontainer";
            this.flp_daycontainer.Size = new System.Drawing.Size(792, 556);
            this.flp_daycontainer.TabIndex = 0;
            // 
            // btn_Vorheriges
            // 
            this.btn_Vorheriges.Location = new System.Drawing.Point(644, 617);
            this.btn_Vorheriges.Name = "btn_Vorheriges";
            this.btn_Vorheriges.Size = new System.Drawing.Size(75, 23);
            this.btn_Vorheriges.TabIndex = 0;
            this.btn_Vorheriges.Text = "Vorheriges";
            this.btn_Vorheriges.UseVisualStyleBackColor = true;
            this.btn_Vorheriges.Click += new System.EventHandler(this.btn_Vorheriges_Click);
            // 
            // btn_Nächstes
            // 
            this.btn_Nächstes.Location = new System.Drawing.Point(725, 617);
            this.btn_Nächstes.Name = "btn_Nächstes";
            this.btn_Nächstes.Size = new System.Drawing.Size(75, 23);
            this.btn_Nächstes.TabIndex = 1;
            this.btn_Nächstes.Text = "Nächstes";
            this.btn_Nächstes.UseVisualStyleBackColor = true;
            this.btn_Nächstes.Click += new System.EventHandler(this.btn_Nächstes_Click);
            // 
            // lbl_sonntag
            // 
            this.lbl_sonntag.AutoSize = true;
            this.lbl_sonntag.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sonntag.Location = new System.Drawing.Point(42, 33);
            this.lbl_sonntag.Name = "lbl_sonntag";
            this.lbl_sonntag.Size = new System.Drawing.Size(53, 19);
            this.lbl_sonntag.TabIndex = 2;
            this.lbl_sonntag.Text = "Sonntag";
            // 
            // lbl_montag
            // 
            this.lbl_montag.AutoSize = true;
            this.lbl_montag.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_montag.Location = new System.Drawing.Point(160, 33);
            this.lbl_montag.Name = "lbl_montag";
            this.lbl_montag.Size = new System.Drawing.Size(48, 19);
            this.lbl_montag.TabIndex = 3;
            this.lbl_montag.Text = "Montag";
            // 
            // lbl_mittwoch
            // 
            this.lbl_mittwoch.AutoSize = true;
            this.lbl_mittwoch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mittwoch.Location = new System.Drawing.Point(376, 33);
            this.lbl_mittwoch.Name = "lbl_mittwoch";
            this.lbl_mittwoch.Size = new System.Drawing.Size(57, 19);
            this.lbl_mittwoch.TabIndex = 5;
            this.lbl_mittwoch.Text = "Mittwoch";
            // 
            // lbl_dienstag
            // 
            this.lbl_dienstag.AutoSize = true;
            this.lbl_dienstag.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dienstag.Location = new System.Drawing.Point(271, 33);
            this.lbl_dienstag.Name = "lbl_dienstag";
            this.lbl_dienstag.Size = new System.Drawing.Size(55, 19);
            this.lbl_dienstag.TabIndex = 4;
            this.lbl_dienstag.Text = "Dienstag";
            // 
            // lbl_freitag
            // 
            this.lbl_freitag.AutoSize = true;
            this.lbl_freitag.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_freitag.Location = new System.Drawing.Point(610, 33);
            this.lbl_freitag.Name = "lbl_freitag";
            this.lbl_freitag.Size = new System.Drawing.Size(46, 19);
            this.lbl_freitag.TabIndex = 7;
            this.lbl_freitag.Text = "Freitag";
            // 
            // lbl_donnerstag
            // 
            this.lbl_donnerstag.AutoSize = true;
            this.lbl_donnerstag.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_donnerstag.Location = new System.Drawing.Point(484, 33);
            this.lbl_donnerstag.Name = "lbl_donnerstag";
            this.lbl_donnerstag.Size = new System.Drawing.Size(70, 19);
            this.lbl_donnerstag.TabIndex = 6;
            this.lbl_donnerstag.Text = "Donnerstag";
            // 
            // lbl_samstag
            // 
            this.lbl_samstag.AutoSize = true;
            this.lbl_samstag.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_samstag.Location = new System.Drawing.Point(721, 33);
            this.lbl_samstag.Name = "lbl_samstag";
            this.lbl_samstag.Size = new System.Drawing.Size(56, 19);
            this.lbl_samstag.TabIndex = 8;
            this.lbl_samstag.Text = "Samstag";
            // 
            // lbl_datum
            // 
            this.lbl_datum.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum.Location = new System.Drawing.Point(275, 9);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(279, 27);
            this.lbl_datum.TabIndex = 9;
            this.lbl_datum.Text = "MONTH YEAR";
            this.lbl_datum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 653);
            this.Controls.Add(this.lbl_datum);
            this.Controls.Add(this.lbl_samstag);
            this.Controls.Add(this.lbl_freitag);
            this.Controls.Add(this.lbl_donnerstag);
            this.Controls.Add(this.lbl_mittwoch);
            this.Controls.Add(this.lbl_dienstag);
            this.Controls.Add(this.lbl_montag);
            this.Controls.Add(this.lbl_sonntag);
            this.Controls.Add(this.btn_Nächstes);
            this.Controls.Add(this.btn_Vorheriges);
            this.Controls.Add(this.flp_daycontainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kalender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalender";
            this.Load += new System.EventHandler(this.Kalender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_daycontainer;
        private System.Windows.Forms.Button btn_Vorheriges;
        private System.Windows.Forms.Button btn_Nächstes;
        private System.Windows.Forms.Label lbl_sonntag;
        private System.Windows.Forms.Label lbl_montag;
        private System.Windows.Forms.Label lbl_mittwoch;
        private System.Windows.Forms.Label lbl_dienstag;
        private System.Windows.Forms.Label lbl_freitag;
        private System.Windows.Forms.Label lbl_donnerstag;
        private System.Windows.Forms.Label lbl_samstag;
        private System.Windows.Forms.Label lbl_datum;
    }
}