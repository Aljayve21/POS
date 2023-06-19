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
    public partial class SalesForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        //CashierForm df;
        public string suser;
        public SalesForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            SalesRecord();
            
          //  df = frm;
        }

       

        public void SalesRecord()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            //cm = new SqlCommand("select * from tblCashier where status like 'Sold'", cn);
            cm = new SqlCommand("select c.id, c.transno, c.prodcode, p.description, c.cquantity, c.price, c.sdate, c.total from tblCashier as c inner join tblProduct as p on c.prodcode = p.prodcode where c.status like 'Sold'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read()) 
            {
                i += 1;
                //dataGridView1.Rows.Add(i, dr["transno"].ToString(), dr["prodcode"].ToString(), dr["cquantity"].ToString(), dr["price"].ToString(), dr["sdate"].ToString(), dr["total"].ToString(),dr["status"].ToString());
                dataGridView1.Rows.Add(i, dr["transno"].ToString(), dr["prodcode"].ToString(), dr["description"].ToString(), dr["cquantity"].ToString(), dr["price"].ToString(), dr["sdate"].ToString(), dr["total"].ToString());
                //dataGridView1.Rows.Add(i, dr["transno"].ToString(), dr["prodcode"].ToString(), dr["description"].ToString(), dr["cquantity"].ToString(), dr["price"].ToString(), dr["sdate"].ToString(), dr["total"].ToString(), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            cn.Close();
            cn.Open();
            cm = new SqlCommand("SELECT COUNT (id) FROM tblCashier ", cn);
            dr = cm.ExecuteReader();
            if (dr.Read())
            {
                totalSales.Text = "" + dr[0];
            }
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colCancel")
            {
                frmCancelDetails f = new frmCancelDetails();
                f.txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                f.txtTransNo.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                f.txtPCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                f.txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                f.txPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                f.txtQty.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                f.txtTotal.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
               
                f.txtCancel.Text = suser;
                f.Enabled = true;
                f.ShowDialog();
                f.Focus();
            }
        }
    }
}
