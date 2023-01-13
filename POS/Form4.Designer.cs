namespace POS
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cancel = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.cborole = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textretype = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Account";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(-1, 45);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(479, 286);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Resize += new System.EventHandler(this.metroTabControl1_Resize);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(471, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Account";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Cancel);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.cborole);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textretype);
            this.panel1.Controls.Add(this.textpass);
            this.panel1.Controls.Add(this.textname);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 244);
            this.panel1.TabIndex = 0;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(367, 194);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(83, 31);
            this.Cancel.TabIndex = 9;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(265, 194);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(83, 31);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // cborole
            // 
            this.cborole.FormattingEnabled = true;
            this.cborole.Items.AddRange(new object[] {
            "Owner",
            "Cashier"});
            this.cborole.Location = new System.Drawing.Point(131, 150);
            this.cborole.Name = "cborole";
            this.cborole.Size = new System.Drawing.Size(232, 21);
            this.cborole.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Role";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textretype
            // 
            this.textretype.Location = new System.Drawing.Point(131, 110);
            this.textretype.Name = "textretype";
            this.textretype.PasswordChar = '•';
            this.textretype.Size = new System.Drawing.Size(232, 20);
            this.textretype.TabIndex = 5;
            // 
            // textpass
            // 
            this.textpass.Location = new System.Drawing.Point(131, 68);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '•';
            this.textpass.Size = new System.Drawing.Size(232, 20);
            this.textpass.TabIndex = 4;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(131, 26);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(232, 20);
            this.textname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Re-type Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(471, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Password";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(471, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete Account";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(474, 329);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cborole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textretype;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Save;
    }
}