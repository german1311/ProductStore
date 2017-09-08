using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore.Repository.Interfaces;
using ProductStore.Repository.Models;

namespace ProductStore.Data.Memory
{
    public class CategoryRepository : ICategoryRespository
    {
        public IEnumerable<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetByFilter(Func<Category, IEnumerable<Category>> func)
        {
            throw new NotImplementedException();
        }

        public bool Save(Category model)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Category model)
        {
            throw new NotImplementedException();
        }

        public bool Update(Category model)
        {
            throw new NotImplementedException();
        }
    }
}
