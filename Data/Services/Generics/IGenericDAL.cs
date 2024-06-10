using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Generics
{
    public interface IGenericDAL<T> where T : class
    {
        public  Task<T> GetById(int Id);
        public Task<IEnumerable<T>> GetList();
        void Update(T entity);
        void Delete(T entity);
        void Create(T entity);

    }
}
