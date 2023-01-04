using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
using InventoryManagment.Entities;
using System.Data;

namespace InventoryManagment.Repositories
{
    public class HistoryRepository : Repository<Transaction>, IRepository<Transaction>
    {
        public HistoryRepository(SQLiteConnection connection) : base(connection) { }
        public override void Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public BaseEntity Get(long ID)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                var transactions = _Connection.Query<Transaction>("SELECT * FROM History WHERE ID=@id", new { id = ID }).ToList();
                var transaction = transactions[0];
                com = null;
                return (Transaction) transaction;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("get sıkıntı abi");
                return null;
            }
        }

        public override void Insert(Transaction entity)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "INSERT INTO History(orderID, Profit, Datetime) " +
                    "VALUES(@orderID, @profit, @Datetime);";
                com.Parameters.AddWithValue("@orderID", entity.OrderID);
                com.Parameters.AddWithValue("@profit", entity.Profit);
                com.Parameters.AddWithValue("@Datetime", entity.Datetime);
                com.ExecuteNonQuery();
                com.Clone();
                com = null;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("aynı isim olmaz alooo");
                throw;
            }
        }
        public DataTable getHistoryTable()
        {
            string cs = "SELECT * FROM History";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cs, _Connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "History");
            return ds.Tables["History"];
        }
        public bool isThereAny(int ID)
        {
            throw new NotImplementedException();
        }

        public override void Update(Transaction entity)
        {
            throw new NotImplementedException();
        }
        public void createHistoryTable()
        {
            _Connection.Open();
            using (var com = new SQLiteCommand(_Connection))
            {
                com.CommandText = "CREATE TABLE History(" +
                "ID INTEGER PRIMARY KEY, " +
                "orderID INTEGER NOT NULL, " +
                "Profit INTEGER NOT NULL, " +
                "Datetime TEXT NOT NULL)";
                com.ExecuteNonQuery();
            }
            _Connection.Close();
        }
        public void deleteHistoryTable()
        {
            //_Connection.Open();
            using (SQLiteCommand cmd = new SQLiteCommand(_Connection))
            {
                cmd.CommandText = "DROP TABLE History";
                cmd.ExecuteNonQuery();
            }
            _Connection.Close();
        }
    }
}
