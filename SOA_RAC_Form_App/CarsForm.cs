using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOA_RAC_Form_App.RAC_Service;
using SOA_RAC_Form_App.Enums;
using RentACar.Bll.Concretes;
using RentACar.Model.EntityModels;

namespace SOA_RAC_Form_App
{
    public partial class CarsForm : Form
    {
        Welcome WelcomeForm;
        string EntityTitle = "Car";
        List<Cars> EntityList = new List<Cars>();
        Cars ActiveEntity;
        FormModEnum ActiveMod = FormModEnum.Create;

        public CarsForm(Welcome WelcomeForm)
        {
            InitializeComponent();
            this.WelcomeForm = WelcomeForm;
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
                CarEntity.DailyMaxKm = Double.Parse(DailyMaxKmBox.Text);
                CarEntity.CurrentKm = Double.Parse(CurrentKmBox.Text);
                CarEntity.HasAirBag = (RAC_Service.AirgBagEnum)Enum.Parse(typeof(RAC_Service.AirgBagEnum), HasAirBagCombo.SelectedItem.ToString()); // HasAirBagCombo.SelectedValue;
                CarEntity.LuggageVolume = Int32.Parse(LuggageVolumeBox.Text);
                CarEntity.NumSeats = Int32.Parse(NumSeatsBox.Text);
                CarEntity.RentPrice = Decimal.Parse(RentPriceBox.Text);


                using (var CarsSoapClient = new CarsClient())
                {
                    if (this.ActiveMod == FormModEnum.Create)
                    {
                        CarsSoapClient.CreateCar(CarEntity);
                        MessageBox.Show(this.EntityTitle + " Saved Successfully");
                    } else
                    {
                        CarEntity.ID = this.ActiveEntity.CarID;
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
                EntityGridView.DataSource = null;

                using (var carManager = new CarManager())
                {
                    // Get cars from business layer (Core App)
                    List<Cars> cars = carManager.SelectAll();
                    EntityList = cars;

                    EntityGridView.DataSource = EntityList;
                    EntityGridView.Columns["ID"].DisplayIndex = 0;
                }

                //using (var CarsSoapClient = new CarsClient())
                //{
                //    Car[] list = CarsSoapClient.ListCars(null);
                //    EntityList = new List<Car>(list);
                //    //foreach (Car car in list)
                //    //{

                //    //    EntityList.Add(car);
                //    //}
                    
                //    EntityGridView.DataSource = EntityList;
                //    EntityGridView.Columns["ID"].DisplayIndex = 0;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
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

        private void EntityGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (EntityGridView.Rows.Count != EntityList.Count)
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
                    CarsSoapClient.DeleteCar(this.ActiveEntity.CarID);
                    
                    EntityList.Remove(ActiveEntity);
                    this.ClearActiveEntity();
                    EntityGridView.DataSource = null;
                    EntityGridView.DataSource = EntityList;

                    MessageBox.Show("Car Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void ClearActiveEntity()
        {
            this.ActiveEntity = null;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.ActiveEntity = EntityList.Find(x => x.CarID == ActiveEntity.CarID);
        
            this.PopulateTheForm();
        }

        private void CancelUpdateBtn_Click(object sender, EventArgs e)
        {
            this.SetFormMod(FormModEnum.Create);
            this.ResetTheForm(FormGroupBox);
        }

        private void PopulateTheForm()
        {
            BrandBox.Text = ActiveEntity.Brand;
            ModelBox.Text = ActiveEntity.Model;
            LicenceAgeBox.Text = ActiveEntity.CarLicenceAge.ToString();
            DriverAgeBox.Text = ActiveEntity.CarDriverAge.ToString();
            DailyMaxKmBox.Text = ActiveEntity.DailyKm.ToString();
            CurrentKmBox.Text = ActiveEntity.CurrentKm.ToString();
            HasAirBagCombo.SelectedIndex = HasAirBagCombo.FindStringExact(ActiveEntity.HasAirbag.ToString());
            LuggageVolumeBox.Text = ActiveEntity.LuggageValume.ToString();
            NumSeatsBox.Text = ActiveEntity.NumSeats.ToString();
            RentPriceBox.Text = ActiveEntity.RentPrice.ToString();

            this.SetFormMod(FormModEnum.Update);
        }

        public void ResetTheForm(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
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
            if(EntityGridView.Rows.Count < 1)
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
                this.ActiveEntity = EntityList.Find(x => x.CarID == CarId);
                DeleteBtn.Enabled = true;
                UpdateBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void CarsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.WelcomeForm.Visible = true;
        }
    }
}
