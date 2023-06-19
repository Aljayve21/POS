using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class SettlePaymentForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        CashierForm cform;

        public const string SQLServerLink = @"Data Source=ALJAYVE;Initial Catalog=POS2;Integrated Security=True";
        protected SqlConnection connection = new SqlConnection(SQLServerLink);
        protected SqlCommand command = new SqlCommand();
        protected SqlDataReader mdr;

        CashierForm cfrm = new CashierForm();

        public SettlePaymentForm(CashierForm cform)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.cform = cform;
        }

        private void textCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = double.Parse(textSale.Text);
                double cash = double.Parse(textCash.Text);
                double change = cash - sale;
                textChange.Text = change.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                textChange.Text = "0.00";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            textCash.Text += btn7.Text;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            textCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textCash.Text += btn9.Text;
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            textCash.Clear();
            textCash.Focus();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
           
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
          
        }

        private void btn3_Click(object sender, EventArgs e)
        {
          
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn2.Text;
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn1.Text;
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn3.Text;
        }

        private void btn00_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn00.Text;
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn0.Text;
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn6.Text;
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn5.Text;
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn4.Text;
        }

        private void btnc_Click_1(object sender, EventArgs e)
        {
            textCash.Clear();
            textCash.Focus();
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn9.Text;
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn8.Text;
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            textCash.Text += btn7.Text;
        }
        

        private void btnenter_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (double.Parse(textChange.Text) < 0 || (textCash.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient amount. Please enter the correct amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i < cform.dataGridView1.Rows.Count; i++)
                    {
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblProduct SET quantity = quantity -" + int.Parse(cform.dataGridView1.Rows[i].Cells[5].Value.ToString()) + " WHERE prodcode = '" + cform.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteReader();
                        cn.Close();
                        cn.Open();
                        cm = new SqlCommand("UPDATE tblCashier SET status = 'Sold' WHERE prodcode = '" + cform.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", cn);
                        cm.ExecuteReader();
                        cn.Close();
                    }
                    cn.Open();
                    MessageBox.Show("Payment successfully Save!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cm.ExecuteReader();
                    cform.GetTransNo();
                    cform.LoadCart();
                    cn.Close();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
               
                MessageBox.Show(ex.Message, "Payment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettlePaymentForm_Load(object sender, EventArgs e)
        {

        }
    }
   
}
