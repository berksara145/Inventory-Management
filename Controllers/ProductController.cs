using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace InventoryManagment
{
    public class ProductController : Controller , InventoryManagment.Interfaces.IProductController, IDisposable
    {
        private UnitOfWork _UnitOfWork;
        public ProductController()
        {
            _UnitOfWork = new UnitOfWork();
        }
        public bool addProduct(string name, int price, int quantity, string Category)
        {
            /*
            _UnitOfWork.ProductRepo.DeleteproductTable();
            _UnitOfWork.ProductRepo.createTable();
            */
            _UnitOfWork.openConnection();
            try
            {
                _UnitOfWork.ProductRepo.Insert(new Product(
                        name, price, quantity, Category
                    ));
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { _UnitOfWork.closeConnection(); }
        }
        public bool deleteProduct(long ID)
        {
            _UnitOfWork.openConnection();
            try
            {
                _UnitOfWork.ProductRepo.Delete(ID);
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            finally { _UnitOfWork.closeConnection(); }
        }
        public bool updateProductDataGrid(DataGridView dataGridView)
        {
            _UnitOfWork.openConnection();
            try
            {
                dataGridView.DataSource = _UnitOfWork.ProductRepo.getProductTable().DefaultView;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally { _UnitOfWork.closeConnection(); }
        }
        //will use get method to get the product and it will take it as a product with dapper then it 
        //will change the product and then the original product in the database will be edited
        //alternatively and easily we can only edit the database but there is no dapper :(
        public bool editProduct(int Id, string input, string attribute)
        {
            try
            {
                _UnitOfWork.openConnection();
                _UnitOfWork.beginTransaction();
                Product product = getProduct(Id);
                if(product == null) { return false; }
                product.set(attribute, input);
                _UnitOfWork.ProductRepo.Update(product);
                _UnitOfWork.Commit();
                return true;
            }
            catch (Exception ex)
            {
                _UnitOfWork.RollBack();
                return false;
            }
        }

        private Product getProduct(long Id)
        {
            try
            {
                return (Product)_UnitOfWork.ProductRepo.Get(Id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public void Dispose()
        {
            if( _UnitOfWork != null)
            {
                _UnitOfWork.Dispose();
                _UnitOfWork = null;
            }
        }
        
    }
}
