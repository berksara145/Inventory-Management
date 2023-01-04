using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
using InventoryManagment.Repositories;

namespace InventoryManagment
{
    public class UnitOfWork :IDisposable
    {
        private SQLiteTransaction _Transact;
        private SQLiteConnection _Connection;
        public CustomerRepository CustomerRepo;
        public ProductRepository ProductRepo;
        public OrderRepository OrderRepo;
        public HistoryRepository HistoryRepo;
        public UnitOfWork()
        {
            _Connection = new SQLiteConnection(@"URI=file:C:\Users\berk.sara\source\repos\InventoryManagment\InventoryManagment\database.db");
            _Connection.Open();
            ProductRepo = new ProductRepository(_Connection);
            CustomerRepo = new CustomerRepository(_Connection);
            OrderRepo = new OrderRepository(_Connection);
            HistoryRepo = new HistoryRepository(_Connection);
        }
        public void openConnection()
        {
            if (_Connection.State == System.Data.ConnectionState.Closed)
            {
                _Connection.Open();
            }
        }
        public void beginTransaction()
        {
            _Transact = _Connection.BeginTransaction();
        }

        public void closeConnection()
        {
            if (_Connection.State == System.Data.ConnectionState.Open)
            {
                _Connection.Close();
            }
        }
        public void Commit()
        {
            try
            {
                _Transact.Commit();
                Console.WriteLine("Both records are written to database.");
            }
            catch (Exception e)
            {
                _Transact.Rollback();
                Console.WriteLine(e.ToString());
                Console.WriteLine("Neither record was written to database.");
            }
            finally
            {
                _Connection.Close();
            }
        }

        public void RollBack()
        {
            if(_Transact != null)
            {
                _Transact.Rollback();
                _Connection.Close();
            }
        }

        
        public void Dispose()
        {
            if (_Connection != null)
            {
                if (_Connection.State == System.Data.ConnectionState.Open)
                {
                    _Connection.Close();
                }
                _Connection.Dispose();
                _Connection = null;
            }
        }
        
    }
}
