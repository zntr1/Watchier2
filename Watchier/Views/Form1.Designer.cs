namespace Watchier
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_side = new System.Windows.Forms.Panel();
            this.button_settings = new System.Windows.Forms.Button();
            this.button_list = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_logo = new System.Windows.Forms.Button();
            this.button_user = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_username = new System.Windows.Forms.Label();
            this.picturebox_header = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.searchView1 = new Watchier.searchView();
            this.userWindow1 = new Watchier.userWindow();
            this.listWindow1 = new Watchier.listWindow();
            this.label_logout = new System.Windows.Forms.LinkLabel();
            this.panel_side.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_header)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.panel_side.Controls.Add(this.button_settings);
            this.panel_side.Controls.Add(this.button_list);
            this.panel_side.Controls.Add(this.button_search);
            this.panel_side.Controls.Add(this.button_logo);
            this.panel_side.Controls.Add(this.button_user);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(97, 593);
            this.panel_side.TabIndex = 0;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.button_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_settings.BackgroundImage")));
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_settings.Location = new System.Drawing.Point(0, 407);
            this.button_settings.Name = "button_settings";
            this.button_settings.Size = new System.Drawing.Size(97, 89);
            this.button_settings.TabIndex = 4;
            this.button_settings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_settings.UseVisualStyleBackColor = false;
            // 
            // button_list
            // 
            this.button_list.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_list.BackgroundImage")));
            this.button_list.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_list.FlatAppearance.BorderSize = 0;
            this.button_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_list.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_list.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_list.Location = new System.Drawing.Point(0, 313);
            this.button_list.Name = "button_list";
            this.button_list.Size = new System.Drawing.Size(97, 88);
            this.button_list.TabIndex = 3;
            this.button_list.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_list.UseVisualStyleBackColor = true;
            this.button_list.Click += new System.EventHandler(this.button_list_Click);
            // 
            // button_search
            // 
            this.button_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_search.BackgroundImage")));
            this.button_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_search.FlatAppearance.BorderSize = 0;
            this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_search.Location = new System.Drawing.Point(0, 219);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(97, 88);
            this.button_search.TabIndex = 2;
            this.button_search.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_logo
            // 
            this.button_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_logo.FlatAppearance.BorderSize = 0;
            this.button_logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logo.Location = new System.Drawing.Point(0, -2);
            this.button_logo.Name = "button_logo";
            this.button_logo.Size = new System.Drawing.Size(97, 88);
            this.button_logo.TabIndex = 1;
            this.button_logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_logo.UseVisualStyleBackColor = true;
            // 
            // button_user
            // 
            this.button_user.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_user.BackgroundImage")));
            this.button_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_user.FlatAppearance.BorderSize = 0;
            this.button_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_user.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_user.Location = new System.Drawing.Point(0, 127);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(97, 88);
            this.button_user.TabIndex = 0;
            this.button_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_header.Controls.Add(this.label_logout);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Controls.Add(this.button1);
            this.panel_header.Controls.Add(this.label_username);
            this.panel_header.Controls.Add(this.picturebox_header);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(97, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(899, 86);
            this.panel_header.TabIndex = 1;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            this.panel_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label1.Location = new System.Drawing.Point(-3, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 2);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(871, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 3;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_username.Location = new System.Drawing.Point(6, 3);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(95, 21);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Hallo Guest!";
            // 
            // picturebox_header
            // 
            this.picturebox_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.picturebox_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturebox_header.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_header.Image")));
            this.picturebox_header.Location = new System.Drawing.Point(0, 0);
            this.picturebox_header.Name = "picturebox_header";
            this.picturebox_header.Size = new System.Drawing.Size(899, 86);
            this.picturebox_header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturebox_header.TabIndex = 5;
            this.picturebox_header.TabStop = false;
            this.picturebox_header.Click += new System.EventHandler(this.picturebox_header_Click);
            this.picturebox_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.picturebox_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            this.picturebox_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.panel_main.Controls.Add(this.searchView1);
            this.panel_main.Controls.Add(this.userWindow1);
            this.panel_main.Controls.Add(this.listWindow1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(97, 86);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(899, 507);
            this.panel_main.TabIndex = 2;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // searchView1
            // 
            this.searchView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.searchView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchView1.Location = new System.Drawing.Point(0, 0);
            this.searchView1.Name = "searchView1";
            this.searchView1.Size = new System.Drawing.Size(899, 507);
            this.searchView1.TabIndex = 0;
            this.searchView1.Load += new System.EventHandler(this.searchView1_Load);
            // 
            // userWindow1
            // 
            this.userWindow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.userWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userWindow1.Location = new System.Drawing.Point(0, 0);
            this.userWindow1.Name = "userWindow1";
            this.userWindow1.Size = new System.Drawing.Size(899, 507);
            this.userWindow1.TabIndex = 2;
            this.userWindow1.Load += new System.EventHandler(this.userWindow1_Load);
            // 
            // listWindow1
            // 
            this.listWindow1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.listWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listWindow1.Location = new System.Drawing.Point(0, 0);
            this.listWindow1.Name = "listWindow1";
            this.listWindow1.Size = new System.Drawing.Size(899, 507);
            this.listWindow1.TabIndex = 1;
            this.listWindow1.Load += new System.EventHandler(this.listWindow1_Load);
            // 
            // label_logout
            // 
            this.label_logout.AutoSize = true;
            this.label_logout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_logout.Location = new System.Drawing.Point(815, 9);
            this.label_logout.Name = "label_logout";
            this.label_logout.Size = new System.Drawing.Size(50, 13);
            this.label_logout.TabIndex = 6;
            this.label_logout.TabStop = true;
            this.label_logout.Text = "Log out!";
            this.label_logout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(129)))), ((int)(((byte)(229)))));
            this.label_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_logout_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(996, 593);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_side);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Watchier";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_side.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_header)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button button_user;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_list;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_logo;
        private System.Windows.Forms.Button button1;
        private searchView searchView1;
        private listWindow listWindow1;
        private System.Windows.Forms.Panel panel_main;
        private userWindow userWindow1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox picturebox_header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel label_logout;
    }
}

