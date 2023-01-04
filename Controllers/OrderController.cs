using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagment.Entities;
using InventoryManagment.Interfaces;
using System.Windows.Forms;

namespace InventoryManagment.Controllers
{
    public class OrderController : Controller, IOrderController, IDisposable
    {
        private UnitOfWork _UnitOfWork;
        private long _Profit;
        public long Profit
        {
            get { return _Profit; }
        }
        public OrderController()
        {
            _UnitOfWork = new UnitOfWork();
            _Profit = 0;
        }
        public bool addOrder(string name, int customerID, int productID, int productQuantity, int paymentValue)
        {
            /*
            _UnitOfWork.OrderRepo.DeleteorderTable();
            _UnitOfWork.OrderRepo.createTable();
            */

            //ürün kotası per customer*
            //ürün mevcut var mı*
            //üründen azalt order bitince*
            //aynanda 10 kişi isterse hallet
            //log the expection
            try
            {
                _UnitOfWork.openConnection();
                _UnitOfWork.beginTransaction();

                if (_UnitOfWork.CustomerRepo.isThereAny(customerID) && _UnitOfWork.ProductRepo.isThereAny(productID)
                    && _UnitOfWork.ProductRepo.isThereEnoughProducts(productID, productQuantity)
                    && 4 > _UnitOfWork.OrderRepo.getOrderCount(customerID) )
                {
                    _UnitOfWork.OrderRepo.Insert(new Order(
                        name, customerID, productID, productQuantity, paymentValue
                    ));
                    _UnitOfWork.Commit();

                    return true;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("abi çok order ekledin yeter");
                }
                _UnitOfWork.RollBack();
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                //ex.Message;
                _UnitOfWork.RollBack();
                return false;
            }
        }
        public bool deleteOrder(long ID)
        {
            _UnitOfWork.openConnection();
            try
            {
                _UnitOfWork.OrderRepo.Delete(ID);
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
        /// <summary>
        /// this method ships the order and earns money
        /// first it checks id then it substracts the products
        /// then it adds the profit 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>returns true if executed without error</returns>
        public bool shipOrder(int orderID)
        {
            try
            {
                _UnitOfWork.openConnection();
                _UnitOfWork.beginTransaction();

                if (_UnitOfWork.OrderRepo.isThereAny(orderID))
                {
                    Order order = (Order) _UnitOfWork.OrderRepo.Get(orderID);
                    Product product = (Product) _UnitOfWork.ProductRepo.Get(order.ProductID);

                    product.Quantity -= order.ProductQuantity;
                    int totalPrice = order.ProductQuantity * product.Price;
                    order.PaymentValue -= totalPrice;
                    _Profit += order.PaymentValue;

                    _UnitOfWork.OrderRepo.Delete(orderID);
                    _UnitOfWork.ProductRepo.Update(product);

                    DateTime dtime = DateTime.Now;
                    _UnitOfWork.HistoryRepo.Insert( new Transaction(
                            orderID, dtime.ToString(), _Profit)
                        );

                    _UnitOfWork.Commit();
                    return true;
                }
                _UnitOfWork.RollBack();
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                //ex.Message;
                _UnitOfWork.RollBack();
                return false;
            }
        }
        private bool addTransaction()
        {
            return true;
        }
        public bool updateOrderDataGrid(DataGridView dataGridView)
        {
            _UnitOfWork.openConnection();
            try
            {
                dataGridView.DataSource = _UnitOfWork.OrderRepo.getOrderTable().DefaultView;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally { _UnitOfWork.closeConnection(); }
        }
        //will use get method to get the product and it will take it as a product with dapper then it 
        //will change the product and then the original product in the database will be edited
        //alternatively and easily we can only edit the database but there is no dapper :(
        public bool editOrder(int Id, string input, string attribute)
        {
            _UnitOfWork.openConnection();
            try
            {
                _UnitOfWork.beginTransaction();
                Order order = getOrder(Id);
                if (order == null) { return false; }
                order.set(attribute, input);
                _UnitOfWork.OrderRepo.Update(order);
                _UnitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                _UnitOfWork.RollBack();
                return false;
            }
        }

        public Order getOrder(long Id)
        {
            try
            {
                return (Order)_UnitOfWork.OrderRepo.Get(Id);
            }
            catch (Exception ex)
            {
                _UnitOfWork.RollBack();
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
