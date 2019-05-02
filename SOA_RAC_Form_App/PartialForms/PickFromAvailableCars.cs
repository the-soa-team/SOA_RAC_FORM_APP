using SOA_RAC_Form_App.RAC_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOA_RAC_Form_App.PartialForms
{
    public partial class PickFromAvailableCars : Form
    {
        public int DriverAge;
        public int LicenceAge;
        public DateTime DateBegin;
        public int NumDays;

        public Car SelectedCar = null;
        List<Car> EntityList = new List<Car>();

        public PickFromAvailableCars()
        {
            InitializeComponent();
        }

        public void SetFilterValues(int LicenceAge, int DriverAge, DateTime DateBegin, int NumDays)
        {
            this.LicenceAge = LicenceAge;
            this.DriverAge = DriverAge;
            this.DateBegin = DateBegin;
            this.NumDays = NumDays;
        }

        private void EntityGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (EntityGridView.Rows.Count != EntityList.Count)
                return;

            if (e.RowIndex > -1)
            {
                this.SetActiveRow(e.RowIndex);
            }
        }

        private void SetActiveRow(int index)
        {
            if (EntityGridView.Rows.Count < 1)
            {
                return;
            }

            try
            {
                EntityGridView.Rows[index].Selected = true;

                if (EntityGridView.SelectedRows.Count < 1)
                {
                    return;
                }
                int CarId = Int32.Parse(EntityGridView.SelectedRows[0].Cells["Id"].Value.ToString());
                this.SelectedCar = EntityList.Find(x => x.ID == CarId);
                SelectBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void EntityGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EntityGridView.Rows.Count != EntityList.Count)
                return;

            if (e.RowIndex > -1)
            {
                this.SetActiveRow(e.RowIndex);
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PickFromAvailableCars_Load(object sender, EventArgs e)
        {
            try
            {
                using (var CarsSoapClient = new CarsClient())
                {
                    AviableCarRequest AviableCarReuest = new AviableCarRequest();
                    AviableCarReuest.LicenceAge = this.LicenceAge;
                    AviableCarReuest.DriverAge = this.DriverAge;
                    AviableCarReuest.DateBegin = this.DateBegin;

                    EntityList.Clear();
                    foreach (Car car in CarsSoapClient.ListAvailableCars(AviableCarReuest))
                    {
                        EntityList.Add(car);
                    }

                    EntityGridView.DataSource = null;
                    EntityGridView.DataSource = EntityList;
                    EntityGridView.Columns["ID"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }
    }
}
