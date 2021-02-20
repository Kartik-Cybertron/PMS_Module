using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_Module2
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void lab_medForm_Click(object sender, EventArgs e)
        {
            MedicineForm form = new MedicineForm();
            form.Show();
            this.Hide();
        }

        private void lab_EmpForm_Click(object sender, EventArgs e)
        {
            Employee form = new Employee();
            form.Show();
            this.Hide();
        }

        private void lab_cmpnyForm_Click(object sender, EventArgs e)
        {
            Company form = new Company();
            form.Show();
            this.Hide();
        }

        private void lab_billForm_Click(object sender, EventArgs e)
        {
            Billing form = new Billing();
            form.Show();
            this.Hide();
        }

        private void lab_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
