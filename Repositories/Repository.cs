using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SQLite;
using System.Data;
namespace InventoryManagment
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected SQLiteConnection _Connection;

        public Repository(SQLiteConnection connection)
        {
            this._Connection = connection;
        }

        public virtual void Delete(long ID)
        {
            throw new NotImplementedException();
        }

        public virtual BaseEntity Get(long ID)
        {
            throw new NotImplementedException();
        }

        public virtual void Insert(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual bool isThereAny(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
