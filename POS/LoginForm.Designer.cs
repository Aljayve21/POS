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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtbUsername = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtbPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.loginBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBtn.Location = new System.Drawing.Point(596, 345);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(117, 31);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(476, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 40);
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
            this.mtbUsername.Location = new System.Drawing.Point(512, 238);
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
            this.panel2.Controls.Add(this.mtbPassword);
            this.panel2.Location = new System.Drawing.Point(476, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 36);
            this.panel2.TabIndex = 5;
            // 
            // mtbPassword
            // 
            // 
            // 
            // 
            this.mtbPassword.CustomButton.Image = null;
            this.mtbPassword.CustomButton.Location = new System.Drawing.Point(253, 2);
            this.mtbPassword.CustomButton.Name = "";
            this.mtbPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.mtbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPassword.CustomButton.TabIndex = 1;
            this.mtbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPassword.CustomButton.UseSelectable = true;
            this.mtbPassword.CustomButton.Visible = false;
            this.mtbPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbPassword.Lines = new string[0];
            this.mtbPassword.Location = new System.Drawing.Point(36, 3);
            this.mtbPassword.MaxLength = 32767;
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.PasswordChar = '*';
            this.mtbPassword.PromptText = "Password";
            this.mtbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPassword.SelectedText = "";
            this.mtbPassword.SelectionLength = 0;
            this.mtbPassword.SelectionStart = 0;
            this.mtbPassword.ShortcutsEnabled = true;
            this.mtbPassword.Size = new System.Drawing.Size(279, 28);
            this.mtbPassword.TabIndex = 1;
            this.mtbPassword.UseSelectable = true;
            this.mtbPassword.WaterMark = "Password";
            this.mtbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPassword.Click += new System.EventHandler(this.mtbPassword_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.Location = new System.Drawing.Point(596, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Gilroy-Medium", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(512, 314);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 20);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::POS.Properties.Resources.bb_wordmark_blackbg;
            this.pictureBox3.Location = new System.Drawing.Point(510, 83);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::POS.Properties.Resources.reject;
            this.pictureBox2.Location = new System.Drawing.Point(799, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(110)))), ((int)(((byte)(25)))));
            this.pictureBox1.Image = global::POS.Properties.Resources.bb_logo_brownbg_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(421, 476);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(836, 475);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.mtbUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox mtbUsername;
        private MetroFramework.Controls.MetroTextBox mtbPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

