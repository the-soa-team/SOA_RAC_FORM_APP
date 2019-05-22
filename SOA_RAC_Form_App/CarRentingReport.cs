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
    public partial class CarRentingReport : Form
    {
        Welcome WelcomeForm;

        public CarRentingReport(Welcome WelcomeForm)
        {
            InitializeComponent();
            this.WelcomeForm = WelcomeForm;
        }

        private void IncomeReport_Load(object sender, EventArgs e)
        {
            chart.Series["Income"].Points.Add(4);
            chart.Series["Income"].Points.Add(6);
            chart.Series["Income"].Points.Add(11);

            chart.Series["Expenses"].Points.Add(3);
            chart.Series["Expenses"].Points.Add(4);
            chart.Series["Expenses"].Points.Add(8);
        }
    }
}
