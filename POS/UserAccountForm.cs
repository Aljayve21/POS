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
    public partial class UserAccountForm : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        DashboardForm f;
         
        public UserAccountForm(DashboardForm f)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            this.f = f;
            
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
            textuser.Clear();
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
                cm = new SqlCommand("insert into tblUser (name, username, password, role) values (@name, @username, @password, @role)", cn);
                cm.Parameters.AddWithValue("@name", textname.Text);
                cm.Parameters.AddWithValue("@username", textuser.Text);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtOldP.Text != f._pass)
                {
                    MessageBox.Show("Old password did not matched!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtNewP.Text != txtRetypeP.Text)
                {
                    MessageBox.Show("Confirm new password did not matched!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                cn.Open();
                cm = new SqlCommand("update tblUser set password=@password where  username =@username", cn);
                cm.Parameters.AddWithValue("@password", txtNewP.Text);
                cm.Parameters.AddWithValue("@username", txtCpUser.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Password has beeen successfully changed!", "Changed Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCpUser.Clear();
                txtRetypeP.Clear();
                txtNewP.Clear();
                txtOldP.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cborole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
