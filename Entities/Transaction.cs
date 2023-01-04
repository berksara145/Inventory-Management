using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment.Entities
{
    public class Transaction : BaseEntity
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public string Datetime { get; set; }
        public long Profit { get; set; }
        public Transaction(int orderID, string datetime, long profit)
        {
            this.OrderID = orderID;
            this.Datetime = datetime;
            this.Profit = profit;
        }
        public Transaction() { }
        public void set(string attribute, string value)
        {
            int num;
            switch (attribute.ToLower())
            {
                case "datetime":
                    Datetime = value;
                    break;
                case "orderıd":
                    if (!(int.TryParse(value, out num)))
                    {
                        OrderID = 0;
                        System.Windows.Forms.MessageBox.Show("quantity is now 0");
                    }
                    else { OrderID = num; }
                    break;
                case "profit":
                    if (!(int.TryParse(value, out num)))
                    {
                        Profit = 0;
                        System.Windows.Forms.MessageBox.Show("price is now 0");
                    }
                    else { Profit = num; }
                    break;
                case "ıd":
                    if (!(int.TryParse(value, out num)))
                    {
                        ID = 0;
                        System.Windows.Forms.MessageBox.Show("price is now 0");
                    }
                    else { ID = num; }
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Pleae input a valid feature");
                    break;
            }
        }
    }
}
