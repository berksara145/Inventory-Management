using InventoryManagment.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment
{
    public partial class Customers : Form
    {
        private CustomerController Ccontroller;
        public Customers()
        {
            InitializeComponent();
            Ccontroller = new CustomerController();
            Ccontroller.updateCustomerDataGrid(dataGridView);
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            long phone = Convert.ToInt64(textBoxPhone.Text);
            string City = textBoxCity.Text;

            if (!(Ccontroller.addCustomer(name, phone, City)))
            {
                System.Windows.Forms.MessageBox.Show("bir sıkıntı oldu customer eklerken");
            }
            if (!(Ccontroller.updateCustomerDataGrid(dataGridView)))
            {
                System.Windows.Forms.MessageBox.Show("offf2 yeter");
            };
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxDeleteID.Text);
            Ccontroller.deleteCustomer(Id);
            Ccontroller.updateCustomerDataGrid(dataGridView);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxEditID.Text);
            string input = textBoxInput.Text;
            string attribute = textBoxAttribute.Text;
            Ccontroller.editCustomer(Id, input, attribute);
            Ccontroller.updateCustomerDataGrid(dataGridView);
        }
    }
}
