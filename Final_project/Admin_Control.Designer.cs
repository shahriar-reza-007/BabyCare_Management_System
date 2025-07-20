
namespace Final_project
{
    partial class Admin_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Control));
            this.rightpanel = new System.Windows.Forms.Panel();
            this.upperpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.manage_button = new System.Windows.Forms.Button();
            this.parentbutton = new System.Windows.Forms.Button();
            this.back_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rightpanel.SuspendLayout();
            this.upperpanel.SuspendLayout();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rightpanel
            // 
            this.rightpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.rightpanel.Controls.Add(this.back_pictureBox);
            this.rightpanel.Controls.Add(this.parentbutton);
            this.rightpanel.Controls.Add(this.manage_button);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightpanel.Location = new System.Drawing.Point(0, 99);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(196, 567);
            this.rightpanel.TabIndex = 0;
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.upperpanel.Controls.Add(this.label1);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(1373, 99);
            this.upperpanel.TabIndex = 1;
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.pictureBox1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(196, 99);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1177, 567);
            this.mainpanel.TabIndex = 2;
            // 
            // manage_button
            // 
            this.manage_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.manage_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.manage_button.FlatAppearance.BorderSize = 0;
            this.manage_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_button.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manage_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.manage_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manage_button.Location = new System.Drawing.Point(0, 125);
            this.manage_button.Name = "manage_button";
            this.manage_button.Size = new System.Drawing.Size(196, 59);
            this.manage_button.TabIndex = 1;
            this.manage_button.Text = "Manage Babysitter Profile";
            this.manage_button.UseVisualStyleBackColor = false;
            this.manage_button.Click += new System.EventHandler(this.manage_button_Click);
            // 
            // parentbutton
            // 
            this.parentbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.parentbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.parentbutton.FlatAppearance.BorderSize = 0;
            this.parentbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parentbutton.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.parentbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.parentbutton.Location = new System.Drawing.Point(0, 199);
            this.parentbutton.Name = "parentbutton";
            this.parentbutton.Size = new System.Drawing.Size(196, 59);
            this.parentbutton.TabIndex = 2;
            this.parentbutton.Text = "Manage Parent Profile";
            this.parentbutton.UseVisualStyleBackColor = false;
            this.parentbutton.Click += new System.EventHandler(this.parentbutton_Click);
            // 
            // back_pictureBox
            // 
            this.back_pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.back_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("back_pictureBox.Image")));
            this.back_pictureBox.Location = new System.Drawing.Point(0, 547);
            this.back_pictureBox.Name = "back_pictureBox";
            this.back_pictureBox.Size = new System.Drawing.Size(45, 41);
            this.back_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_pictureBox.TabIndex = 39;
            this.back_pictureBox.TabStop = false;
            this.back_pictureBox.Click += new System.EventHandler(this.back_pictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(638, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Control";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1177, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admin_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 666);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.upperpanel);
            this.Name = "Admin_Control";
            this.Text = "Admin_Control";
            this.rightpanel.ResumeLayout(false);
            this.upperpanel.ResumeLayout(false);
            this.upperpanel.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rightpanel;
        private System.Windows.Forms.Panel upperpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button parentbutton;
        private System.Windows.Forms.Button manage_button;
        private System.Windows.Forms.PictureBox back_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}