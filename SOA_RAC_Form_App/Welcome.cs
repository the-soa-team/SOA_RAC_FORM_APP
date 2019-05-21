using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOA_RAC_Form_App
{
    public partial class Welcome : Form
    {
        CarsForm CarsForm = null;
        CustomersForm CustomersForm = null;
        TransactionsForm TransactionsForm = null;
        IncomeReport IncomeReport = null;

        public Welcome()
        {
            InitializeComponent();
        }

        private void CompaniesBtn_Click(object sender, EventArgs e)
        {

        }

        private void CarsBtn_Click(object sender, EventArgs e)
        {
            if (this.CarsForm == null)
            {
                this.CarsForm = new CarsForm(this);
            }

            this.Visible = false;
            this.CarsForm.ShowDialog();

        }

        private void CustomersBtn_Click(object sender, EventArgs e)
        {
            if (this.CustomersForm == null)
            {
                this.CustomersForm = new CustomersForm(this);
            }

            this.Visible = false;
            this.CustomersForm.ShowDialog();
        }

        private void TracsantionsBtn_Click(object sender, EventArgs e)
        {
            if (this.TransactionsForm == null)
            {
                this.TransactionsForm = new TransactionsForm(this);
            }

            this.Visible = false;
            this.TransactionsForm.ShowDialog();
        }

        private void IncomeReportBtn_Click(object sender, EventArgs e)
        {
            if (this.IncomeReport == null)
            {
                this.IncomeReport = new IncomeReport(this);
            }

            this.Visible = false;
            this.IncomeReport.ShowDialog();
        }
    }
}
