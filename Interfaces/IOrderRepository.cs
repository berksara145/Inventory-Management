﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment.Interfaces
{
    internal interface IOrderRepository : IRepository<InventoryManagment.Entities.Order>
    {
    }
}