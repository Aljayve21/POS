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
    public partial class NewProductForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        ProductForm frmlist1;
        public NewProductForm(ProductForm flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist1 = flist;

        }

        private void NewProductForm_Load(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            

            txtDescription.Clear();
            txtDescription.Focus();
            
            cbBrand.Focus();
            
            cbCategory.Focus();
            txtQty.Clear();
            txtQty.Focus();
            txtPrice.Clear();
            txtPrice.Focus();
        }
        private void productBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblProduct(Description, Brand, Category, Quantity, Price) VALUES(@description, @brand, @category, @quantity, @price)", cn);
                    
                    cm.Parameters.AddWithValue("@description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@brand", cbBrand.Text);
                    cm.Parameters.AddWithValue("@category", cbCategory.Text);
                    cm.Parameters.AddWithValue("@quantity", txtQty.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully saved.");
                    Clear();
                    frmlist1.LoadRecords();   
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblProduct SET Description=@description, Brand=@brand, Category=@category, Quantity=@quantity, Price=@price", cn);
                    
                    cm.Parameters.AddWithValue("@description", txtDescription.Text);
                    cm.Parameters.AddWithValue("@brand", cbBrand.Text);
                    cm.Parameters.AddWithValue("@category", cbCategory.Text);
                    cm.Parameters.AddWithValue("@quantity", txtQty.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Product has been successfully updated.");
                    Clear();
                    frmlist1.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message);
                cn.Close();
           
            }
        }
    }
}
