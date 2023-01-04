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

namespace InventoryManagment.Forms
{
    public partial class Orders : Form
    {
        private OrderController Ocontroller;
        public Orders()
        {
            InitializeComponent();
            Ocontroller = new OrderController();
            Ocontroller.updateOrderDataGrid(dataGridView);
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int customerID = Convert.ToInt32(textBoxCustomerID.Text);
            int productID = Convert.ToInt32(textBoxPoductID.Text);
            int payment = Convert.ToInt32(textBoxPayment.Text); 
            int productQuantity = Convert.ToInt32(textBoxProductQuantity.Text);

            if (!(Ocontroller.addOrder(name,customerID, productID, productQuantity, payment)))
            {
                System.Windows.Forms.MessageBox.Show("bir sıkıntı oldu order eklerken");
            }
            if (!(Ocontroller.updateOrderDataGrid(dataGridView)))
            {
                System.Windows.Forms.MessageBox.Show("offf2 yeter");
            };
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxDeleteID.Text);
            Ocontroller.deleteOrder(Id);
            Ocontroller.updateOrderDataGrid(dataGridView);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxEditID.Text);
            string input = textBoxInput.Text;
            string attribute = textBoxAttribute.Text;
            Ocontroller.editOrder(Id, input, attribute);
            Ocontroller.updateOrderDataGrid(dataGridView);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Orders_Load(object sender, EventArgs e)
        {

        }
        private void buttonShipOrder_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxShipID.Text);
            Ocontroller.shipOrder(Id);
            lblProfitDisplay.Text = Ocontroller.Profit.ToString();
            Ocontroller.updateOrderDataGrid(dataGridView);
        }
    }
}
