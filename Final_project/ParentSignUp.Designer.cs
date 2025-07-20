
namespace Final_project
{
    partial class ParentSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentSignUp));
            this.Email_button = new System.Windows.Forms.Button();
            this.user_textBox = new System.Windows.Forms.TextBox();
            this.pass_button = new System.Windows.Forms.Button();
            this.pass_textBox = new System.Windows.Forms.TextBox();
            this.signUp_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.usertype_comboBox = new System.Windows.Forms.ComboBox();
            this.usertype_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.name_button = new System.Windows.Forms.Button();
            this.showpassword_checkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Email_button
            // 
            this.Email_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_button.Location = new System.Drawing.Point(18, 173);
            this.Email_button.Name = "Email_button";
            this.Email_button.Size = new System.Drawing.Size(141, 38);
            this.Email_button.TabIndex = 0;
            this.Email_button.Text = "Email :";
            this.Email_button.UseVisualStyleBackColor = true;
            // 
            // user_textBox
            // 
            this.user_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_textBox.Location = new System.Drawing.Point(230, 173);
            this.user_textBox.Multiline = true;
            this.user_textBox.Name = "user_textBox";
            this.user_textBox.Size = new System.Drawing.Size(303, 38);
            this.user_textBox.TabIndex = 1;
            // 
            // pass_button
            // 
            this.pass_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_button.Location = new System.Drawing.Point(18, 241);
            this.pass_button.Name = "pass_button";
            this.pass_button.Size = new System.Drawing.Size(141, 38);
            this.pass_button.TabIndex = 2;
            this.pass_button.Text = "Password :";
            this.pass_button.UseVisualStyleBackColor = true;
            // 
            // pass_textBox
            // 
            this.pass_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_textBox.Location = new System.Drawing.Point(230, 237);
            this.pass_textBox.Multiline = true;
            this.pass_textBox.Name = "pass_textBox";
            this.pass_textBox.PasswordChar = '*';
            this.pass_textBox.Size = new System.Drawing.Size(303, 38);
            this.pass_textBox.TabIndex = 3;
            // 
            // signUp_button
            // 
            this.signUp_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUp_button.Location = new System.Drawing.Point(318, 386);
            this.signUp_button.Name = "signUp_button";
            this.signUp_button.Size = new System.Drawing.Size(141, 38);
            this.signUp_button.TabIndex = 4;
            this.signUp_button.Text = "SignUp :";
            this.signUp_button.UseVisualStyleBackColor = true;
            this.signUp_button.Click += new System.EventHandler(this.signUp_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // usertype_comboBox
            // 
            this.usertype_comboBox.AccessibleName = "";
            this.usertype_comboBox.Font = new System.Drawing.Font("Microsoft PhagsPa", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_comboBox.FormattingEnabled = true;
            this.usertype_comboBox.Items.AddRange(new object[] {
            "Parent"});
            this.usertype_comboBox.Location = new System.Drawing.Point(256, 317);
            this.usertype_comboBox.Name = "usertype_comboBox";
            this.usertype_comboBox.Size = new System.Drawing.Size(170, 30);
            this.usertype_comboBox.TabIndex = 9;
            this.usertype_comboBox.Text = "Select User";
            this.usertype_comboBox.SelectedIndexChanged += new System.EventHandler(this.usertype_comboBox_SelectedIndexChanged);
            // 
            // usertype_label
            // 
            this.usertype_label.AutoSize = true;
            this.usertype_label.Font = new System.Drawing.Font("Microsoft PhagsPa", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertype_label.Location = new System.Drawing.Point(25, 313);
            this.usertype_label.Name = "usertype_label";
            this.usertype_label.Size = new System.Drawing.Size(142, 32);
            this.usertype_label.TabIndex = 8;
            this.usertype_label.Text = "User Type :";
            this.usertype_label.Click += new System.EventHandler(this.usertype_label_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_textBox.Location = new System.Drawing.Point(230, 112);
            this.name_textBox.Multiline = true;
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(303, 38);
            this.name_textBox.TabIndex = 10;
            // 
            // name_button
            // 
            this.name_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_button.Location = new System.Drawing.Point(18, 112);
            this.name_button.Name = "name_button";
            this.name_button.Size = new System.Drawing.Size(141, 38);
            this.name_button.TabIndex = 11;
            this.name_button.Text = "Name:";
            this.name_button.UseVisualStyleBackColor = true;
            // 
            // showpassword_checkBox
            // 
            this.showpassword_checkBox.AutoSize = true;
            this.showpassword_checkBox.Location = new System.Drawing.Point(465, 313);
            this.showpassword_checkBox.Name = "showpassword_checkBox";
            this.showpassword_checkBox.Size = new System.Drawing.Size(142, 21);
            this.showpassword_checkBox.TabIndex = 12;
            this.showpassword_checkBox.Text = "Show Password";
            this.showpassword_checkBox.UseVisualStyleBackColor = true;
            this.showpassword_checkBox.CheckedChanged += new System.EventHandler(this.showpassword_checkBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 84);
            this.panel1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(395, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sign Up";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ParentSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.showpassword_checkBox);
            this.Controls.Add(this.name_button);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.usertype_comboBox);
            this.Controls.Add(this.usertype_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUp_button);
            this.Controls.Add(this.pass_textBox);
            this.Controls.Add(this.pass_button);
            this.Controls.Add(this.user_textBox);
            this.Controls.Add(this.Email_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ParentSignUp";
            this.Text = "ParentSignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Email_button;
        private System.Windows.Forms.TextBox user_textBox;
        private System.Windows.Forms.Button pass_button;
        private System.Windows.Forms.TextBox pass_textBox;
        private System.Windows.Forms.Button signUp_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox usertype_comboBox;
        private System.Windows.Forms.Label usertype_label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button name_button;
        private System.Windows.Forms.CheckBox showpassword_checkBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}