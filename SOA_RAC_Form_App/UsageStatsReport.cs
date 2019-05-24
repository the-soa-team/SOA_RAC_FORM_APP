using RentACar.Bll.Concretes;
using RentACar.Model.EntityModels;
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
    public partial class UsageStatsReport : Form
    {
        Welcome WelcomeForm;
        List<Transactions> EntityList = new List<Transactions>();

        public UsageStatsReport(Welcome WelcomeForm)
        {
            InitializeComponent();
            this.WelcomeForm = WelcomeForm;
        }

        private void IncomeReport_Load(object sender, EventArgs e)
        {

            using (var carManager = new CarManager()) {
                List<Cars> cars = carManager.SelectAll();

                chart.Series.Clear();

                foreach (var car in cars)
                {
                    chart.Series.Add(car.Brand+"-"+car.Model);
                }

                DateTime today = DateTime.Now;
                DateTime monthBefore = today.AddDays(-30);

                DayObj[] days = new DayObj[30];

                for (int i = 0; i < 30; i++)
                {
                    DayObj newDayObj = new DayObj();
                    newDayObj.Date = monthBefore.ToString("d/m/y");
                    days[i] = newDayObj;

                    
                }

                using (var transactionManager = new TransactionManager())
                {
                    EntityList.Clear();
                    // Get cars from business layer (Core App)
                    List<Transactions> transactions = transactionManager.SelectAll();

                    foreach (var transaction in transactions)
                    {
                        Cars nCar = cars.Where(x => x.CarID == transaction.CarID).Single();
                        DateTime bDate = transaction.BeginDate.Value;
                        DateTime eDate = transaction.DeliveryDate.Value;
                        int DiffDays = (int)Math.Ceiling((eDate - bDate).TotalDays);
                        double avgKm = (double)(transaction.ReturnKm - transaction.CurrentKm) / DiffDays;
                        
                        for (int j = 0; j < DiffDays; j++)
                        {
                            chart.Series[nCar.Brand + "-" + nCar.Model].Points.Add(avgKm);
                            DateTime cDate = ((DateTime)transaction.BeginDate).AddDays(j);
                        }
                    }
                }
            }

            //chart.Series["Income"].Points.Add(4);
            //chart.Series["Income"].Points.Add(6);
            //chart.Series["Income"].Points.Add(11);

            //chart.Series["Expenses"].Points.Add(3);
            //chart.Series["Expenses"].Points.Add(4);
            //chart.Series["Expenses"].Points.Add(8);
        }
    }

    class DayObj
    {
        public Dictionary<string, int> Cars = new Dictionary<string, int>();
        public String Date;
    }
}
