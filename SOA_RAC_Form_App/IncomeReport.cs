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
    public partial class IncomeReport : Form
    {
        Welcome WelcomeForm;

        public IncomeReport(Welcome WelcomeForm)
        {
            InitializeComponent();
            this.WelcomeForm = WelcomeForm;
        }
    }
}
