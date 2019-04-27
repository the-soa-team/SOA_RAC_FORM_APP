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
        string EntityTitle = "Car";
        List<Car> CarList = new List<Car>();
        Car ActiveCar;
        FormModEnum ActiveMod = FormModEnum.Create;

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
                Car CarEntity = new Car();

                CarEntity.Brand = BrandBox.Text;
                CarEntity.Model = ModelBox.Text;
                CarEntity.LicenceAge = Int32.Parse(LicenceAgeBox.Text);
                CarEntity.DriverAge = Int32.Parse(DriverAgeBox.Text);
                CarEntity.DailyMaxKm = Int32.Parse(DailyMaxKmBox.Text);
                CarEntity.CurrentKm = Int32.Parse(CurrentKmBox.Text);
                CarEntity.HasAirBag = (AirgBagEnum)Enum.Parse(typeof(AirgBagEnum), HasAirBagCombo.SelectedItem.ToString()); // HasAirBagCombo.SelectedValue;
                CarEntity.LuggageVolume = Int32.Parse(LuggageVolumeBox.Text);
                CarEntity.NumSeats = Int32.Parse(NumSeatsBox.Text);
                CarEntity.RentPrice = Int32.Parse(RentPriceBox.Text);


                using (var CarsSoapClient = new CarsClient())
                {
                    if (this.ActiveMod == FormModEnum.Create)
                    {
                        CarsSoapClient.CreateCar(CarEntity);
                        MessageBox.Show(this.EntityTitle + " Saved Successfully");
                    } else
                    {
                        CarEntity.ID = this.ActiveCar.ID;
                        CarsSoapClient.UpdateCar(CarEntity);
                        MessageBox.Show(this.EntityTitle + " Updated Successfully");
                    }
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
                    
                    CarGridView.DataSource = CarList;
                    CarGridView.Columns["ID"].DisplayIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void CompaniesGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (CarGridView.Rows.Count != CarList.Count)
                return;

            if (e.RowIndex > -1)
            {
                this.SetActiveRow(e.RowIndex);
            }
        }

        private void CompaniesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CarGridView.Rows.Count != CarList.Count)
                return;

            if (e.RowIndex > -1)
            {
                this.SetActiveRow(e.RowIndex);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var CarsSoapClient = new CarsClient())
                {
                    CarsSoapClient.DeleteCar(this.ActiveCar.ID);
                    
                    CarList.Remove(ActiveCar);
                    this.ClearActiveCar();
                    CarGridView.DataSource = null;
                    CarGridView.DataSource = CarList;

                    MessageBox.Show("Car Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void ClearActiveCar()
        {
            this.ActiveCar = null;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.ActiveCar = CarList.Find(x => x.ID == ActiveCar.ID);
        
            this.PopulateTheForm();
        }

        private void CancelUpdateBtn_Click(object sender, EventArgs e)
        {
            this.SetFormMod(FormModEnum.Create);
            this.ResetTheForm();
        }

        private void PopulateTheForm()
        {
            BrandBox.Text = ActiveCar.Brand;
            ModelBox.Text = ActiveCar.Model;
            LicenceAgeBox.Text = ActiveCar.LicenceAge.ToString();
            DriverAgeBox.Text = ActiveCar.DriverAge.ToString();
            DailyMaxKmBox.Text = ActiveCar.DailyMaxKm.ToString();
            CurrentKmBox.Text = ActiveCar.CurrentKm.ToString();
            HasAirBagCombo.SelectedIndex = HasAirBagCombo.FindStringExact(ActiveCar.HasAirBag.ToString());
            LuggageVolumeBox.Text = ActiveCar.LuggageVolume.ToString();
            NumSeatsBox.Text = ActiveCar.NumSeats.ToString();
            RentPriceBox.Text = ActiveCar.RentPrice.ToString();

            this.SetFormMod(FormModEnum.Update);
        }

        public void ResetTheForm()
        {
            foreach (Control control in FormGroupBox.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }

        private void SetFormMod(FormModEnum mod)
        {
            this.ActiveMod = mod;
            if (mod == FormModEnum.Create)
            {
                FormGroupBox.Text = "ADD " + EntityTitle;
                SaveBtn.Text = "Create New " + EntityTitle;
                CancelUpdateBtn.Enabled = false;
            }
            else
            {
                FormGroupBox.Text = "UPDATE " + EntityTitle;
                SaveBtn.Text = "Update A " + EntityTitle;
                CancelUpdateBtn.Enabled = true;
            }
        }

        private void SetActiveRow(int index)
        {
            if(CarGridView.Rows.Count < 1)
            {
                return;
            }

            try
            {
                CarGridView.Rows[index].Selected = true;

                if (CarGridView.SelectedRows.Count < 1)
                {
                    return;
                }
                int CarId = Int32.Parse(CarGridView.SelectedRows[0].Cells["Id"].Value.ToString());
                this.ActiveCar = CarList.Find(x => x.ID == CarId);
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
