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
            this.label_username = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_main = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar_main = new System.Windows.Forms.ToolStripProgressBar();
            this.userWindow1 = new Watchier.userWindow();
            this.listWindow1 = new Watchier.listWindow();
            this.searchView1 = new Watchier.searchView();
            this.panel_side.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel_side.Controls.Add(this.button_settings);
            this.panel_side.Controls.Add(this.button_list);
            this.panel_side.Controls.Add(this.button_search);
            this.panel_side.Controls.Add(this.button_logo);
            this.panel_side.Controls.Add(this.button_user);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 0);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(97, 469);
            this.panel_side.TabIndex = 0;
            // 
            // button_settings
            // 
            this.button_settings.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_settings.BackgroundImage")));
            this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_settings.FlatAppearance.BorderSize = 0;
            this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_settings.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_settings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_settings.Location = new System.Drawing.Point(0, 366);
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
            this.button_list.Location = new System.Drawing.Point(0, 272);
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
            this.button_search.Location = new System.Drawing.Point(0, 178);
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
            this.button_user.Location = new System.Drawing.Point(0, 86);
            this.button_user.Name = "button_user";
            this.button_user.Size = new System.Drawing.Size(97, 88);
            this.button_user.TabIndex = 0;
            this.button_user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_user.UseVisualStyleBackColor = true;
            this.button_user.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_header.Controls.Add(this.label_username);
            this.panel_header.Controls.Add(this.button1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(97, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(646, 86);
            this.panel_header.TabIndex = 1;
            this.panel_header.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_header_Paint);
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            this.panel_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(6, 8);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(70, 13);
            this.label_username.TabIndex = 4;
            this.label_username.Text = "Hallo Guest!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(618, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 3;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_main.Controls.Add(this.statusStrip1);
            this.panel_main.Controls.Add(this.userWindow1);
            this.panel_main.Controls.Add(this.listWindow1);
            this.panel_main.Controls.Add(this.searchView1);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(97, 86);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(646, 383);
            this.panel_main.TabIndex = 2;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.progressbar_main});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 361);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(646, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel1.Text = "Idle..";
            // 
            // progressbar_main
            // 
            this.progressbar_main.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.progressbar_main.Margin = new System.Windows.Forms.Padding(0, 2, 5, 2);
            this.progressbar_main.Name = "progressbar_main";
            this.progressbar_main.Size = new System.Drawing.Size(200, 18);
            this.progressbar_main.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressbar_main.Visible = false;
            // 
            // userWindow1
            // 
            this.userWindow1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.userWindow1.Location = new System.Drawing.Point(0, 0);
            this.userWindow1.Name = "userWindow1";
            this.userWindow1.Size = new System.Drawing.Size(646, 360);
            this.userWindow1.TabIndex = 2;
            this.userWindow1.Load += new System.EventHandler(this.userWindow1_Load);
            // 
            // listWindow1
            // 
            this.listWindow1.Location = new System.Drawing.Point(0, 0);
            this.listWindow1.Name = "listWindow1";
            this.listWindow1.Size = new System.Drawing.Size(646, 360);
            this.listWindow1.TabIndex = 1;
            this.listWindow1.Load += new System.EventHandler(this.listWindow1_Load);
            // 
            // searchView1
            // 
            this.searchView1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.searchView1.Location = new System.Drawing.Point(0, 0);
            this.searchView1.Name = "searchView1";
            this.searchView1.Size = new System.Drawing.Size(646, 360);
            this.searchView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 469);
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
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar progressbar_main;
        private System.Windows.Forms.Label label_username;
    }
}

