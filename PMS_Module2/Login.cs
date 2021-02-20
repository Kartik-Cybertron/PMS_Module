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

namespace PMS_Module2
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KD\Documents\PMS_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //if (txtbx_username.Text == "ADMIN" && txtbx_password.Text == "admin")
            //{
            //    HomeForm form = new HomeForm();
            //    form.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Wrong credentials. Please Try again...");
            //}
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select COUNT(*) from Emp_Table where Emp_name='"+ txtbx_username.Text +"' and emp_password= '"+ txtbx_password.Text +"'",con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                HomeForm form = new HomeForm();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong credentials. Please Try again...");
            }
            con.Close();
        }
    }
}
