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
        public DashboardForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            cn.Open();
            //MessageBox.Show("Connected");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            ProductForm frm = new ProductForm();
            frm.TopLevel = false;
            panel1.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
    }
}
