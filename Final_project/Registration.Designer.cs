
namespace Final_project
{
    partial class Registration
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
            this.Name_label = new System.Windows.Forms.Label();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.Email_label = new System.Windows.Forms.Label();
            this.Phone_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.Email_textBox = new System.Windows.Forms.TextBox();
            this.Phone_textBox = new System.Windows.Forms.TextBox();
            this.Pass_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.Location = new System.Drawing.Point(165, 156);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(66, 24);
            this.Name_label.TabIndex = 1;
            this.Name_label.Text = "Name:";
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(312, 147);
            this.Name_textBox.Multiline = true;
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(186, 33);
            this.Name_textBox.TabIndex = 3;
            // 
            // Email_label
            // 
            this.Email_label.AutoSize = true;
            this.Email_label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_label.Location = new System.Drawing.Point(169, 214);
            this.Email_label.Name = "Email_label";
            this.Email_label.Size = new System.Drawing.Size(62, 24);
            this.Email_label.TabIndex = 4;
            this.Email_label.Text = "Email:";
            // 
            // Phone_label
            // 
            this.Phone_label.AutoSize = true;
            this.Phone_label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_label.Location = new System.Drawing.Point(162, 269);
            this.Phone_label.Name = "Phone_label";
            this.Phone_label.Size = new System.Drawing.Size(69, 24);
            this.Phone_label.TabIndex = 5;
            this.Phone_label.Text = "Phone:";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.Location = new System.Drawing.Point(136, 323);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(95, 24);
            this.pass_label.TabIndex = 6;
            this.pass_label.Text = "Password:";
            // 
            // Email_textBox
            // 
            this.Email_textBox.Location = new System.Drawing.Point(312, 203);
            this.Email_textBox.Multiline = true;
            this.Email_textBox.Name = "Email_textBox";
            this.Email_textBox.Size = new System.Drawing.Size(186, 35);
            this.Email_textBox.TabIndex = 7;
            // 
            // Phone_textBox
            // 
            this.Phone_textBox.Location = new System.Drawing.Point(312, 260);
            this.Phone_textBox.Multiline = true;
            this.Phone_textBox.Name = "Phone_textBox";
            this.Phone_textBox.Size = new System.Drawing.Size(186, 33);
            this.Phone_textBox.TabIndex = 8;
            // 
            // Pass_textBox
            // 
            this.Pass_textBox.Location = new System.Drawing.Point(312, 314);
            this.Pass_textBox.Multiline = true;
            this.Pass_textBox.Name = "Pass_textBox";
            this.Pass_textBox.Size = new System.Drawing.Size(186, 33);
            this.Pass_textBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.Location = new System.Drawing.Point(169, 95);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(34, 24);
            this.id_label.TabIndex = 18;
            this.id_label.Text = "ID:";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(312, 86);
            this.id_textBox.Multiline = true;
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(186, 33);
            this.id_textBox.TabIndex = 19;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 584);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Pass_textBox);
            this.Controls.Add(this.Phone_textBox);
            this.Controls.Add(this.Email_textBox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.Phone_label);
            this.Controls.Add(this.Email_label);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Name_label);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox Name_textBox;
        private System.Windows.Forms.Label Email_label;
        private System.Windows.Forms.Label Phone_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.TextBox Email_textBox;
        private System.Windows.Forms.TextBox Phone_textBox;
        private System.Windows.Forms.TextBox Pass_textBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
    }
}