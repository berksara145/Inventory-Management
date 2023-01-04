using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment
{
    public abstract class BaseEntity
    {
        public BaseEntity() { }
        public long Id { get; set; }
    }
}
