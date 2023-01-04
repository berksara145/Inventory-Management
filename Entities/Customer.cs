using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment
{
    public class Customer : BaseEntity
    {
        //-ID
        public string name { get; set; }
        public long Phone { get; set; }
        public string City { get; set; }
        public Customer(string name, long phone, string City )
        {
            this.name = name;
            this.Phone = phone; 
            this.City = City;
        }
        public Customer() { }
        public void set(string attribute, string value)
        {
            int num;
            switch (attribute.ToLower())
            {
                case "name":
                    name = value;
                    break;
                case "phone":
                    if (!(int.TryParse(value, out num)))
                    {
                        Phone = 0;
                        System.Windows.Forms.MessageBox.Show("quantity is now 0");
                    }
                    else { Phone = num; }
                    break;
                case "city":
                    City = value;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Pleae input a valid feature");
                    break;
            }
        }

    }
}
