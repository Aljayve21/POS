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
    public partial class ProductForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        
       

        public ProductForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
           
            LoadRecords();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                NewProductForm frm = new NewProductForm(this);
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                
                frm.txtDescription.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.cbBrand.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.cbCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.txtQty.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.ShowDialog();
            } else
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("delete from tblProduct where no like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();   
                    cn.Close();
                    LoadRecords();
                }
            }
        }

        private void productBtn_Click(object sender, EventArgs e)
        {
            NewProductForm frm = new NewProductForm(this);
            frm.ShowDialog();
        }
        public void LoadRecords()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("select * from tblProduct", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["no"].ToString (), dr["description"].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["quantity"].ToString(), dr["price"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
