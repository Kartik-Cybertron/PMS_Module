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
    public partial class Employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KD\Documents\PMS_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            populate();
        }

        public void populate()
        {
            con.Open();
            string myQuery = "select * from Emp_Table";
            SqlDataAdapter da = new SqlDataAdapter(myQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }


        private void btn_addEmp_Click(object sender, EventArgs e)
        {
            if(txt_emp_name.Text==""||txt_emp_age.Text==""||txt_emp_salary.Text==""||txt_emp_phn.Text == "" || txt_emp_addr.Text == ""||gender_cmbx.SelectedItem==null||txt_emp_pass.Text=="")
            {
                MessageBox.Show("Wrong Input.Fill all the fields");
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Emp_Table values('"+ txt_emp_name.Text + "','"+ txt_emp_age.Text + "','"+ txt_emp_salary.Text + "','"+ txt_emp_phn.Text + "','"+ txt_emp_addr.Text + "','" + gender_cmbx.SelectedItem.ToString() + "','" + txt_emp_pass.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Successfully Added");
                con.Close();
            }
        }

        private void btn_updtEmp_Click(object sender, EventArgs e)
        {
            con.Open();
            string myQuery = "UPDATE med_Table SET Emp_Age = '" + txt_emp_age.Text + "', Emp_Salary = '" + txt_emp_salary.Text + "', Emp_Phone = '" + txt_emp_phn.Text + "', Emp_addr = '" + txt_emp_addr.Text + "',Emp_gender='" + gender_cmbx.SelectedItem.ToString() + "', Emp_password='" + txt_emp_pass.Text + "' WHERE Emp_name = '" + txt_emp_name.Text + "'";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Updated Successfully");
            con.Close();
            populate();
        }

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_emp_name.Text = EmployeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txt_emp_age.Text = EmployeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txt_emp_salary.Text = EmployeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txt_emp_phn.Text = EmployeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            txt_emp_addr.Text = EmployeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            gender_cmbx.Text = EmployeeDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            txt_emp_pass.Text = EmployeeDataGridView.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void btn_delEmp_Click(object sender, EventArgs e)
        {
            if (txt_emp_name.Text == "")
            {
                MessageBox.Show("Wrong operation. Click on the medicine to be Deleted");
            }
            else
            {
                con.Open();
                string myQuery = "delete from Emp_Table where Emp_name='" + txt_emp_name.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully");
                con.Close();
                populate();
            }
        }
    }
}
