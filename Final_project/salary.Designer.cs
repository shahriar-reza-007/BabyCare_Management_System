
namespace Final_project
{
    partial class salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salary));
            this.Upperlabel = new System.Windows.Forms.Label();
            this.ID_label = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Glabel = new System.Windows.Forms.Label();
            this.WRlabel = new System.Windows.Forms.Label();
            this.hrlabel = new System.Windows.Forms.Label();
            this.sallabel = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.WHtextBox = new System.Windows.Forms.TextBox();
            this.HRtextBox = new System.Windows.Forms.TextBox();
            this.Totalsal = new System.Windows.Forms.TextBox();
            this.FradioButton = new System.Windows.Forms.RadioButton();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.maleradiobutton = new System.Windows.Forms.RadioButton();
            this.View_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.back_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Upperlabel
            // 
            this.Upperlabel.AutoSize = true;
            this.Upperlabel.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upperlabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Upperlabel.Location = new System.Drawing.Point(485, 25);
            this.Upperlabel.Name = "Upperlabel";
            this.Upperlabel.Size = new System.Drawing.Size(215, 37);
            this.Upperlabel.TabIndex = 0;
            this.Upperlabel.Text = "Worker Salary";
            // 
            // ID_label
            // 
            this.ID_label.AutoSize = true;
            this.ID_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_label.Location = new System.Drawing.Point(49, 124);
            this.ID_label.Name = "ID_label";
            this.ID_label.Size = new System.Drawing.Size(40, 20);
            this.ID_label.TabIndex = 1;
            this.ID_label.Text = "ID :";
            this.ID_label.Click += new System.EventHandler(this.ID_label_Click);
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(49, 185);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(69, 20);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name :";
            this.Namelabel.Click += new System.EventHandler(this.Namelabel_Click);
            // 
            // Glabel
            // 
            this.Glabel.AutoSize = true;
            this.Glabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Glabel.Location = new System.Drawing.Point(49, 260);
            this.Glabel.Name = "Glabel";
            this.Glabel.Size = new System.Drawing.Size(76, 20);
            this.Glabel.TabIndex = 3;
            this.Glabel.Text = "Gender:";
            this.Glabel.Click += new System.EventHandler(this.Glabel_Click);
            // 
            // WRlabel
            // 
            this.WRlabel.AutoSize = true;
            this.WRlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WRlabel.Location = new System.Drawing.Point(49, 319);
            this.WRlabel.Name = "WRlabel";
            this.WRlabel.Size = new System.Drawing.Size(136, 20);
            this.WRlabel.TabIndex = 4;
            this.WRlabel.Text = "Working Hour :";
            this.WRlabel.Click += new System.EventHandler(this.WRlabel_Click);
            // 
            // hrlabel
            // 
            this.hrlabel.AutoSize = true;
            this.hrlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrlabel.Location = new System.Drawing.Point(49, 385);
            this.hrlabel.Name = "hrlabel";
            this.hrlabel.Size = new System.Drawing.Size(109, 20);
            this.hrlabel.TabIndex = 5;
            this.hrlabel.Text = "Hourly rate:";
            this.hrlabel.Click += new System.EventHandler(this.hrlabel_Click);
            // 
            // sallabel
            // 
            this.sallabel.AutoSize = true;
            this.sallabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sallabel.Location = new System.Drawing.Point(49, 458);
            this.sallabel.Name = "sallabel";
            this.sallabel.Size = new System.Drawing.Size(120, 20);
            this.sallabel.TabIndex = 6;
            this.sallabel.Text = "Total salary :";
            this.sallabel.Click += new System.EventHandler(this.sallabel_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.Location = new System.Drawing.Point(204, 113);
            this.idtextBox.Multiline = true;
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(148, 41);
            this.idtextBox.TabIndex = 7;
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(204, 185);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(148, 41);
            this.name_textbox.TabIndex = 8;
            this.name_textbox.TextChanged += new System.EventHandler(this.name_textbox_TextChanged);
            // 
            // WHtextBox
            // 
            this.WHtextBox.Location = new System.Drawing.Point(204, 305);
            this.WHtextBox.Multiline = true;
            this.WHtextBox.Name = "WHtextBox";
            this.WHtextBox.Size = new System.Drawing.Size(148, 41);
            this.WHtextBox.TabIndex = 9;
            this.WHtextBox.TextChanged += new System.EventHandler(this.WHtextBox_TextChanged);
            // 
            // HRtextBox
            // 
            this.HRtextBox.Location = new System.Drawing.Point(204, 372);
            this.HRtextBox.Multiline = true;
            this.HRtextBox.Name = "HRtextBox";
            this.HRtextBox.Size = new System.Drawing.Size(148, 41);
            this.HRtextBox.TabIndex = 10;
            // 
            // Totalsal
            // 
            this.Totalsal.Location = new System.Drawing.Point(204, 444);
            this.Totalsal.Multiline = true;
            this.Totalsal.Name = "Totalsal";
            this.Totalsal.Size = new System.Drawing.Size(148, 41);
            this.Totalsal.TabIndex = 11;
            // 
            // FradioButton
            // 
            this.FradioButton.AutoSize = true;
            this.FradioButton.Location = new System.Drawing.Point(289, 260);
            this.FradioButton.Name = "FradioButton";
            this.FradioButton.Size = new System.Drawing.Size(75, 21);
            this.FradioButton.TabIndex = 13;
            this.FradioButton.TabStop = true;
            this.FradioButton.Text = "Female";
            this.FradioButton.UseVisualStyleBackColor = true;
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(472, 106);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 51;
            this.DGV.RowTemplate.Height = 24;
            this.DGV.Size = new System.Drawing.Size(729, 377);
            this.DGV.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maleradiobutton
            // 
            this.maleradiobutton.AutoSize = true;
            this.maleradiobutton.Location = new System.Drawing.Point(195, 260);
            this.maleradiobutton.Name = "maleradiobutton";
            this.maleradiobutton.Size = new System.Drawing.Size(59, 21);
            this.maleradiobutton.TabIndex = 12;
            this.maleradiobutton.TabStop = true;
            this.maleradiobutton.Text = "Male";
            this.maleradiobutton.UseVisualStyleBackColor = true;
            // 
            // View_button
            // 
            this.View_button.Location = new System.Drawing.Point(772, 500);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(136, 38);
            this.View_button.TabIndex = 18;
            this.View_button.Text = "View";
            this.View_button.UseVisualStyleBackColor = true;
            this.View_button.Click += new System.EventHandler(this.View_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.Upperlabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 91);
            this.panel1.TabIndex = 19;
            // 
            // back_pictureBox
            // 
            this.back_pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.back_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("back_pictureBox.Image")));
            this.back_pictureBox.Location = new System.Drawing.Point(12, 512);
            this.back_pictureBox.Name = "back_pictureBox";
            this.back_pictureBox.Size = new System.Drawing.Size(36, 38);
            this.back_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_pictureBox.TabIndex = 17;
            this.back_pictureBox.TabStop = false;
            // 
            // salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.View_button);
            this.Controls.Add(this.back_pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.FradioButton);
            this.Controls.Add(this.maleradiobutton);
            this.Controls.Add(this.Totalsal);
            this.Controls.Add(this.HRtextBox);
            this.Controls.Add(this.WHtextBox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.sallabel);
            this.Controls.Add(this.hrlabel);
            this.Controls.Add(this.WRlabel);
            this.Controls.Add(this.Glabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.ID_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "salary";
            this.Text = "salary";
            this.Load += new System.EventHandler(this.salary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Upperlabel;
        private System.Windows.Forms.Label ID_label;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Glabel;
        private System.Windows.Forms.Label WRlabel;
        private System.Windows.Forms.Label hrlabel;
        private System.Windows.Forms.Label sallabel;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox WHtextBox;
        private System.Windows.Forms.TextBox HRtextBox;
        private System.Windows.Forms.TextBox Totalsal;
        private System.Windows.Forms.RadioButton FradioButton;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton maleradiobutton;
        private System.Windows.Forms.PictureBox back_pictureBox;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Panel panel1;
    }
}