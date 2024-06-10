using Business.Services;
using Data.Services.EntityService;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
	public class LazerCategoryManager : ILazerCategoryService
	{
		private readonly ILazerCategoryDAL _dal;
        public LazerCategoryManager(ILazerCategoryDAL dal)
		{
			_dal = dal;
		}
		public void Create(LazerCategory entity)
		{
			_dal.Create(entity);	
		}

		public void Delete(LazerCategory entity)
		{
			_dal.Delete(entity);
		}

		public Task<LazerCategory> GetById(int Id)
		{
			return _dal.GetById(Id);	
		}

		public Task<IEnumerable<LazerCategory>> GetList()
		{
			return _dal.GetList();
		}

		public void Update(LazerCategory entity)
		{
			 _dal.Update(entity);
		}
	}
}
