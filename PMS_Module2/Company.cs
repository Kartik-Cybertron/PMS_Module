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
    public partial class Company : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KD\Documents\PMS_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public Company()
        {
            InitializeComponent();
        }

        public void populate()
        {
            con.Open();
            string myQuery = "select * from cmpny_Table";
            SqlDataAdapter da = new SqlDataAdapter(myQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CompanyDataGridView.ReadOnly = true;
            CompanyDataGridView.DataSource = ds.Tables[0];
            con.Close();

        }
        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            if (txt_cmpny_id.Text == "" || txt_cmpny_name.Text == "" || txt_cmpny_phn.Text == "" || txt_cmpny_addr.Text == "")
            {
                MessageBox.Show("Wrong Input.Fill all the fields");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into cmpny_Table values('" + txt_cmpny_id.Text + "','" + txt_cmpny_name.Text + "','" + txt_cmpny_phn.Text + "','" + txt_cmpny_addr.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Successfully Added");
                con.Close();
            }
        }

        private void btn_updtEmp_Click(object sender, EventArgs e)
        {
            con.Open();
            string myQuery = "UPDATE cmpny_Table SET Comp_name = '" + txt_cmpny_name.Text + "', Comp_Phn = '" + txt_cmpny_phn.Text + "', Comp_addr = '" + txt_cmpny_addr.Text + "' WHERE company_id = '" + txt_cmpny_id.Text + "'";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Company Updated Successfully");
            con.Close();
            populate();
        }

        private void Company_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void btn_delEmp_Click(object sender, EventArgs e)
        {
            if (txt_cmpny_id.Text == "")
            {
                MessageBox.Show("Wrong operation. Click on the medicine to be Deleted");
            }
            else
            {
                con.Open();
                string myQuery = "delete from cmpny_Table where company_id='" + txt_cmpny_id.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Company Deleted Successfully");
                con.Close();
                populate();
            }
        }

        private void CompanyDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_cmpny_id.Text = CompanyDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            txt_cmpny_name.Text = CompanyDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txt_cmpny_phn.Text = CompanyDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txt_cmpny_addr.Text = CompanyDataGridView.SelectedRows[0].Cells[3].Value.ToString();
        }
    }
}
