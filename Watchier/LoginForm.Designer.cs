namespace Watchier
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textbox_password = new System.Windows.Forms.MaskedTextBox();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_loginstatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_close_login = new System.Windows.Forms.Button();
            this.button_encrypt = new System.Windows.Forms.Button();
            this.textbox_userCreate = new System.Windows.Forms.TextBox();
            this.textbox_passwordCreate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(82, 79);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(130, 22);
            this.textbox_password.TabIndex = 2;
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(82, 38);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(130, 22);
            this.textbox_username.TabIndex = 1;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_login.Location = new System.Drawing.Point(82, 107);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(130, 23);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "Login!";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(79, 22);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(63, 15);
            this.label_username.TabIndex = 17;
            this.label_username.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Password:";
            // 
            // label_loginstatus
            // 
            this.label_loginstatus.AutoSize = true;
            this.label_loginstatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginstatus.Location = new System.Drawing.Point(9, 323);
            this.label_loginstatus.Name = "label_loginstatus";
            this.label_loginstatus.Size = new System.Drawing.Size(79, 15);
            this.label_loginstatus.TabIndex = 20;
            this.label_loginstatus.Text = "Please log in..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button_close_login
            // 
            this.button_close_login.BackColor = System.Drawing.Color.Gainsboro;
            this.button_close_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close_login.BackgroundImage")));
            this.button_close_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close_login.FlatAppearance.BorderSize = 0;
            this.button_close_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button_close_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_close_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_login.Location = new System.Drawing.Point(292, -1);
            this.button_close_login.Name = "button_close_login";
            this.button_close_login.Size = new System.Drawing.Size(25, 23);
            this.button_close_login.TabIndex = 22;
            this.button_close_login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_close_login.UseVisualStyleBackColor = false;
            this.button_close_login.Click += new System.EventHandler(this.button_close_login_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_encrypt.FlatAppearance.BorderSize = 0;
            this.button_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_encrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_encrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_encrypt.Location = new System.Drawing.Point(82, 136);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(130, 23);
            this.button_encrypt.TabIndex = 4;
            this.button_encrypt.Text = "Register!";
            this.button_encrypt.UseVisualStyleBackColor = false;
            this.button_encrypt.Click += new System.EventHandler(this.button_encrypt_Click);
            // 
            // textbox_userCreate
            // 
            this.textbox_userCreate.Location = new System.Drawing.Point(15, 370);
            this.textbox_userCreate.Name = "textbox_userCreate";
            this.textbox_userCreate.Size = new System.Drawing.Size(36, 22);
            this.textbox_userCreate.TabIndex = 25;
            this.textbox_userCreate.Visible = false;
            // 
            // textbox_passwordCreate
            // 
            this.textbox_passwordCreate.Location = new System.Drawing.Point(15, 408);
            this.textbox_passwordCreate.Name = "textbox_passwordCreate";
            this.textbox_passwordCreate.Size = new System.Drawing.Size(36, 22);
            this.textbox_passwordCreate.TabIndex = 26;
            this.textbox_passwordCreate.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_encrypt);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.textbox_password);
            this.panel1.Controls.Add(this.textbox_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 199);
            this.panel1.TabIndex = 27;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(316, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textbox_passwordCreate);
            this.Controls.Add(this.textbox_userCreate);
            this.Controls.Add(this.button_close_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_loginstatus);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login to Watchier";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.Move += new System.EventHandler(this.LoginForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_loginstatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_close_login;
        private System.Windows.Forms.Button button_encrypt;
        private System.Windows.Forms.TextBox textbox_userCreate;
        private System.Windows.Forms.TextBox textbox_passwordCreate;
        private System.Windows.Forms.Panel panel1;
    }
}