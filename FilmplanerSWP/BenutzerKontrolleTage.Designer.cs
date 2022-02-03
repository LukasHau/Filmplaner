
namespace FilmplanerSWP
{
    partial class BenutzerKontrolleTage
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_days = new System.Windows.Forms.Label();
            this.lbl_event = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_days
            // 
            this.lbl_days.AutoSize = true;
            this.lbl_days.BackColor = System.Drawing.Color.Transparent;
            this.lbl_days.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_days.Location = new System.Drawing.Point(42, 33);
            this.lbl_days.Name = "lbl_days";
            this.lbl_days.Size = new System.Drawing.Size(23, 19);
            this.lbl_days.TabIndex = 0;
            this.lbl_days.Text = "00";
            this.lbl_days.Click += new System.EventHandler(this.lbl_days_Click);
            // 
            // lbl_event
            // 
            this.lbl_event.BackColor = System.Drawing.Color.Transparent;
            this.lbl_event.Location = new System.Drawing.Point(3, 52);
            this.lbl_event.Name = "lbl_event";
            this.lbl_event.Size = new System.Drawing.Size(101, 34);
            this.lbl_event.TabIndex = 1;
            this.lbl_event.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_event.Click += new System.EventHandler(this.lbl_event_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BenutzerKontrolleTage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_event);
            this.Controls.Add(this.lbl_days);
            this.Name = "BenutzerKontrolleTage";
            this.Size = new System.Drawing.Size(107, 86);
            this.Load += new System.EventHandler(this.BenutzerKontrolleTage_Load);
            this.Click += new System.EventHandler(this.BenutzerKontrolleTage_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_days;
        private System.Windows.Forms.Label lbl_event;
        private System.Windows.Forms.Timer timer1;
    }
}
