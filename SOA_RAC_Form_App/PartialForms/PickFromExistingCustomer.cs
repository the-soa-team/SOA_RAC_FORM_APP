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
    public partial class PickFromExistingCustomers : Form
    {
        public Customer SelectedCustomer = null;
        List<Customer> EntityList = new List<Customer>();

        public PickFromExistingCustomers()
        {
            InitializeComponent();
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var CustomersSoapClient = new CustomersClient())
                {
                    CustomerRequest CustomerRequest = new CustomerRequest();

                    if (FirstNameBox.Text != "")
                    {
                        CustomerRequest.FirstName = FirstNameBox.Text;
                    }
                    if (LastNameBox.Text != "")
                    {
                        CustomerRequest.LastName = LastNameBox.Text;
                    }
                    if (EmailBox.Text != "")
                    {
                        CustomerRequest.EmailAddress = EmailBox.Text;
                    }

                    EntityList.Clear();
                    foreach (Customer customer in CustomersSoapClient.ListCustomers(CustomerRequest))
                    {
                        EntityList.Add(customer);
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
                this.SelectedCustomer = EntityList.Find(x => x.ID == CarId);
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
    }
}
