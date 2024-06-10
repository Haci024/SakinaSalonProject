using Data.Context;
using Data.DAL.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Generic
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly AppDbContext _db;
        public GenericRepository(AppDbContext db)
        {
            _db = db;
        }

        public void Create(T entity)
        {
            _db.Add<T>(entity);
            _db.SaveChanges();  
        }

        public void Delete(T entity)
        {
            _db.Remove<T>(entity);
            _db.SaveChanges();
        }

        public async Task<T> GetById(int Id)
        {
            return await _db.Set<T>().FindAsync(Id);    
        }

        public async Task<IEnumerable<T>> GetList()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public void Update(T entity)
        {
            _db.Update<T>(entity);
            _db.SaveChanges();  
        }
    }
}
