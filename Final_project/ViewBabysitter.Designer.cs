
namespace Final_project
{
    partial class ViewBabysitter
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
            this.View_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.Search_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(89, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(607, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // View_button
            // 
            this.View_button.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_button.Location = new System.Drawing.Point(335, 295);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(106, 30);
            this.View_button.TabIndex = 19;
            this.View_button.Text = "View";
            this.View_button.UseVisualStyleBackColor = true;
            this.View_button.Click += new System.EventHandler(this.View_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(122, 41);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(123, 42);
            this.Search_button.TabIndex = 23;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Search_textBox
            // 
            this.Search_textBox.Location = new System.Drawing.Point(324, 41);
            this.Search_textBox.Multiline = true;
            this.Search_textBox.Name = "Search_textBox";
            this.Search_textBox.Size = new System.Drawing.Size(245, 42);
            this.Search_textBox.TabIndex = 22;
            this.Search_textBox.TextChanged += new System.EventHandler(this.Search_textBox_TextChanged_1);
            // 
            // ViewBabysitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Search_textBox);
            this.Controls.Add(this.View_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewBabysitter";
            this.Text = "ViewBabysitter";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.TextBox Search_textBox;
    }
}