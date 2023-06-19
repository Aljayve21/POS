using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace POS
{
    public partial class DashboardForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        public string _pass, _user;
        public DashboardForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
         
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockForm frm = new StockForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserAccountForm frm = new UserAccountForm(this);
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.txtCpUser.Text = _user;
            frm.txtOldP.Text = _pass;
            frm.BringToFront();
            frm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("MMM dd, yyyy dddd");
            
               
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm)); 
            this.Close(); 
            t.Start();  
        }
        public static void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalesForm frm = new SalesForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void lblShowUser_Click(object sender, EventArgs e)
        {
            s
        }
    }
}
