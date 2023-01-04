using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment.Entities
{
    public class Order : BaseEntity
    {
        public string name { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public int ProductQuantity { get; set; }
        public int PaymentValue { get; set; }
        public Order(string name, int customerID, int productID, int productQuantity, int paymentValue) 
        {
            this.name = name;
            this.CustomerID = customerID;
            this.ProductQuantity = productQuantity;
            this.PaymentValue = paymentValue;
            this.ProductID = productID;
        }
        public Order() { }
        public void set(string attribute, string value)
        {
            int num;
            switch (attribute.ToLower())
            {
                case "name":
                    name = value;
                    break;
                case "customerıd":
                    if (!(int.TryParse(value, out num)))
                    {
                        CustomerID = 0;
                        System.Windows.Forms.MessageBox.Show("quantity is now 0");
                    }
                    else { CustomerID = num; }
                    break;
                case "productıD":
                    if (!(int.TryParse(value, out num)))
                    {
                        ProductID = 0;
                        System.Windows.Forms.MessageBox.Show("price is now 0");
                    }
                    else { ProductID = num; }
                    break;
                case "productQuantity":
                    if (!(int.TryParse(value, out num)))
                    {
                        ProductQuantity = 0;
                        System.Windows.Forms.MessageBox.Show("price is now 0");
                    }
                    else { ProductQuantity = num; }
                    break;
                case "paymentValue":
                    if (!(int.TryParse(value, out num)))
                    {
                        PaymentValue = 0;
                        System.Windows.Forms.MessageBox.Show("price is now 0");
                    }
                    else { PaymentValue = num; }
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Pleae input a valid feature");
                    break;
            }
        }
    }
}
