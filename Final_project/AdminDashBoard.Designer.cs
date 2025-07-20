
namespace Final_project
{
    partial class AdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            this.header_panel = new System.Windows.Forms.Panel();
            this.Adashtitle_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.side_panel = new System.Windows.Forms.Panel();
            this.AdminDashBoard_pictureBox = new System.Windows.Forms.PictureBox();
            this.manageBranch_button = new System.Windows.Forms.Button();
            this.req_button = new System.Windows.Forms.Button();
            this.manageuser_button = new System.Windows.Forms.Button();
            this.checkpay_button = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.side_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminDashBoard_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.header_panel.Controls.Add(this.Adashtitle_label);
            this.header_panel.Controls.Add(this.pictureBox1);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1426, 119);
            this.header_panel.TabIndex = 14;
            // 
            // Adashtitle_label
            // 
            this.Adashtitle_label.AutoSize = true;
            this.Adashtitle_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.Adashtitle_label.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adashtitle_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Adashtitle_label.Location = new System.Drawing.Point(533, 28);
            this.Adashtitle_label.Name = "Adashtitle_label";
            this.Adashtitle_label.Size = new System.Drawing.Size(447, 47);
            this.Adashtitle_label.TabIndex = 0;
            this.Adashtitle_label.Text = "ADMIN DASHBOARD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.side_panel.Controls.Add(this.button1);
            this.side_panel.Controls.Add(this.AdminDashBoard_pictureBox);
            this.side_panel.Controls.Add(this.manageBranch_button);
            this.side_panel.Controls.Add(this.req_button);
            this.side_panel.Controls.Add(this.manageuser_button);
            this.side_panel.Controls.Add(this.checkpay_button);
            this.side_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.side_panel.Location = new System.Drawing.Point(0, 119);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(217, 578);
            this.side_panel.TabIndex = 15;
            // 
            // AdminDashBoard_pictureBox
            // 
            this.AdminDashBoard_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("AdminDashBoard_pictureBox.Image")));
            this.AdminDashBoard_pictureBox.Location = new System.Drawing.Point(-3, 0);
            this.AdminDashBoard_pictureBox.Name = "AdminDashBoard_pictureBox";
            this.AdminDashBoard_pictureBox.Size = new System.Drawing.Size(217, 151);
            this.AdminDashBoard_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminDashBoard_pictureBox.TabIndex = 8;
            this.AdminDashBoard_pictureBox.TabStop = false;
            // 
            // manageBranch_button
            // 
            this.manageBranch_button.FlatAppearance.BorderSize = 0;
            this.manageBranch_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBranch_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageBranch_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageBranch_button.Location = new System.Drawing.Point(30, 245);
            this.manageBranch_button.Name = "manageBranch_button";
            this.manageBranch_button.Size = new System.Drawing.Size(130, 82);
            this.manageBranch_button.TabIndex = 3;
            this.manageBranch_button.Text = "Manage Branch ";
            this.manageBranch_button.UseVisualStyleBackColor = true;
            this.manageBranch_button.Click += new System.EventHandler(this.manageBranch_button_Click);
            // 
            // req_button
            // 
            this.req_button.FlatAppearance.BorderSize = 0;
            this.req_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.req_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.req_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.req_button.Location = new System.Drawing.Point(30, 451);
            this.req_button.Name = "req_button";
            this.req_button.Size = new System.Drawing.Size(130, 60);
            this.req_button.TabIndex = 1;
            this.req_button.Text = "Worker Salary";
            this.req_button.UseVisualStyleBackColor = true;
            this.req_button.Click += new System.EventHandler(this.req_button_Click_1);
            // 
            // manageuser_button
            // 
            this.manageuser_button.FlatAppearance.BorderSize = 0;
            this.manageuser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageuser_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageuser_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageuser_button.Location = new System.Drawing.Point(30, 177);
            this.manageuser_button.Name = "manageuser_button";
            this.manageuser_button.Size = new System.Drawing.Size(130, 45);
            this.manageuser_button.TabIndex = 2;
            this.manageuser_button.Text = "Control";
            this.manageuser_button.UseVisualStyleBackColor = true;
            this.manageuser_button.Click += new System.EventHandler(this.manageuser_button_Click_1);
            // 
            // checkpay_button
            // 
            this.checkpay_button.FlatAppearance.BorderSize = 0;
            this.checkpay_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkpay_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkpay_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkpay_button.Location = new System.Drawing.Point(30, 351);
            this.checkpay_button.Name = "checkpay_button";
            this.checkpay_button.Size = new System.Drawing.Size(130, 67);
            this.checkpay_button.TabIndex = 4;
            this.checkpay_button.Text = "Check Report";
            this.checkpay_button.UseVisualStyleBackColor = true;
            this.checkpay_button.Click += new System.EventHandler(this.checkpay_button_Click_1);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(217, 119);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1209, 578);
            this.mainpanel.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(30, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 697);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.side_panel);
            this.Controls.Add(this.header_panel);
            this.Name = "AdminDashBoard";
            this.Text = "AdminDashBoard";
            this.Load += new System.EventHandler(this.AdminDashBoard_Load);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.side_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminDashBoard_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label Adashtitle_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel side_panel;
        private System.Windows.Forms.PictureBox AdminDashBoard_pictureBox;
        private System.Windows.Forms.Button manageBranch_button;
        private System.Windows.Forms.Button req_button;
        private System.Windows.Forms.Button manageuser_button;
        private System.Windows.Forms.Button checkpay_button;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button button1;
    }
}