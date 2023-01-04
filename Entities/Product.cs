using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment
{
    public class Product : BaseEntity
    {
        //System.Int64 ID, System.String name, System.Int64 price, System.Int64 quantity, System.String category
        public Product(string name, int Price, int Quantity, string Category) 
        {
            this.name = name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Category = Category;
        }
        public Product() {  }

        public string name { get; set; }
        public int Price { get; set; }

        public string Category { get; set; }
        public int Quantity { get; set; }

        public void set(string attribute, string value)
        {
            int num;
            switch (attribute.ToLower())
            {
                case "name":
                    name = value;
                    break;
                case "quantity":
                    if( !(int.TryParse(value, out num) ))
                    {
                        Quantity = 0;
                        System.Windows.Forms.MessageBox.Show("quantity is now 0");
                    }
                    else { Quantity = num; }
                    break;
                case "category":
                    Category = value;
                    break;
                case "price":
                    if (!(int.TryParse(value, out num)))
                    {
                        Price = 0;
                        System.Windows.Forms.MessageBox.Show("price is now 0");
                    }
                    else { Price = num; }
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Pleae input a valid feature");
                    break;
            }
        }
    }
}
