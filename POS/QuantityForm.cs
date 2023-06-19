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
    public partial class QuantityForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private String pcode;
        private double price;
        private String transno;
      
        DBConnection dbcon = new DBConnection();
        CashierForm fcash;
        public QuantityForm(CashierForm frmcash)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            fcash = frmcash;
        }
        public void ProductDetails(String pcode, double price, String transno)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;
            
        }

        private void textQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 13) && (textQty.Text != String.Empty))
            {
                cn.Open();
                cm = new SqlCommand("insert into tblCashier (transno, prodcode, quantity, price, sdate)values(@transno, @prodcode, @quantity, @price, @sdate)", cn);
                cm.Parameters.AddWithValue("@transno", transno);
                cm.Parameters.AddWithValue("@prodcode", pcode);
                cm.Parameters.AddWithValue("@quantity", int.Parse(textQty.Text));
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);
               
                cm.ExecuteNonQuery();
                cn.Close();

                fcash.mtbaddp.Clear();
                fcash.mtbaddp.Focus();
                fcash.LoadCart();
                this.Dispose();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textQty_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
