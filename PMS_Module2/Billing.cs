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
    public partial class Billing : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KD\Documents\PMS_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public void populate_comboBox()
        {
            string sql = "select * from med_Table";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("MedName", typeof(string));
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                med_combx.ValueMember = "MedName";
                med_combx.DataSource = dt;
                con.Close();
            }
            catch
            {

            }

        }

        int x,unitp;
        public void fetchQty()
        {
            con.Open();
            string sql = "select * from med_Table where MedName = '" + med_combx.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                x = Convert.ToInt32(dr["Qty"].ToString());
                unitp = Convert.ToInt32(dr["S_price"].ToString());
                lab_avail_stock.Text ="Available Stock : " + dr["Qty"].ToString();
                lab_avail_stock.Visible = true;
            }
            con.Close();
        }

        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            populate_comboBox();
        }

        int grdtotal = 0;
        private void btn_add_Click(object sender, EventArgs e)
        {
            int n = 0;
            if (txt_bill_qty.Text == "" || Convert.ToInt32(txt_bill_qty.Text) > x)
            {
                MessageBox.Show("Not Enough Stock. Please Check available Stock.");
            }
            else
            {
                int total = Convert.ToInt32(txt_bill_qty.Text) * unitp;
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillingDataGridView);
                newRow.Cells[0].Value = n + 1;
                newRow.Cells[1].Value = med_combx.SelectedValue.ToString();
                newRow.Cells[2].Value = txt_bill_qty.Text;
                newRow.Cells[3].Value = unitp;
                newRow.Cells[4].Value = unitp * Convert.ToInt32(txt_bill_qty.Text);
                BillingDataGridView.Rows.Add(newRow);
                grdtotal = grdtotal + total;
                grd_amount.Text ="Rs " + grdtotal.ToString();
                updateMed();
            }
        }

        private void med_combx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchQty();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            HomeForm form = new HomeForm();
            form.Show();
            this.Hide();
        }

        public void updateMed()
        {
            con.Open();
            int newQty = Convert.ToInt32(txt_bill_qty.Text);
            string sql = "UPDATE med_Table SET Qty='"+ newQty +"' where MedName='"+med_combx.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated Successfully");
            con.Close();

        }
    }
}
