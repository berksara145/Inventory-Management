using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment.Interfaces
{
    internal interface ICustomerController : IController
    {
        bool addCustomer(string name, long phone, string city);

        bool deleteCustomer(long ID);

        bool updateCustomerDataGrid(DataGridView dataGridView);

        bool editCustomer(int Id, string input, string attribute);

        Customer getCustomer(long Id);
        
    }
}
