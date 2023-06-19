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
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace POS
{
    public partial class CashierForm : Form
    {
        private String pcode;
        private double price;
        private String transno;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        public CashierForm()
        {
            
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            cn = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
            timer1.Start();

        }
        public void GetTransNo()
        {
            try
            {
                
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                 
                string transno;
                int count;

                cn.Open();
                cm = new SqlCommand("select top 1 transno from tblCashier where transno like '" + sdate + "%' order by id desc", cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransno.Text = sdate + (count + 1);
                }
                else
                {
                    transno = sdate + "1001";
                    lblTransno.Text = transno;
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void GetCashTotal()
        {

            double sales = Double.Parse(lblTotal.Text);
            double vat = sales * dbcon.GetVal();
            double vatable = sales - vat;
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotal.Text = sales.ToString("#,##0.00");
        }

        public void LoadCart()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridView1.Rows.Clear();
                int i = 0;
                double total = 0; 
                cn.Open();
               
                cm = new SqlCommand("select c.prodcode, description, brand, category, c.cquantity, c.price, total, c.status from tblCashier as c inner join tblProduct as p  on c.prodcode = p.prodcode where transno like '" + lblTransno.Text + "' and c.status like 'Pending'", cn);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    dataGridView1.Rows.Add(i, dr["prodcode"].ToString(), dr["description"].ToString(), dr["brand"].ToString(), dr["category"].ToString(), dr["cquantity"].ToString(), dr["price"].ToString());
                    hasrecord = true;
                }
                dr.Close();
                cn.Close();
                lblTotal.Text = total.ToString("#,##0.00");
                GetCashTotal();
                if (hasrecord == true)
                {
                    mtbSettleClick.Enabled = true;
                }
                else
                {
                    mtbSettleClick.Enabled = false;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cn.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
         
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove this item?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblCashier WHERE prodcode like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item has succesfully removed", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                    LoadCart();
                }
            }

        }

        private void mtbNewTrans_Click(object sender, EventArgs e)
        {
            GetTransNo();
            mtbaddp.Enabled = true;
            mtbQuantity.Enabled = true;
            mtbaddp.Focus();
            mtbQuantity.Focus();
            mtbDailyS.Enabled = true;
        }
        

        private void mtbaddp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (mtbaddp.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    cn.Open();
                    cm = new SqlCommand("select * from tblProduct where prodcode like '" + mtbaddp.Text + "' and status like 'Active'", cn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        

                        ProductDetails(dr["prodcode"].ToString(), double.Parse(dr["price"].ToString()), lblTransno.Text);
                        dr.Close();
                        cn.Close();
                      
                        LoadCart();
                    }
                    else
                    {
                        dr.Close();
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mtbaddp_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void mtbSettleClick_Click(object sender, EventArgs e)
        {
            SettlePaymentForm frm = new SettlePaymentForm(this);
            frm.textSale.Text = lblDisplayTotal.Text;
            frm.ShowDialog();
        }
      
        private void mtbSearch_Click(object sender, EventArgs e)
        {
            if (lblTransno.Text == "0000000000")
            {
                return;
            }
            ProductListForm frm = new ProductListForm(this);
           
            frm.ShowDialog();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
            lblDate1.Text = DateTime.Now.ToString("MMM dd, yyyy dddd");
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void lblDate1_Click(object sender, EventArgs e)
        {

        }

        private void mtbQuantity_Click(object sender, EventArgs e)
        {

        }
        public void ProductDetails(String pcode, double price, String transno)
        {
            this.pcode = pcode;
            this.price = price;
            this.transno = transno;

        }

        private void mtbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar == 13) && (mtbQuantity.Text != String.Empty))
            {
                cn.Open();
                cm = new SqlCommand("insert into tblCashier (transno, prodcode, cquantity, price, sdate)values(@transno, @prodcode, @cquantity, @price, @sdate)", cn);
                cm.Parameters.AddWithValue("@transno", transno);
                cm.Parameters.AddWithValue("@prodcode", pcode);
                cm.Parameters.AddWithValue("@cquantity", int.Parse(mtbQuantity.Text));
                cm.Parameters.AddWithValue("@price", price);
                cm.Parameters.AddWithValue("@sdate", DateTime.Now);


                cm.ExecuteNonQuery();
                cn.Close();

                mtbaddp.Clear();
                mtbaddp.Focus();
                LoadCart();
                

            }
        }

        private void mtbDailyS_Click(object sender, EventArgs e)
        {
            
            SalesForm frm = new SalesForm();
            frm.suser = lblCashier.Text;

            frm.Show();
        }

        private void mtbClose_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            this.Close();
            t.Start();
        }
        public static void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
