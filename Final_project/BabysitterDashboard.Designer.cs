
namespace Final_project
{
    partial class BabysitterDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BabysitterDashboard));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.Cinfo_button = new System.Windows.Forms.Button();
            this.certificate_button = new System.Windows.Forms.Button();
            this.job_button = new System.Windows.Forms.Button();
            this.headderpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TITLE_label = new System.Windows.Forms.Label();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.back_pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sidepanel.SuspendLayout();
            this.headderpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.sidepanel.Controls.Add(this.button1);
            this.sidepanel.Controls.Add(this.Cinfo_button);
            this.sidepanel.Controls.Add(this.certificate_button);
            this.sidepanel.Controls.Add(this.job_button);
            this.sidepanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidepanel.Location = new System.Drawing.Point(0, 99);
            this.sidepanel.Name = "sidepanel";
            this.sidepanel.Size = new System.Drawing.Size(179, 549);
            this.sidepanel.TabIndex = 0;
            // 
            // Cinfo_button
            // 
            this.Cinfo_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.Cinfo_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cinfo_button.FlatAppearance.BorderSize = 0;
            this.Cinfo_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cinfo_button.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cinfo_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cinfo_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cinfo_button.Location = new System.Drawing.Point(3, 374);
            this.Cinfo_button.Name = "Cinfo_button";
            this.Cinfo_button.Size = new System.Drawing.Size(163, 41);
            this.Cinfo_button.TabIndex = 2;
            this.Cinfo_button.Text = "View Child Info";
            this.Cinfo_button.UseVisualStyleBackColor = false;
            this.Cinfo_button.Click += new System.EventHandler(this.Cinfo_button_Click);
            // 
            // certificate_button
            // 
            this.certificate_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.certificate_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.certificate_button.FlatAppearance.BorderSize = 0;
            this.certificate_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.certificate_button.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certificate_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.certificate_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.certificate_button.Location = new System.Drawing.Point(0, 296);
            this.certificate_button.Name = "certificate_button";
            this.certificate_button.Size = new System.Drawing.Size(163, 41);
            this.certificate_button.TabIndex = 1;
            this.certificate_button.Text = "Add Certificate";
            this.certificate_button.UseVisualStyleBackColor = false;
            this.certificate_button.Click += new System.EventHandler(this.certificate_button_Click);
            // 
            // job_button
            // 
            this.job_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.job_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.job_button.FlatAppearance.BorderSize = 0;
            this.job_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.job_button.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.job_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.job_button.Location = new System.Drawing.Point(0, 200);
            this.job_button.Name = "job_button";
            this.job_button.Size = new System.Drawing.Size(163, 41);
            this.job_button.TabIndex = 0;
            this.job_button.Text = "Manage Profile";
            this.job_button.UseVisualStyleBackColor = false;
            this.job_button.Click += new System.EventHandler(this.job_button_Click);
            // 
            // headderpanel
            // 
            this.headderpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.headderpanel.Controls.Add(this.pictureBox1);
            this.headderpanel.Controls.Add(this.TITLE_label);
            this.headderpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headderpanel.Location = new System.Drawing.Point(0, 0);
            this.headderpanel.Name = "headderpanel";
            this.headderpanel.Size = new System.Drawing.Size(1073, 99);
            this.headderpanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // TITLE_label
            // 
            this.TITLE_label.AutoSize = true;
            this.TITLE_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.TITLE_label.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TITLE_label.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TITLE_label.Location = new System.Drawing.Point(290, 18);
            this.TITLE_label.Name = "TITLE_label";
            this.TITLE_label.Size = new System.Drawing.Size(578, 47);
            this.TITLE_label.TabIndex = 0;
            this.TITLE_label.Text = "BABYSITTER DASHBOARD";
            this.TITLE_label.Click += new System.EventHandler(this.TITLE_label_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.mainpanel.Controls.Add(this.back_pictureBox);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1073, 648);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
            // 
            // back_pictureBox
            // 
            this.back_pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.back_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("back_pictureBox.Image")));
            this.back_pictureBox.Location = new System.Drawing.Point(1014, 588);
            this.back_pictureBox.Name = "back_pictureBox";
            this.back_pictureBox.Size = new System.Drawing.Size(47, 48);
            this.back_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_pictureBox.TabIndex = 17;
            this.back_pictureBox.TabStop = false;
            this.back_pictureBox.Click += new System.EventHandler(this.back_pictureBox_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(153)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Additional Information";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BabysitterDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1073, 648);
            this.Controls.Add(this.sidepanel);
            this.Controls.Add(this.headderpanel);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BabysitterDashboard";
            this.Text = "BabysitterDashboard";
            this.sidepanel.ResumeLayout(false);
            this.headderpanel.ResumeLayout(false);
            this.headderpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel headderpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button job_button;
        private System.Windows.Forms.Button Cinfo_button;
        private System.Windows.Forms.Button certificate_button;
        private System.Windows.Forms.Label TITLE_label;
        private System.Windows.Forms.PictureBox back_pictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}