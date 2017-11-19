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
            this.components = new System.ComponentModel.Container();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textbox_test = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_logout = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_email = new System.Windows.Forms.Label();
            this.label_userCreate = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.textbox_emailCreate = new System.Windows.Forms.TextBox();
            this.textbox_passwordCreate = new System.Windows.Forms.TextBox();
            this.textbox_userCreate = new System.Windows.Forms.TextBox();
            this.label_password2 = new System.Windows.Forms.Label();
            this.textbox_passwordCreate2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_password
            // 
            this.textbox_password.Location = new System.Drawing.Point(57, 111);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(130, 22);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.Text = "Penis12";
            this.textbox_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_password_KeyDown);
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(57, 60);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(130, 22);
            this.textbox_username.TabIndex = 1;
            this.textbox_username.Text = "adm";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.button_login.FlatAppearance.BorderSize = 0;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_login.Location = new System.Drawing.Point(57, 174);
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
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_username.Location = new System.Drawing.Point(54, 44);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(63, 15);
            this.label_username.TabIndex = 17;
            this.label_username.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(54, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Password:";
            // 
            // label_loginstatus
            // 
            this.label_loginstatus.AutoSize = true;
            this.label_loginstatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loginstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_loginstatus.Location = new System.Drawing.Point(12, 309);
            this.label_loginstatus.Name = "label_loginstatus";
            this.label_loginstatus.Size = new System.Drawing.Size(79, 15);
            this.label_loginstatus.TabIndex = 20;
            this.label_loginstatus.Text = "Please log in..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(364, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button_close_login
            // 
            this.button_close_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_close_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_close_login.BackgroundImage")));
            this.button_close_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_close_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_close_login.FlatAppearance.BorderSize = 0;
            this.button_close_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_close_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_close_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button_close_login.Location = new System.Drawing.Point(473, 0);
            this.button_close_login.Name = "button_close_login";
            this.button_close_login.Size = new System.Drawing.Size(25, 23);
            this.button_close_login.TabIndex = 22;
            this.button_close_login.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_close_login.UseVisualStyleBackColor = false;
            this.button_close_login.Click += new System.EventHandler(this.button_close_login_Click);
            // 
            // button_encrypt
            // 
            this.button_encrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.button_encrypt.FlatAppearance.BorderSize = 0;
            this.button_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_encrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_encrypt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_encrypt.Location = new System.Drawing.Point(64, 176);
            this.button_encrypt.Name = "button_encrypt";
            this.button_encrypt.Size = new System.Drawing.Size(120, 23);
            this.button_encrypt.TabIndex = 4;
            this.button_encrypt.Text = "Sign up!";
            this.button_encrypt.UseVisualStyleBackColor = false;
            this.button_encrypt.Click += new System.EventHandler(this.button_register_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.textbox_test);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label_logout);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button_login);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.textbox_password);
            this.panel1.Controls.Add(this.label_loginstatus);
            this.panel1.Controls.Add(this.textbox_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 333);
            this.panel1.TabIndex = 27;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // textbox_test
            // 
            this.textbox_test.Location = new System.Drawing.Point(20, 256);
            this.textbox_test.Name = "textbox_test";
            this.textbox_test.Size = new System.Drawing.Size(100, 22);
            this.textbox_test.TabIndex = 24;
            this.textbox_test.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_logout.Location = new System.Drawing.Point(73, 200);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(98, 13);
            this.label_logout.TabIndex = 22;
            this.label_logout.TabStop = true;
            this.label_logout.Text = "forgot password?";
            this.label_logout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(57, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Remember me!";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label2.Location = new System.Drawing.Point(-218, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(904, 2);
            this.label2.TabIndex = 19;
            this.label2.Text = "label2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 109);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(117)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.splitContainer1.Panel2.Controls.Add(this.label_email);
            this.splitContainer1.Panel2.Controls.Add(this.label_userCreate);
            this.splitContainer1.Panel2.Controls.Add(this.label_password);
            this.splitContainer1.Panel2.Controls.Add(this.button_register);
            this.splitContainer1.Panel2.Controls.Add(this.textbox_emailCreate);
            this.splitContainer1.Panel2.Controls.Add(this.textbox_passwordCreate);
            this.splitContainer1.Panel2.Controls.Add(this.textbox_userCreate);
            this.splitContainer1.Panel2.Controls.Add(this.label_password2);
            this.splitContainer1.Panel2.Controls.Add(this.textbox_passwordCreate2);
            this.splitContainer1.Panel2.Controls.Add(this.button_encrypt);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(498, 333);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 28;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_email.Location = new System.Drawing.Point(61, 167);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(44, 15);
            this.label_email.TabIndex = 48;
            this.label_email.Text = "E-Mail:";
            this.label_email.Visible = false;
            // 
            // label_userCreate
            // 
            this.label_userCreate.AutoSize = true;
            this.label_userCreate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_userCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_userCreate.Location = new System.Drawing.Point(61, 42);
            this.label_userCreate.Name = "label_userCreate";
            this.label_userCreate.Size = new System.Drawing.Size(63, 15);
            this.label_userCreate.TabIndex = 46;
            this.label_userCreate.Text = "Username:";
            this.label_userCreate.Visible = false;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_password.Location = new System.Drawing.Point(61, 83);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(60, 15);
            this.label_password.TabIndex = 47;
            this.label_password.Text = "Password:";
            this.label_password.Visible = false;
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_register.Location = new System.Drawing.Point(64, 224);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(120, 23);
            this.button_register.TabIndex = 45;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Visible = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click_1);
            // 
            // textbox_emailCreate
            // 
            this.textbox_emailCreate.Location = new System.Drawing.Point(64, 185);
            this.textbox_emailCreate.Name = "textbox_emailCreate";
            this.textbox_emailCreate.Size = new System.Drawing.Size(120, 22);
            this.textbox_emailCreate.TabIndex = 44;
            this.textbox_emailCreate.Visible = false;
            this.textbox_emailCreate.Leave += new System.EventHandler(this.textbox_emailCreate_Leave);
            // 
            // textbox_passwordCreate
            // 
            this.textbox_passwordCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_passwordCreate.Location = new System.Drawing.Point(64, 101);
            this.textbox_passwordCreate.Name = "textbox_passwordCreate";
            this.textbox_passwordCreate.Size = new System.Drawing.Size(120, 22);
            this.textbox_passwordCreate.TabIndex = 43;
            this.textbox_passwordCreate.Visible = false;
            this.textbox_passwordCreate.Leave += new System.EventHandler(this.textbox_passwordCreate_Leave);
            // 
            // textbox_userCreate
            // 
            this.textbox_userCreate.Location = new System.Drawing.Point(64, 60);
            this.textbox_userCreate.Name = "textbox_userCreate";
            this.textbox_userCreate.Size = new System.Drawing.Size(120, 22);
            this.textbox_userCreate.TabIndex = 42;
            this.textbox_userCreate.Visible = false;
            this.textbox_userCreate.Leave += new System.EventHandler(this.textbox_userCreate_Leave);
            // 
            // label_password2
            // 
            this.label_password2.AutoSize = true;
            this.label_password2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_password2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_password2.Location = new System.Drawing.Point(61, 124);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(99, 15);
            this.label_password2.TabIndex = 52;
            this.label_password2.Text = "Repeat Password:";
            this.label_password2.Visible = false;
            // 
            // textbox_passwordCreate2
            // 
            this.textbox_passwordCreate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_passwordCreate2.Location = new System.Drawing.Point(64, 142);
            this.textbox_passwordCreate2.Name = "textbox_passwordCreate2";
            this.textbox_passwordCreate2.Size = new System.Drawing.Size(120, 22);
            this.textbox_passwordCreate2.TabIndex = 51;
            this.textbox_passwordCreate2.Visible = false;
            this.textbox_passwordCreate2.Leave += new System.EventHandler(this.textbox_passwordCreate2_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label3.Location = new System.Drawing.Point(5, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "or register!";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button_close_login);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 110);
            this.panel2.TabIndex = 29;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(498, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login to Watchier";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            this.Move += new System.EventHandler(this.LoginForm_Move);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel label_logout;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_userCreate;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textbox_emailCreate;
        private System.Windows.Forms.TextBox textbox_passwordCreate;
        private System.Windows.Forms.TextBox textbox_userCreate;
        private System.Windows.Forms.Label label_password2;
        private System.Windows.Forms.TextBox textbox_passwordCreate2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textbox_test;
    }
}