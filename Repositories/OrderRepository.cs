using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using InventoryManagment.Interfaces;
using InventoryManagment.Entities;
using Dapper;
using System.Data;

namespace InventoryManagment.Repositories
{
    public class OrderRepository: Repository<InventoryManagment.Entities.Order>, IOrderRepository
    {
        public OrderRepository(SQLiteConnection connection) : base(connection)
        {

        }
        public override void Delete(long ID)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "DELETE FROM Orders WHERE ID=@ID;";
                com.Parameters.AddWithValue("@ID", ID);
                com.ExecuteNonQuery();

                com.Clone();
                com = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("delete sıkıntı abi");
            }

        }
        public override void Insert(Order product)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "INSERT INTO Orders(name, customerID, productID , productQuantity, paymentValue)" +
                    "VALUES(@name, @CustomerID, @ProductID, @ProductQuantity, @PaymentValue);";
                com.Parameters.AddWithValue("@name", product.name);
                com.Parameters.AddWithValue("@CustomerID", product.CustomerID);
                com.Parameters.AddWithValue("@ProductID", product.ProductID);
                com.Parameters.AddWithValue("@ProductQuantity", product.ProductQuantity);
                com.Parameters.AddWithValue("@PaymentValue", product.PaymentValue);
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

        public override BaseEntity Get(long ID)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                var orders = _Connection.Query<Order>("SELECT * FROM Orders WHERE ID=@id", new { id = ID }).ToList();
                var order = orders[0];
                com.Clone();
                com = null;
                return (Order)order;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("get sıkıntı abi");
                return null;
            }
        }
        public int getOrderCount(int customerID)
        {
            using(var com = new SQLiteCommand(_Connection))
            {
                com.CommandText = "SELECT COUNT(*) FROM Orders GROUP BY customerID=@ID";
                com.Parameters.AddWithValue("@ID",customerID);
                int result = Convert.ToInt32(com.ExecuteScalar());

                return result;
            }
        }

        public override void Update(Order entity)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "UPDATE Orders SET name=@Name, customerID=@CustomerID, productID=@ProductID," +
                    "productQuantity=@ProductQuantity, paymentValue=@PaymentValue WHERE ID=@ID;";
                com.Parameters.AddWithValue("@name", entity.name);
                com.Parameters.AddWithValue("@CustomerID", entity.CustomerID);
                com.Parameters.AddWithValue("@ProductID", entity.ProductID);
                com.Parameters.AddWithValue("@ProductQuantity", entity.ProductQuantity);
                com.Parameters.AddWithValue("@PaymentValue", entity.PaymentValue);
                com.Parameters.AddWithValue("@ID", entity.Id);
                com.ExecuteNonQuery();
                com.Clone();
                com = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("update sıkıntı abi");
            }
        }
        public void createTable()
        {
            _Connection.Open();
            var com = new SQLiteCommand(_Connection);
            com.CommandText = "CREATE TABLE Orders(" +
                "ID INTEGER PRIMARY KEY," +
                "name VARCHAR(20) UNIQUE," +
                "customerID INTEGER NOT NULL," +
                "productID INTEGER NOT NULL, " +
                "productQuantity INTEGER NOT NULL," +
                "paymentValue INTEGER NOT NULL)";
            com.ExecuteNonQuery();

            com.Clone();
            com = null;
            _Connection.Close();
        }

        public DataTable getOrderTable()
        {
            string cs = "SELECT * FROM Orders";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cs, _Connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            return ds.Tables["Orders"];
        }


        public void DeleteorderTable()
        {
            _Connection.Open();
            string cs = "DROP TABLE Orders";
            SQLiteCommand cmd = new SQLiteCommand(cs, _Connection);
            cmd.ExecuteNonQuery();

            cmd.Clone();
            cmd = null;
            _Connection.Close();
        }
        public override bool isThereAny(int ID)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "SELECT EXISTS(SELECT 1 FROM Orders WHERE ID=@ID LIMIT 1);";
                com.Parameters.AddWithValue("@ID", ID);
                int result = Convert.ToInt32(com.ExecuteScalar());
                com.Clone();
                com = null;
                if (result != 0) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("öyle bir order yok abi");
                return false;
            }
        }
    }
}
