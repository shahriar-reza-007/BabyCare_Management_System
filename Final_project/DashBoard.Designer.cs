
namespace Final_project
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.rightpanel = new System.Windows.Forms.Panel();
            this.babysitter_button = new System.Windows.Forms.Button();
            this.parent_button = new System.Windows.Forms.Button();
            this.title_label = new System.Windows.Forms.Label();
            this.upperpanel = new System.Windows.Forms.Panel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.back_pictureBox = new System.Windows.Forms.PictureBox();
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
            this.rightpanel.Controls.Add(this.pictureBox1);
            this.rightpanel.Controls.Add(this.babysitter_button);
            this.rightpanel.Controls.Add(this.parent_button);
            this.rightpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightpanel.Location = new System.Drawing.Point(0, 100);
            this.rightpanel.Name = "rightpanel";
            this.rightpanel.Size = new System.Drawing.Size(224, 421);
            this.rightpanel.TabIndex = 0;
            // 
            // babysitter_button
            // 
            this.babysitter_button.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babysitter_button.Location = new System.Drawing.Point(41, 267);
            this.babysitter_button.Name = "babysitter_button";
            this.babysitter_button.Size = new System.Drawing.Size(148, 53);
            this.babysitter_button.TabIndex = 2;
            this.babysitter_button.Text = "BABYSITTER DASHBOARD";
            this.babysitter_button.UseVisualStyleBackColor = true;
            this.babysitter_button.Click += new System.EventHandler(this.babysitter_button_Click);
            // 
            // parent_button
            // 
            this.parent_button.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parent_button.Location = new System.Drawing.Point(41, 170);
            this.parent_button.Name = "parent_button";
            this.parent_button.Size = new System.Drawing.Size(148, 54);
            this.parent_button.TabIndex = 1;
            this.parent_button.Text = "PARENT DASHBOARD";
            this.parent_button.UseVisualStyleBackColor = true;
            this.parent_button.Click += new System.EventHandler(this.parent_button_Click);
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_label.Location = new System.Drawing.Point(332, 25);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(242, 40);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "DASHBOARD";
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.upperpanel.Controls.Add(this.title_label);
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(0, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(863, 100);
            this.upperpanel.TabIndex = 2;
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.back_pictureBox);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(224, 100);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(639, 421);
            this.mainpanel.TabIndex = 3;
            // 
            // back_pictureBox
            // 
            this.back_pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.back_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("back_pictureBox.Image")));
            this.back_pictureBox.Location = new System.Drawing.Point(584, 366);
            this.back_pictureBox.Name = "back_pictureBox";
            this.back_pictureBox.Size = new System.Drawing.Size(43, 43);
            this.back_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_pictureBox.TabIndex = 17;
            this.back_pictureBox.TabStop = false;
            this.back_pictureBox.Click += new System.EventHandler(this.back_pictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 521);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.rightpanel);
            this.Controls.Add(this.upperpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.Text = "DashBoard";
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button babysitter_button;
        private System.Windows.Forms.Button parent_button;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel upperpanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox back_pictureBox;
    }
}