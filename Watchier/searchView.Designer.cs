namespace Watchier
{
    partial class searchView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchView));
            this.combobox_search = new System.Windows.Forms.ComboBox();
            this.label_search = new System.Windows.Forms.Label();
            this.picturebox_search = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_rateNow = new System.Windows.Forms.LinkLabel();
            this.button_addToList = new System.Windows.Forms.Button();
            this.textbox_rating = new System.Windows.Forms.TextBox();
            this.textbox_votes = new System.Windows.Forms.TextBox();
            this.textbox_id = new System.Windows.Forms.TextBox();
            this.textbox_titel = new System.Windows.Forms.TextBox();
            this.textbox_desc = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_search)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // combobox_search
            // 
            this.combobox_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combobox_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.combobox_search.BackColor = System.Drawing.SystemColors.Window;
            this.combobox_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combobox_search.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_search.FormattingEnabled = true;
            this.combobox_search.Location = new System.Drawing.Point(72, 25);
            this.combobox_search.Name = "combobox_search";
            this.combobox_search.Size = new System.Drawing.Size(277, 21);
            this.combobox_search.TabIndex = 1;
            this.combobox_search.SelectedIndexChanged += new System.EventHandler(this.combobox_search_SelectedIndexChanged);
            this.combobox_search.TextUpdate += new System.EventHandler(this.combobox_search_TextUpdate);
            this.combobox_search.DataSourceChanged += new System.EventHandler(this.combobox_search_DataSourceChanged);
            this.combobox_search.SelectedValueChanged += new System.EventHandler(this.combobox_search_SelectedValueChanged);
            this.combobox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.combobox_search_KeyDown);
            this.combobox_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.combobox_search_KeyUp);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_search.Location = new System.Drawing.Point(17, 28);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(40, 13);
            this.label_search.TabIndex = 2;
            this.label_search.Text = "Search";
            // 
            // picturebox_search
            // 
            this.picturebox_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.picturebox_search.Image = ((System.Drawing.Image)(resources.GetObject("picturebox_search.Image")));
            this.picturebox_search.InitialImage = ((System.Drawing.Image)(resources.GetObject("picturebox_search.InitialImage")));
            this.picturebox_search.Location = new System.Drawing.Point(587, 0);
            this.picturebox_search.Margin = new System.Windows.Forms.Padding(0);
            this.picturebox_search.Name = "picturebox_search";
            this.picturebox_search.Size = new System.Drawing.Size(312, 507);
            this.picturebox_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picturebox_search.TabIndex = 3;
            this.picturebox_search.TabStop = false;
            this.picturebox_search.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titel";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(17, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Views";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rating";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(17, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(17, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            this.label5.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_rateNow);
            this.panel1.Controls.Add(this.button_addToList);
            this.panel1.Controls.Add(this.textbox_rating);
            this.panel1.Controls.Add(this.textbox_votes);
            this.panel1.Controls.Add(this.textbox_id);
            this.panel1.Controls.Add(this.textbox_titel);
            this.panel1.Controls.Add(this.textbox_desc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 438);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_rateNow
            // 
            this.label_rateNow.AutoSize = true;
            this.label_rateNow.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rateNow.Location = new System.Drawing.Point(366, 88);
            this.label_rateNow.Name = "label_rateNow";
            this.label_rateNow.Size = new System.Drawing.Size(59, 13);
            this.label_rateNow.TabIndex = 15;
            this.label_rateNow.TabStop = true;
            this.label_rateNow.Text = "Rate now!";
            this.label_rateNow.Visible = false;
            // 
            // button_addToList
            // 
            this.button_addToList.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_addToList.FlatAppearance.BorderSize = 0;
            this.button_addToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addToList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addToList.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_addToList.Location = new System.Drawing.Point(20, 268);
            this.button_addToList.Name = "button_addToList";
            this.button_addToList.Size = new System.Drawing.Size(133, 23);
            this.button_addToList.TabIndex = 14;
            this.button_addToList.Text = "Add to my List";
            this.button_addToList.UseVisualStyleBackColor = false;
            this.button_addToList.Visible = false;
            this.button_addToList.Click += new System.EventHandler(this.button_addToList_Click);
            // 
            // textbox_rating
            // 
            this.textbox_rating.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textbox_rating.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_rating.Enabled = false;
            this.textbox_rating.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_rating.Location = new System.Drawing.Point(72, 88);
            this.textbox_rating.Name = "textbox_rating";
            this.textbox_rating.ReadOnly = true;
            this.textbox_rating.Size = new System.Drawing.Size(277, 15);
            this.textbox_rating.TabIndex = 13;
            this.textbox_rating.Visible = false;
            // 
            // textbox_votes
            // 
            this.textbox_votes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textbox_votes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_votes.Enabled = false;
            this.textbox_votes.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_votes.Location = new System.Drawing.Point(72, 64);
            this.textbox_votes.Name = "textbox_votes";
            this.textbox_votes.ReadOnly = true;
            this.textbox_votes.Size = new System.Drawing.Size(277, 15);
            this.textbox_votes.TabIndex = 12;
            this.textbox_votes.Visible = false;
            // 
            // textbox_id
            // 
            this.textbox_id.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textbox_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_id.Enabled = false;
            this.textbox_id.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_id.Location = new System.Drawing.Point(72, 40);
            this.textbox_id.Name = "textbox_id";
            this.textbox_id.ReadOnly = true;
            this.textbox_id.Size = new System.Drawing.Size(277, 15);
            this.textbox_id.TabIndex = 11;
            this.textbox_id.Visible = false;
            // 
            // textbox_titel
            // 
            this.textbox_titel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textbox_titel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_titel.Enabled = false;
            this.textbox_titel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_titel.Location = new System.Drawing.Point(72, 16);
            this.textbox_titel.Name = "textbox_titel";
            this.textbox_titel.ReadOnly = true;
            this.textbox_titel.Size = new System.Drawing.Size(277, 15);
            this.textbox_titel.TabIndex = 10;
            this.textbox_titel.Visible = false;
            // 
            // textbox_desc
            // 
            this.textbox_desc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textbox_desc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_desc.Enabled = false;
            this.textbox_desc.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_desc.Location = new System.Drawing.Point(20, 136);
            this.textbox_desc.Margin = new System.Windows.Forms.Padding(0);
            this.textbox_desc.Name = "textbox_desc";
            this.textbox_desc.ReadOnly = true;
            this.textbox_desc.RightMargin = 315;
            this.textbox_desc.Size = new System.Drawing.Size(329, 125);
            this.textbox_desc.TabIndex = 9;
            this.textbox_desc.Text = "";
            this.textbox_desc.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.combobox_search);
            this.panel2.Controls.Add(this.label_search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 63);
            this.panel2.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picturebox_search);
            this.Name = "searchView";
            this.Size = new System.Drawing.Size(899, 507);
            ((System.ComponentModel.ISupportInitialize)(this.picturebox_search)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_search;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.PictureBox picturebox_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox textbox_desc;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textbox_rating;
        private System.Windows.Forms.TextBox textbox_votes;
        private System.Windows.Forms.TextBox textbox_id;
        private System.Windows.Forms.TextBox textbox_titel;
        private System.Windows.Forms.Button button_addToList;
        private System.Windows.Forms.LinkLabel label_rateNow;
    }
}
