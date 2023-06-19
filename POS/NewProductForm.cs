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
     
            txtProdCode.Focus();

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
                    
                    cm = new SqlCommand("INSERT INTO tblProduct(Prodcode, Description, Brand, Category, Quantity, Price) VALUES(@prodcode, @description, @brand, @category, @quantity, @price)", cn);
                    cm.Parameters.AddWithValue("@prodcode", txtProdCode.Text);
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
                    this.Dispose();
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
                    cm = new SqlCommand("UPDATE tblProduct SET Description=@description, Brand=@brand, Category=@category, Quantity=@quantity, Price=@price WHERE Prodcode=@prodcode", cn);
                    cm.Parameters.AddWithValue("@prodcode", txtProdCode.Text);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
