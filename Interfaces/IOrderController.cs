using InventoryManagment.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment.Interfaces
{
    internal interface IOrderController :IController
    {
        bool addOrder(string name, int customerID, int productID, int productQuantity, int paymentValue);

        bool deleteOrder(long ID);

        bool updateOrderDataGrid(DataGridView dataGridView);

        bool editOrder(int Id, string input, string attribute);

        Order getOrder(long Id);
    }
}
