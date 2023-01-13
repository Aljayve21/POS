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
    public partial class LoginForm : Form

    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                cm = new SqlCommand("Select * from tblUser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", mtbUsername.Text);
                cm.Parameters.AddWithValue("@password", mtbUsername.Text);
                dr = cm.ExecuteReader(); 
                cn.Close();
            } catch(Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 
    }
}
