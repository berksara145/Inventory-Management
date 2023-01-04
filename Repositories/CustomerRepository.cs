using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
namespace InventoryManagment
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(SQLiteConnection connection) : base(connection)
        {

        }
        public override void Delete(long ID)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "DELETE FROM Customers WHERE ID=@ID;";
                com.Parameters.AddWithValue("@ID", ID);
                com.ExecuteNonQuery();

                com = null;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("delete sıkıntı abi");
            }

        }
        public override void Insert(Customer product)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "INSERT INTO Customers(name, phone, city)" +
                    "VALUES(@name, @Phone, @City);";
                com.Parameters.AddWithValue("@name", product.name);
                com.Parameters.AddWithValue("@Phone", product.Phone);
                com.Parameters.AddWithValue("@City", product.City);
                com.ExecuteNonQuery();

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
                var customers = _Connection.Query<Customer>("SELECT * FROM Customers WHERE ID=@id", new { id = ID }).ToList();
                var customer = customers[0];
      
                com = null;
                return (Customer)customer;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("get sıkıntı abi");
                return null;
            }
        }

        public override void Update(Customer entity)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "UPDATE Customers SET name=@Name, Phone=@Phone, City=@City " +
                    "WHERE ID=@ID;";
                com.Parameters.AddWithValue("@name", entity.name);
                com.Parameters.AddWithValue("@Phone", entity.Phone);
                com.Parameters.AddWithValue("@City", entity.City);
                com.Parameters.AddWithValue("@ID", entity.Id);
                com.ExecuteNonQuery();
 
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
            com.CommandText = "CREATE TABLE Customers(" +
                "ID INTEGER PRIMARY KEY," +
                "name VARCHAR(20) UNIQUE," +
                "phone BIGINT NOT NULL," +
                "City VARCHAR(20) NOT NULL)";
            com.ExecuteNonQuery();
            com.Clone();
            com = null;
            _Connection.Close();
        }

        public DataTable getCustomerTable()
        {
            string cs = "SELECT * FROM Customers";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cs, _Connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");
            return ds.Tables["Customers"];
        }

        public void DeleteCustomerTable()
        {
            _Connection.Open();
            string cs = "DROP TABLE Customers";
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
                com.CommandText = "SELECT EXISTS(SELECT 1 FROM Customers WHERE ID=@ID LIMIT 1);";
                com.Parameters.AddWithValue("@ID", ID);
                int result = Convert.ToInt32(com.ExecuteScalar());
                com.Clone();
                com = null;
                if (result != 0) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("öyle bir customer yok abi");
                return false;
            }
        }
        public DataTable getProfitsTable()
        {
            try
            {
                DataTable dt = new DataTable();
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "" +
                    "SELECT C.name AS Name, COUNT(O.CustomerID) AS Count ," +
                    " SUM(O.paymentValue) - SUM(P.price) * P.Quantity AS Profit " +
                    "FROM Orders AS O " +
                    "INNER JOIN Customers AS C ON C.ID=O.CustomerID " +
                    "INNER JOIN Products AS P ON P.ID= O.ProductID " +
                    "GROUP BY O.CustomerID " +
                    "ORDER BY COUNT(customerID) DESC, C.name ASC;" +
                    "";
                var rdr = com.ExecuteReader();
                dt.Load(rdr);
                com.Clone();
                com = null;
                return dt;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("valla profits gelmiyo");
                return null;
            }
            //use outer join
            //traverse function selct içinde select
            

        }
    }
}
