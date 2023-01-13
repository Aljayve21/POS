namespace POS
{
    partial class LoginForm
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbUsername = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Location = new System.Drawing.Point(98, 328);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(117, 31);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Image = global::POS.Properties.Resources._314888575_5786970791364477_2229827413051501625_n;
            this.pictureBox1.Location = new System.Drawing.Point(1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtbUsername);
            this.panel1.Location = new System.Drawing.Point(17, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 30);
            this.panel1.TabIndex = 4;
            // 
            // mtbUsername
            // 
            // 
            // 
            // 
            this.mtbUsername.CustomButton.Image = null;
            this.mtbUsername.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.mtbUsername.CustomButton.Name = "";
            this.mtbUsername.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbUsername.CustomButton.TabIndex = 1;
            this.mtbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbUsername.CustomButton.UseSelectable = true;
            this.mtbUsername.CustomButton.Visible = false;
            this.mtbUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbUsername.Lines = new string[0];
            this.mtbUsername.Location = new System.Drawing.Point(0, 1);
            this.mtbUsername.MaxLength = 32767;
            this.mtbUsername.Name = "mtbUsername";
            this.mtbUsername.PasswordChar = '\0';
            this.mtbUsername.PromptText = "Username";
            this.mtbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbUsername.SelectedText = "";
            this.mtbUsername.SelectionLength = 0;
            this.mtbUsername.SelectionStart = 0;
            this.mtbUsername.ShortcutsEnabled = true;
            this.mtbUsername.Size = new System.Drawing.Size(279, 28);
            this.mtbUsername.TabIndex = 0;
            this.mtbUsername.UseSelectable = true;
            this.mtbUsername.WaterMark = "Username";
            this.mtbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(17, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 30);
            this.panel2.TabIndex = 5;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(17, 276);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Password";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(279, 28);
            this.metroTextBox2.TabIndex = 1;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Password";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegister.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegister.Location = new System.Drawing.Point(98, 365);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 31);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(308, 417);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox mtbUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private System.Windows.Forms.Button btnRegister;
    }
}

