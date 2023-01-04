using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment
{
    public interface IRepository<T>
    {
        void Update(T entity);
        void Delete(long ID);
        void Insert(T entity);
        BaseEntity Get(long ID);
        bool isThereAny(int ID);

    }
}
