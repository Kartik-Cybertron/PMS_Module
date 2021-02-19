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

namespace PMS_Module2
{
    public partial class MedicineForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KD\Documents\PMS_DB.mdf;Integrated Security=True;Connect Timeout=30");
        public MedicineForm()
        {
            InitializeComponent();
        }

        public void populate()
        {
            con.Open();
            string myQuery = "select * from med_Table";
            SqlDataAdapter da = new SqlDataAdapter(myQuery,con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            MedicineDataGridView.ReadOnly = true;
            MedicineDataGridView.DataSource = ds.Tables[0];
            con.Close();
        }

        private void MedicineForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void txt_qty_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_s_price_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_b_price_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_med_name.Text==""||txt_b_price.Text == "" ||txt_s_price.Text == "" ||txt_qty.Text == "" || company_cmbx.SelectedItem == null)
            {
                MessageBox.Show("Missing Data.Fill all the Information");
            }
            else
            { 
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into med_Table values('" + txt_med_name.Text + "','" + txt_b_price.Text + "','" + txt_s_price.Text + "','" + txt_qty.Text + "','" + dtpkr_exp_date.Text + "','" + company_cmbx.SelectedItem.ToString() + "')",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine added sucessfully");
                con.Close();
            }
        }

        private void MedicineDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_med_name.Text = MedicineDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            txt_b_price.Text= MedicineDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            txt_s_price.Text= MedicineDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            txt_qty.Text= MedicineDataGridView.SelectedRows[0].Cells[4].Value.ToString();

            //===============================================================================================================
            //===============================================================================================================
            //issue while showing date on datetimepicker

            //dtpkr_exp_date.Value= MedicineDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            //dtpkr_exp_date.Value = DateTime.ParseExact("'"+ MedicineDataGridView.SelectedRows[0].Cells[5].Value.ToString() + "'","dd/MM/yyyy");
            //===============================================================================================================
            //===============================================================================================================

            company_cmbx.Text = MedicineDataGridView.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void btn_updt_Click(object sender, EventArgs e)
        {
            con.Open();
            string myQuery = "UPDATE med_Table SET B_price = '" + txt_b_price.Text + "', S_price = '" + txt_s_price.Text + "', Qty = '" + txt_qty.Text + "', exp_date = '" + dtpkr_exp_date.Text + "', Company = '" + company_cmbx.SelectedItem.ToString() + "' WHERE MedName = '" + txt_med_name.Text + "'";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated Successfully");
            con.Close();
            populate();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txt_med_name.Text == "")
            {
                MessageBox.Show("Wrong operation. Click on the medicine to be Deleted");
            }
            else
            {
                con.Open();
                string myQuery = "delete from med_Table where MedName='" + txt_med_name.Text + "'";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully");
                con.Close();
                populate();
            }
        }
    }
}
