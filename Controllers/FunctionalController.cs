using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace InventoryManagment.Controllers
{
    internal class FunctionalController : Controller , IDisposable
    {
        private UnitOfWork _UnitOfWork;
        public FunctionalController()
        {
            _UnitOfWork = new UnitOfWork();
        }
        //b
        public void calculateProfits(DataGridView dataGridView)
        {
            _UnitOfWork.openConnection();
            try
            {
                DataTable dt = _UnitOfWork.CustomerRepo.getProfitsTable();
                loadDataGrid(dataGridView, dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private bool loadDataGrid(DataGridView dataGridView, DataTable dt)
        {
            try
            {
                dataGridView.DataSource = dt;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool changeToCategoryTable(DataGridView dataGridView)
        {

            _UnitOfWork.openConnection();
            //_UnitOfWork.ProductRepo.createCategoryTable();
            _UnitOfWork.ProductRepo.initializeCategories();
            try
            {
                dataGridView.DataSource = _UnitOfWork.ProductRepo.getCategoryTable().DefaultView;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool changeToHistoryTable(DataGridView dataGridView)
        {
            //_UnitOfWork.HistoryRepo.deleteHistoryTable();
            //_UnitOfWork.HistoryRepo.createHistoryTable();
            _UnitOfWork.openConnection();
            try
            {
                dataGridView.DataSource = _UnitOfWork.HistoryRepo.getHistoryTable().DefaultView;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
        //b
        public bool updateProfitsDataGrid(DataGridView dataGridView)
        {
            _UnitOfWork.openConnection();
            try
            {
                dataGridView.DataSource = _UnitOfWork.ProductRepo.getProductTable().DefaultView;
                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
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
