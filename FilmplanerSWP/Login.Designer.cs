
namespace FilmplanerSWP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pB_addUser = new System.Windows.Forms.PictureBox();
            this.pB_Login = new System.Windows.Forms.PictureBox();
            this.cB_passwordChar = new System.Windows.Forms.CheckBox();
            this.tB_login_password = new System.Windows.Forms.TextBox();
            this.tB_login_name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_addUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::FilmplanerSWP.Properties.Resources.Login;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pB_addUser);
            this.panel1.Controls.Add(this.pB_Login);
            this.panel1.Controls.Add(this.cB_passwordChar);
            this.panel1.Controls.Add(this.tB_login_password);
            this.panel1.Controls.Add(this.tB_login_name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 572);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pB_addUser
            // 
            this.pB_addUser.BackColor = System.Drawing.Color.Transparent;
            this.pB_addUser.Location = new System.Drawing.Point(251, 493);
            this.pB_addUser.Name = "pB_addUser";
            this.pB_addUser.Size = new System.Drawing.Size(214, 25);
            this.pB_addUser.TabIndex = 5;
            this.pB_addUser.TabStop = false;
            this.pB_addUser.Click += new System.EventHandler(this.pB_addUser_Click);
            // 
            // pB_Login
            // 
            this.pB_Login.BackColor = System.Drawing.Color.Transparent;
            this.pB_Login.Location = new System.Drawing.Point(32, 400);
            this.pB_Login.Name = "pB_Login";
            this.pB_Login.Size = new System.Drawing.Size(433, 57);
            this.pB_Login.TabIndex = 4;
            this.pB_Login.TabStop = false;
            this.pB_Login.Click += new System.EventHandler(this.pB_Login_Click);
            // 
            // cB_passwordChar
            // 
            this.cB_passwordChar.AutoSize = true;
            this.cB_passwordChar.Location = new System.Drawing.Point(45, 356);
            this.cB_passwordChar.Name = "cB_passwordChar";
            this.cB_passwordChar.Size = new System.Drawing.Size(15, 14);
            this.cB_passwordChar.TabIndex = 3;
            this.cB_passwordChar.UseVisualStyleBackColor = true;
            this.cB_passwordChar.CheckedChanged += new System.EventHandler(this.cB_passwordChar_CheckedChanged);
            // 
            // tB_login_password
            // 
            this.tB_login_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_login_password.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_login_password.Location = new System.Drawing.Point(26, 268);
            this.tB_login_password.Multiline = true;
            this.tB_login_password.Name = "tB_login_password";
            this.tB_login_password.Size = new System.Drawing.Size(422, 43);
            this.tB_login_password.TabIndex = 2;
            this.tB_login_password.TextChanged += new System.EventHandler(this.tB_login_password_TextChanged);
            this.tB_login_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_login_password_KeyDown);
            // 
            // tB_login_name
            // 
            this.tB_login_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_login_name.Font = new System.Drawing.Font("Lucida Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_login_name.Location = new System.Drawing.Point(26, 128);
            this.tB_login_name.Multiline = true;
            this.tB_login_name.Name = "tB_login_name";
            this.tB_login_name.Size = new System.Drawing.Size(422, 41);
            this.tB_login_name.TabIndex = 1;
            this.tB_login_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_login_name_KeyDown);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(477, 569);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_addUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tB_login_name;
        private System.Windows.Forms.TextBox tB_login_password;
        private System.Windows.Forms.CheckBox cB_passwordChar;
        private System.Windows.Forms.PictureBox pB_Login;
        private System.Windows.Forms.PictureBox pB_addUser;
        private System.Windows.Forms.Panel panel1;
    }
}