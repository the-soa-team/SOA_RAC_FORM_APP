using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOA_RAC_Form_App.CarService;
using SOA_RAC_Form_App.Enums;
using AirgBagEnum = SOA_RAC_Form_App.CarService.AirgBagEnum;

namespace SOA_RAC_Form_App
{
    public partial class Cars : Form
    {
        string ModelTitle = "Car";
        DataGridViewRow ActiveRow;
        List<Car> CarList = new List<Car>();

        public Cars()
        {
            InitializeComponent();
        }

        private void Cars_Load(object sender, EventArgs e)
        {
            this.SetFormMod(FormModEnum.Create);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Car NewCar = new Car();

                NewCar.Brand = BrandBox.Text;
                NewCar.Model = ModelBox.Text;
                NewCar.LicenceAge = Int32.Parse(LicenceAgeBox.Text);
                NewCar.DriverAge = Int32.Parse(DriverAgeBox.Text);
                NewCar.DailyMaxKm = Int32.Parse(DailyMaxKmBox.Text);
                NewCar.CurrentKm = Int32.Parse(CurrentKmBox.Text);
                NewCar.HasAirBag = (AirgBagEnum)Enum.Parse(typeof(AirgBagEnum), HasAirBagCombo.SelectedItem.ToString()); // HasAirBagCombo.SelectedValue;
                NewCar.LuggageVolume = Int32.Parse(LuggageVolumeBox.Text);
                NewCar.NumSeats = Int32.Parse(NumSeatsBox.Text);
                NewCar.RentPrice = Int32.Parse(RentPriceBox.Text);


                using (var CarsSoapClient = new CarsClient())
                {
                    CarsSoapClient.CreateCar(NewCar);

                    MessageBox.Show("Car Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var CarsSoapClient = new CarsClient())
                {
                    foreach (Car car in CarsSoapClient.ListCars(null))
                    {

                        CarList.Add(car);
                    }
                    
                    CompaniesGridView.DataSource = CarList.ToList();
                    CompaniesGridView.Columns["ID"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }

        }

        private void CompaniesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex > -1)
            {
                this.SetActiveRow(e.RowIndex);
            }
        }

        private void CompaniesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                this.SetActiveRow(e.RowIndex);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int CarId = Int32.Parse(ActiveRow.Cells["Id"].Value.ToString());

            try
            {
                using (var CarsSoapClient = new CarsClient())
                {
                    CarsSoapClient.DeleteCar(CarId);

                    Car FoundCar = CarList.Find(x => x.ID == Int32.Parse(ActiveRow.Cells["Id"].Value.ToString()));
                    CarList.Remove(FoundCar);
                    CompaniesGridView.DataSource = null;
                    CompaniesGridView.DataSource = CarList;

                    MessageBox.Show("Car Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void SetFormMod(FormModEnum mod)
        {
            if(mod == FormModEnum.Create)
                SaveBtn.Text = "Create New " + ModelTitle;
            else
                SaveBtn.Text = "Update A " + ModelTitle;
        }

        private void SetActiveRow(int index)
        {
            if(CompaniesGridView.Rows.Count < 1)
            {
                return;
            }

            try
            {
                CompaniesGridView.Rows[index].Selected = true;

                if (CompaniesGridView.SelectedRows.Count < 1)
                {
                    return;
                }
                ActiveRow = CompaniesGridView.SelectedRows[0];
                DeleteBtn.Enabled = true;
                UpdateBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }
    }
}
