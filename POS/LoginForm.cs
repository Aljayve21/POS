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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS
{
    public partial class LoginForm : Form

    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;


        public string _pass, _username = "";

        public LoginForm()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string _role = "", _name = "";
            try
            {
                bool found = false;
                cn.Open();
                cm = new SqlCommand("Select * from tblUser where username = @username and password = @password", cn);
                cm.Parameters.AddWithValue("@username", mtbUsername.Text);
                cm.Parameters.AddWithValue("@password", mtbPassword.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true; 
                    _name = dr["name"].ToString();
                    _username = dr["username"].ToString();
                    _pass = dr["password"].ToString();
                    _role = dr["role"].ToString();
                    
                    
                }
                else
                {
                    found = false;

                }
                dr.Close();
                cn.Close();

              if (found == true)
                {
                    if (_role == "Cashier")
                    {
                        MessageBox.Show("Welcome " + _name + "!" + " Access GRANTED", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtbPassword.Clear();
                        mtbUsername.Clear();
                        this.Hide();
                        CashierForm frm = new CashierForm();
                        frm.ShowDialog();
                    }else
                    {
                       MessageBox.Show("Welcome " + _name + "!" + " Access GRANTED", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        mtbPassword.Clear();
                        mtbUsername.Clear();
                        this.Hide();
                        DashboardForm frm = new DashboardForm();
                        frm.lblShowUser.Text = _name;
                        frm.lblShowRole.Text = _role;
                        frm._pass = _pass;
                        frm._user = _username;
                        frm.ShowDialog();
                    }
                }else
                {
                    MessageBox.Show("Invalid username or password! ACCESS DENIED", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } catch(Exception ex)   
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mtbPassword_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
