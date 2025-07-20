
namespace Final_project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.user_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.usertype_label = new System.Windows.Forms.Label();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.usertype_comboBox = new System.Windows.Forms.ComboBox();
            this.login_button = new System.Windows.Forms.Button();
            this.showPassword_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.Location = new System.Drawing.Point(14, 225);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(152, 33);
            this.user_label.TabIndex = 2;
            this.user_label.Text = "User Email :";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_label.Location = new System.Drawing.Point(24, 309);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(139, 33);
            this.pass_label.TabIndex = 3;
            this.pass_label.Text = "Password :";
            // 
            // usertype_label
            // 
            this.usertype_label.AutoSize = true;
            this.usertype_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_label.Location = new System.Drawing.Point(24, 412);
            this.usertype_label.Name = "usertype_label";
            this.usertype_label.Size = new System.Drawing.Size(142, 32);
            this.usertype_label.TabIndex = 4;
            this.usertype_label.Text = "User Type :";
            // 
            // user_textBox
            // 
            this.user_textBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_textBox.Location = new System.Drawing.Point(222, 225);
            this.user_textBox.Multiline = true;
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(291, 46);
            this.user_textBox.TabIndex = 5;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_textBox.Location = new System.Drawing.Point(222, 309);
            this.pass_textBox.Multiline = true;
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '*';
            this.pass_textBox.Size = new System.Drawing.Size(291, 49);
            this.pass_textBox.TabIndex = 6;
            this.pass_textBox.TextChanged += new System.EventHandler(this.pass_textBox_TextChanged);
            // 
            // usertype_comboBox
            // 
            this.usertype_comboBox.AccessibleName = "";
            this.usertype_comboBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_comboBox.FormattingEnabled = true;
            this.usertype_comboBox.Items.AddRange(new object[] {
            "Admin",
            "Baby sitter",
            "Parent"});
            this.usertype_comboBox.Location = new System.Drawing.Point(222, 412);
            this.usertype_comboBox.Name = "usertype_comboBox";
            this.usertype_comboBox.Size = new System.Drawing.Size(152, 30);
            this.usertype_comboBox.TabIndex = 7;
            this.usertype_comboBox.Text = "Select User";
            this.usertype_comboBox.SelectedIndexChanged += new System.EventHandler(this.usertype_comboBox_SelectedIndexChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Info;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.Desktop;
            this.login_button.Location = new System.Drawing.Point(325, 485);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(85, 38);
            this.login_button.TabIndex = 9;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // showPassword_checkBox
            // 
            this.showPassword_checkBox.AutoSize = true;
            this.showPassword_checkBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword_checkBox.Location = new System.Drawing.Point(485, 412);
            this.showPassword_checkBox.Name = "showPassword_checkBox";
            this.showPassword_checkBox.Size = new System.Drawing.Size(136, 24);
            this.showPassword_checkBox.TabIndex = 12;
            this.showPassword_checkBox.Text = "Show Password";
            this.showPassword_checkBox.UseVisualStyleBackColor = true;
            this.showPassword_checkBox.CheckedChanged += new System.EventHandler(this.showPassword_checkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(955, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Register\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.title_label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 94);
            this.panel1.TabIndex = 14;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title_label.Location = new System.Drawing.Point(257, 22);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(594, 44);
            this.title_label.TabIndex = 15;
            this.title_label.Text = "Baby Sitter Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(640, 169);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1053, 629);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showPassword_checkBox);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.usertype_comboBox);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.usertype_label);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.user_label);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Label usertype_label;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.ComboBox usertype_comboBox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox showPassword_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

