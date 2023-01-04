using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagment.Interfaces;
using System.Data.SQLite;
using InventoryManagment.Forms;

namespace InventoryManagment
{
    public partial class Form1 : Form
    {
        private ProductController Pcontroller = new ProductController();
        public Form1()
        {
            InitializeComponent();
            Pcontroller.updateProductDataGrid(dataGridView);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxDeleteID.Text);
            Pcontroller.deleteProduct(Id);
            Pcontroller.updateProductDataGrid(dataGridView);
        }
        //will use get method to get the product and it will take it as a product with dapper then it 
        //will change the product and then the original product in the database will be edited
        //alternatively and easily we can only edit the database but there is no dapper :(
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(textBoxEditID.Text);
            string input = textBoxInput.Text;
            string attribute = textBoxAttribute.Text;
            Pcontroller.editProduct(Id, input, attribute);
            Pcontroller.updateProductDataGrid(dataGridView);
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            int quantity = Convert.ToInt32(textBoxQuantity.Text);
            int price = Convert.ToInt32(textBoxPrice.Text);
            string category = comboBoxCategory.Text;


            if ( !(Pcontroller.addProduct(name, price, quantity, category) ))
            {
                System.Windows.Forms.MessageBox.Show("bir sıkıntı oldu product eklerken");
            }
            if( !(Pcontroller.updateProductDataGrid(dataGridView)))
            {
                System.Windows.Forms.MessageBox.Show("offf2 yeter");
            }; 

        }

        private void buttonCustomerForm_Click(object sender, EventArgs e)
        {
            var frm = new Customers();
            changeScreen(frm);
        }

        private void buttonOrdersForm_Click(object sender, EventArgs e)
        {
            Form frm = new Orders();
            changeScreen(frm);
        }

        private void changeScreen(Form newform)
        {
            newform.Location = this.Location;
            newform.StartPosition = FormStartPosition.Manual;
            newform.FormClosing += delegate { this.Show(); };
            newform.Show();
            this.Hide();
        }

        private void buttonProfits_Click(object sender, EventArgs e)
        {
            Form frm = new Features();
            changeScreen(frm);
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            Pcontroller.updateProductDataGrid(dataGridView);
        }
    }
}
