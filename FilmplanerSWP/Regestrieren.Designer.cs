
namespace FilmplanerSWP
{
    partial class Regestrieren
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tB_name = new System.Windows.Forms.TextBox();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.tB_password2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 237);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 34);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Zurück";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(307, 237);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(93, 34);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Regestrieren";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Benutzername:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passwort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Passwort wiederholen:";
            // 
            // tB_name
            // 
            this.tB_name.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.tB_name.Location = new System.Drawing.Point(16, 43);
            this.tB_name.Name = "tB_name";
            this.tB_name.Size = new System.Drawing.Size(364, 27);
            this.tB_name.TabIndex = 5;
            // 
            // tB_password
            // 
            this.tB_password.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.tB_password.Location = new System.Drawing.Point(16, 118);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(364, 27);
            this.tB_password.TabIndex = 6;
            // 
            // tB_password2
            // 
            this.tB_password2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F);
            this.tB_password2.Location = new System.Drawing.Point(16, 193);
            this.tB_password2.Name = "tB_password2";
            this.tB_password2.Size = new System.Drawing.Size(364, 27);
            this.tB_password2.TabIndex = 7;
            // 
            // Regestrieren
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(412, 280);
            this.Controls.Add(this.tB_password2);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.tB_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_back);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Regestrieren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer hinzufügen";
            this.Load += new System.EventHandler(this.Regestrieren_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tB_name;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.TextBox tB_password2;
    }
}