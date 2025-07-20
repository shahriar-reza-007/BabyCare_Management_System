
namespace Final_project
{
    partial class DaycareCenter
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Banani_radioButton = new System.Windows.Forms.RadioButton();
            this.Gulshan_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(570, 173);
            this.dataGridView1.TabIndex = 13;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 150);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 21);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Bashundhara Branch";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Banani_radioButton
            // 
            this.Banani_radioButton.AutoSize = true;
            this.Banani_radioButton.Location = new System.Drawing.Point(28, 113);
            this.Banani_radioButton.Name = "Banani_radioButton";
            this.Banani_radioButton.Size = new System.Drawing.Size(122, 21);
            this.Banani_radioButton.TabIndex = 16;
            this.Banani_radioButton.TabStop = true;
            this.Banani_radioButton.Text = "Banani Branch";
            this.Banani_radioButton.UseVisualStyleBackColor = true;
            this.Banani_radioButton.CheckedChanged += new System.EventHandler(this.Banani_radioButton_CheckedChanged);
            // 
            // Gulshan_radioButton
            // 
            this.Gulshan_radioButton.AutoSize = true;
            this.Gulshan_radioButton.Location = new System.Drawing.Point(28, 190);
            this.Gulshan_radioButton.Name = "Gulshan_radioButton";
            this.Gulshan_radioButton.Size = new System.Drawing.Size(131, 21);
            this.Gulshan_radioButton.TabIndex = 17;
            this.Gulshan_radioButton.TabStop = true;
            this.Gulshan_radioButton.Text = "Gulshan Branch";
            this.Gulshan_radioButton.UseVisualStyleBackColor = true;
            this.Gulshan_radioButton.CheckedChanged += new System.EventHandler(this.Gulshan_radioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 92);
            this.panel1.TabIndex = 19;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_label.Location = new System.Drawing.Point(336, 20);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(174, 40);
            this.title_label.TabIndex = 2;
            this.title_label.Text = "Branches";
            // 
            // DaycareCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 581);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Gulshan_radioButton);
            this.Controls.Add(this.Banani_radioButton);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DaycareCenter";
            this.Text = "DaycareCenter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton Banani_radioButton;
        private System.Windows.Forms.RadioButton Gulshan_radioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title_label;
    }
}