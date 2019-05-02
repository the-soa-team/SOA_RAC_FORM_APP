using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOA_RAC_Form_App.Enums;
using SOA_RAC_Form_App.RAC_Service;

namespace SOA_RAC_Form_App
{
    public partial class CustomersForm : Form
    {
        Welcome WelcomeForm;
        string EntityTitle = "Customer";
        List<Customer> EntityList = new List<Customer>();
        Customer ActiveEntity;
        FormModEnum ActiveMod = FormModEnum.Create;

        public CustomersForm(Welcome WelcomeForm)
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
                Customer CustomerEntity = new Customer();

                CustomerEntity.FirstName = FirstNameBox.Text;
                CustomerEntity.LastName = LastNameBox.Text;
                CustomerEntity.EmailAddress = EmailAddressBox.Text;
                CustomerEntity.PhoneNumber = PhoneNumberBox.Text;
                CustomerEntity.LicenceAge = Int32.Parse(LicenceAgeBox.Text);
                CustomerEntity.DriverAge = Int32.Parse(DriverAgeBox.Text);


                using (var CustomersSoapClient = new CustomersClient())
                {
                    if (this.ActiveMod == FormModEnum.Create)
                    {
                        CustomersSoapClient.CreateCustomer(CustomerEntity);
                        MessageBox.Show(this.EntityTitle + " Saved Successfully");
                    } else
                    {
                        CustomerEntity.ID = this.ActiveEntity.ID;
                        CustomersSoapClient.UpdateCustomer(CustomerEntity);
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
                using (var CustomersSoapClient = new CustomersClient())
                {
                    EntityList.Clear();
                    foreach (Customer Customer in CustomersSoapClient.ListCustomers(null))
                    {

                        EntityList.Add(Customer);
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
                using (var CustomersSoapClient = new CustomersClient())
                {
                    CustomersSoapClient.DeleteCustomer(this.ActiveEntity.ID);
                    
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

        private void ClearActiveEntity()
        {
            this.ActiveEntity = null;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            this.ActiveEntity = EntityList.Find(x => x.ID == ActiveEntity.ID);
        
            this.PopulateTheForm();
        }

        private void CancelUpdateBtn_Click(object sender, EventArgs e)
        {
            this.SetFormMod(FormModEnum.Create);
            this.ResetTheForm(FormGroupBox);
        }

        private void PopulateTheForm()
        {
            FirstNameBox.Text = ActiveEntity.FirstName;
            LastNameBox.Text = ActiveEntity.LastName;
            EmailAddressBox.Text = ActiveEntity.EmailAddress;
            PhoneNumberBox.Text = ActiveEntity.PhoneNumber;
            LicenceAgeBox.Text = ActiveEntity.LicenceAge.ToString();
            DriverAgeBox.Text = ActiveEntity.DriverAge.ToString();

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
                int CustomerId = Int32.Parse(EntityGridView.SelectedRows[0].Cells["Id"].Value.ToString());
                this.ActiveEntity = EntityList.Find(x => x.ID == CustomerId);
                DeleteBtn.Enabled = true;
                UpdateBtn.Enabled = true;
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
    }
}
