using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagment.Controllers
{
    public class CustomerController : Controller, InventoryManagment.Interfaces.ICustomerController, IDisposable
    {
        private UnitOfWork _UnitOfWork;
        public CustomerController()
        {
            _UnitOfWork = new UnitOfWork();
        }
        public bool addCustomer(string name, long phone, string city )
        {
            /*
            _UnitOfWork.CustomerRepo.DeleteCustomerTable();
            _UnitOfWork.CustomerRepo.createTable();
            */
            _UnitOfWork.openConnection();
            try
            {
                _UnitOfWork.CustomerRepo.Insert(new Customer(
                        name, phone, city
                    ));

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _UnitOfWork.closeConnection();
            }
        }
        public bool deleteCustomer(long ID)
        {
            _UnitOfWork.openConnection();
            try
            {
                _UnitOfWork.CustomerRepo.Delete(ID);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                _UnitOfWork.closeConnection();
            }
        }
        //b
        public bool updateCustomerDataGrid(DataGridView dataGridView)
        {
            _UnitOfWork.openConnection();
            try
            {
                dataGridView.DataSource = _UnitOfWork.CustomerRepo.getCustomerTable().DefaultView;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                _UnitOfWork.closeConnection();
            }
        }
        //will use get method to get the product and it will take it as a product with dapper then it 
        //will change the product and then the original product in the database will be edited
        //alternatively and easily we can only edit the database but there is no dapper :(
        public bool editCustomer(int Id, string input, string attribute)
        {
            _UnitOfWork.openConnection();
            try
            {
                _UnitOfWork.beginTransaction();
                Customer Customer = getCustomer(Id);
                if (Customer == null) { return false; }
                Customer.set(attribute, input);
                _UnitOfWork.CustomerRepo.Update(Customer);
                _UnitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                _UnitOfWork.RollBack();
                return false;
            }
        }
        public Customer getCustomer(long Id)
        {
            try
            {
                return (Customer)_UnitOfWork.CustomerRepo.Get(Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public void Dispose()
        {
            if (_UnitOfWork != null)
            {
                _UnitOfWork.Dispose();
                _UnitOfWork = null;
            }
        }
    }
}
