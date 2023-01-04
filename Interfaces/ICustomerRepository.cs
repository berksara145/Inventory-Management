using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace InventoryManagment
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        DataTable getCustomerTable();
        void DeleteCustomerTable();
    }
}
