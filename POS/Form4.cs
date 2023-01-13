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
    public partial class Form4 : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr; 
        public Form4()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void metroTabControl1_Resize(object sender, EventArgs e)
        {
            metroTabControl1.Left = (this.Width - metroTabControl1.Width) / 2;
            metroTabControl1.Top = (this.Height - metroTabControl1.Height) / 2;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void Clear()
        {
            textname.Clear();
            textpass.Clear();
            textretype.Clear();
            cborole.Text = "";
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textpass.Text != textretype.Text)
                {
                    MessageBox.Show("Password did not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                cn.Open();
                cm = new SqlCommand("insert into tblUser (username, password, role)values(@username,@password,@role)", cn);
                cm.Parameters.AddWithValue("@username", textname.Text);
                cm.Parameters.AddWithValue("@password", textpass.Text);
                cm.Parameters.AddWithValue("@role", cborole.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("New account has saved!");
                Clear();
            } catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
