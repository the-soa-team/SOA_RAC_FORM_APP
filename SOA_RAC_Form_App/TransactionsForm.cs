using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.Bll.Concretes;
using RentACar.Model.EntityModels;
using SOA_RAC_Form_App.Enums;
using SOA_RAC_Form_App.PartialForms;
using SOA_RAC_Form_App.RAC_Service;

namespace SOA_RAC_Form_App
{
    public partial class TransactionsForm : Form
    {
        Welcome WelcomeForm;
        string EntityTitle = "Customer";
        List<Transactions> EntityList = new List<Transactions>();
        Transactions ActiveEntity;
        FormObject FormObject = new FormObject();
        FormModEnum ActiveMod = FormModEnum.Create;
        PickFromAvailableCars PickFromAvailableCars = new PickFromAvailableCars();
        PickFromExistingCustomers PickFromExistingCustomers = new PickFromExistingCustomers();
        Car SelectedCar = null;
        Customer SelectedCustomer = null;


        public TransactionsForm(Welcome WelcomeForm)
        {
            InitializeComponent();
            this.WelcomeForm = WelcomeForm;
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            this.SetFormMod(FormModEnum.Create);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {

                this.ReadTheForm();

                if(FormObject.Customer == null || FormObject.Car == null || FormObject.DateBegin == null || FormObject.NumDays == 0)
                {
                    MessageBox.Show("Please fill all the input");
                    return;
                }

                using (var TransactionSoapClient = new TransactionsClient())
                {
                    TransactionSoapClient.CreateTransaction(FormObject.Customer, FormObject.Car, FormObject.DateBegin, FormObject.NumDays);
                    MessageBox.Show(this.EntityTitle + " Saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void ReadTheForm()
        {
            int r;
            if (this.SelectedCustomer != null)
            {
                FormObject.Customer = this.SelectedCustomer;
            }
            else
            {
                FormObject.Customer.FirstName = FirstNameBox.Text;
                FormObject.Customer.LastName = LastNameBox.Text;
                FormObject.Customer.EmailAddress = EmailAddressBox.Text;
                FormObject.Customer.PhoneNumber = PhoneNumberBox.Text;
                Int32.TryParse(LicenceAgeBox.Text, out r);
                FormObject.Customer.LicenceAge = r;
                Int32.TryParse(DriverAgeBox.Text, out r);
                FormObject.Customer.DriverAge = r;
            }

            FormObject.Car = this.SelectedCar;

            FormObject.DateBegin = DateTime.Parse(DateTimePicker.Text);
            Int32.TryParse(NumDaysBox.Text, out r);
            FormObject.NumDays = r;
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            try
            {

                using (var transactionManager = new TransactionManager())
                {
                    EntityList.Clear();
                    // Get cars from business layer (Core App)
                    List<Transactions> transactions = transactionManager.SelectAll();
                    EntityList = transactions;

                    EntityGridView.DataSource = null;
                    EntityGridView.DataSource = EntityList;
                    EntityGridView.Columns["TransactionID"].DisplayIndex = 0;
                }

                //using (var TransactionsClient = new TransactionsClient())
                //{
                //    EntityList.Clear();
                //    foreach (Transaction Transaction in TransactionsClient.ListTransactions(null))
                //    {

                //        EntityList.Add(Transaction);
                //    }
                    
                //    EntityGridView.DataSource = null;
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

        private void ClearActiveEntity()
        {
            this.ActiveEntity = null;
        }

        private void CancelUpdateBtn_Click(object sender, EventArgs e)
        {
            this.SetFormMod(FormModEnum.Create);
            this.ResetTheForm(FormGroupBox);
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
            }
            else
            {
                FormGroupBox.Text = "UPDATE " + EntityTitle;
                SaveBtn.Text = "Update A " + EntityTitle;
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
                int CustomerId = Int32.Parse(EntityGridView.SelectedRows[0].Cells["TransactionID"].Value.ToString());
                this.ActiveEntity = EntityList.Find(x => x.TransactionID == CustomerId);
                CompleteBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }

        private void CustomersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.WelcomeForm.Visible = true;
        }

        private void CustomersForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            this.WelcomeForm.Visible = true;
        }

        private void AvilableCarsBtn_Click(object sender, EventArgs e)
        {
            this.ReadTheForm();
            Console.WriteLine(FormObject.DateBegin);

            if (FormObject.LicenceAge == 0 || FormObject.DriverAge == 0 || FormObject.DateBegin == null || FormObject.NumDays == 0)
            {
                MessageBox.Show("Please fill Licence Age, Drive Age, Pickup Date and Numbe of Days");
                return;
            }

            this.PickFromAvailableCars.SetFilterValues(FormObject.LicenceAge, FormObject.DriverAge, FormObject.DateBegin, FormObject.NumDays);
            this.PickFromAvailableCars.ShowDialog();

            if(this.PickFromAvailableCars.SelectedCar != null)
            {
                this.SetSelectedCar(this.PickFromAvailableCars.SelectedCar);
            } else
            {
                MessageBox.Show("You haven't select any car.");
            }
        }

        private void SelectCustomerBtn_Click(object sender, EventArgs e)
        {
            this.PickFromExistingCustomers.ShowDialog();

            if(this.PickFromExistingCustomers.SelectedCustomer != null)
            {
                this.SelectedCustomer = this.PickFromExistingCustomers.SelectedCustomer;
                this.PopulateSelectedCustomer();
                DeselectBtn.Enabled = true;
            }
        }

        private void DeselectBtn_Click(object sender, EventArgs e)
        {
            this.ClearSelectedCar();
            this.SelectedCustomer = null;
        }

        private void SetSelectedCar(Car Car)
        {
            this.SelectedCar = Car;
            SelectedCarLbl.Text = Car.Brand + ", " + Car.Model + ", " + Car.NumSeats + " Seats, " + Car.LuggageVolume + " lt Luggage, $" + Car.RentPrice + " per day";
        }

        private void ClearSelectedCar()
        {
            this.SelectedCar = null;
            SelectedCarLbl.Text = "";
        }
        
        private void PopulateSelectedCustomer()
        {
            this.FirstNameBox.Text = this.SelectedCustomer.FirstName;
            this.FirstNameBox.ReadOnly = true;
            this.LastNameBox.Text = this.SelectedCustomer.LastName;
            this.LastNameBox.ReadOnly = true;
            this.EmailAddressBox.Text = this.SelectedCustomer.EmailAddress;
            this.EmailAddressBox.ReadOnly = true;
            this.PhoneNumberBox.Text = this.SelectedCustomer.PhoneNumber;
            this.PhoneNumberBox.ReadOnly = true;
            this.LicenceAgeBox.Text = this.SelectedCustomer.LicenceAge.ToString();
            this.LicenceAgeBox.ReadOnly = true;
            this.DriverAgeBox.Text = this.SelectedCustomer.DriverAge.ToString();
            this.DriverAgeBox.ReadOnly = true;
        }

        private void CompleteBtn_Click(object sender, EventArgs e)
        {
            if(ReturnKmBox.Text == "")
            {
                MessageBox.Show("Please enter the 'Return KM' value");
                return;
            }

            try
            {
                using (var TransactionsClient = new TransactionsClient())
                {
                    int r;
                    Int32.TryParse(ReturnKmBox.Text, out r);
                    this.ActiveEntity.ReturnKm = r;
                    //TransactionsClient.UpdateTransaction(this.ActiveEntity);

                    EntityList.Remove(ActiveEntity);
                    this.ClearActiveEntity();
                    EntityGridView.DataSource = null;
                    EntityGridView.DataSource = EntityList;

                    MessageBox.Show("Customer Deleted Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error happened: " + ex.Message);
            }
        }
    }

    class FormObject : Customer
    {
        public Customer Customer;
        public Car Car;
        public DateTime DateBegin;
        public int NumDays;

    }
}
