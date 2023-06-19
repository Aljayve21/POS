using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class StockForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public StockForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            StockInForm frm = new StockInForm();
            
            frm.Show();
            frm.LoadProduct();
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StockInForm frm = new StockInForm();
          
            frm.LoadStock();
        }
        public void LoadStock()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM viewStock", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                dataGridView1.Rows.Add(i, dr["no"].ToString(), dr["description"].ToString(), dr["quantity"].ToString(), dr["stockindate"].ToString(), dr["stockinby"].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
