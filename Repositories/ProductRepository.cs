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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SQLiteConnection connection) : base(connection)
        {

        }

        public override void Delete(long ID)
        {
            try
            {
                using (var com = new SQLiteCommand(_Connection))
                {
                    com.CommandText = "DELETE FROM Products WHERE ID=@ID;";
                    com.Parameters.AddWithValue("@ID", ID);
                    var result = com.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("delete ıskıntı abi");
            }

        }
        public override void Insert(Product product)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "INSERT INTO Products(name, price, quantity, category) " +
                    "VALUES(@name, @price, @quantity, @category);";
                com.Parameters.AddWithValue("@name", product.name);
                com.Parameters.AddWithValue("@price", product.Price);
                com.Parameters.AddWithValue("@quantity", product.Quantity);
                com.Parameters.AddWithValue("@category", product.Category);
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
                var products = _Connection.Query<Product>("SELECT * FROM Products WHERE ID=@id", new { id = ID }).ToList();
                var product = products[0];
                com.Clone();
                com = null;
                return (Product)product;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("get sıkıntı abi");
                return null;
            }
        }

        public override void Update(Product entity)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "UPDATE Products SET name=@name, price=@price, quantity=@quantity, category=@category WHERE ID=@ID;";
                com.Parameters.AddWithValue("@name", entity.name);
                com.Parameters.AddWithValue("@price", entity.Price);
                com.Parameters.AddWithValue("@quantity", entity.Quantity);
                com.Parameters.AddWithValue("@category", entity.Category);
                com.Parameters.AddWithValue("@ID", entity.Id);
                com.ExecuteNonQuery();
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
            com.CommandText = "CREATE TABLE Products(" +
                "ID INTEGER PRIMARY KEY," +
                "name VARCHAR(20) UNIQUE," +
                "price INTEGER NOT NULL," +
                "quantity INTEGER NOT NULL, " +
                "category VARCHAR(20) NOT NULL)";
            com.ExecuteNonQuery();

            com.Clone();
            com = null;
            _Connection.Close();
        }

        public void createCategoryTable()
        {
            //_Connection.Open();
            using(var com = new SQLiteCommand(_Connection))
            {
                com.CommandText = "CREATE TABLE Category(" +
               "ID INTEGER PRIMARY KEY," +
               "name INTEGER NOT NULL," +
               "parentID VARCHAR(20) NOT NULL)";
                com.ExecuteNonQuery();
            }
            _Connection.Close();
        }

        public DataTable getCategoryTable()
        {
            string cs = "SELECT * FROM Category";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cs, _Connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Category");
            return ds.Tables["Category"];
        }
        public int howManyItemsInCategories()
        {
            using (var com = new SQLiteCommand(_Connection))
            {
                com.CommandText = "";
                com.ExecuteNonQuery();
            }
        }
        public void initializeCategories()
        {
            using (var com = new SQLiteCommand(_Connection))
            {
                com.CommandText = "INSERT INTO Category(name, parentID) VALUES(@name, @parentID)";
                com.Parameters.AddWithValue("@name", "foods");
                com.Parameters.AddWithValue("@parentID", "-1");
                com.ExecuteNonQuery();

                com.CommandText = "INSERT INTO Category(name, parentID) VALUES(@name, @parentID)";
                com.Parameters.AddWithValue("@name", "meyve");
                com.Parameters.AddWithValue("@parentID", "1");
                com.ExecuteNonQuery();

                com.CommandText = "INSERT INTO Category(name, parentID) VALUES(@name, @parentID)";
                com.Parameters.AddWithValue("@name", "sebze");
                com.Parameters.AddWithValue("@parentID", "1");
                com.ExecuteNonQuery();

                com.CommandText = "INSERT INTO Category(name, parentID) VALUES(@name, @parentID)";
                com.Parameters.AddWithValue("@name", "kuruMeyve");
                com.Parameters.AddWithValue("@parentID", "2");
                com.ExecuteNonQuery();

                com.CommandText = "INSERT INTO Category(name, parentID) VALUES(@name, @parentID)";
                com.Parameters.AddWithValue("@name", "TazeMeyve");
                com.Parameters.AddWithValue("@parentID", "2");
                com.ExecuteNonQuery();

                com.CommandText = "INSERT INTO Category(name, parentID) VALUES(@name, @parentID)";
                com.Parameters.AddWithValue("@name", "kuruSebze");
                com.Parameters.AddWithValue("@parentID", "3");
                com.ExecuteNonQuery();

                com.CommandText = "INSERT INTO Category(name, parentID) VALUES(@name, @parentID)";
                com.Parameters.AddWithValue("@name", "TazeSebze");
                com.Parameters.AddWithValue("@parentID", "3");
                com.ExecuteNonQuery();
            }
            _Connection.Close();
        }
        public void deleteCategoryTable()
        {
            _Connection.Open();
            string cs = "DROP TABLE Category";
            using (var cmd = new SQLiteCommand(cs, _Connection)) {
                cmd.ExecuteNonQuery();
            }
            _Connection.Close();
        }

        public DataTable getProductTable()
        {
            string cs = "SELECT * FROM Products";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cs, _Connection);
            DataSet ds = new DataSet();
            da.Fill(ds, "Products");
            return ds.Tables["Products"];
        }


        public void DeleteproductTable()
        {
            _Connection.Open();
            string cs = "DROP TABLE Products";
            SQLiteCommand cmd = new SQLiteCommand(cs, _Connection);
            cmd.ExecuteNonQuery();

            cmd = null;
            _Connection.Close();
        }
        public bool isThereEnoughProducts(int productID, int quantity)
        {
            try
            {
                using (var com = new SQLiteCommand(_Connection))
                {
                    com.CommandText = "SELECT quantity FROM Products WHERE ID=@ID;";
                    com.Parameters.AddWithValue("@ID", productID);
                    com.Prepare();
                    int result = Convert.ToInt32(com.ExecuteScalar());
                    bool solution = result < quantity ? false : true;
                    if (!solution)
                    {
                        System.Windows.Forms.MessageBox.Show("yeterli productt yok abi");
                    }
                    return solution;
                }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("yeterli productt yok abi");
                return false;
            }

        }

        public override bool isThereAny(int ID)
        {
            try
            {
                var com = new SQLiteCommand(_Connection);
                com.CommandText = "SELECT EXISTS(SELECT 1 FROM Products WHERE ID=@ID LIMIT 1);";
                com.Parameters.AddWithValue("@ID", ID);
                com.Prepare();
                int result = Convert.ToInt32(com.ExecuteScalar());
                com.Clone();
                com = null;
                if (result != 0) { return true; }
                else { return false; }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("öyle bir product yok abi");
                return false;
            }
        }

    }
}
