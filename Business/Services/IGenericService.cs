using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
	public interface IGenericService<T> where T : class
	{
		public Task<T> GetById(int Id);
		public Task<IEnumerable<T>> GetList();
		void Update(T entity);
		void Delete(T entity);
		void Create(T entity);
	}
}
