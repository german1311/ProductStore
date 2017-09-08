using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        IEnumerable<T> GetByFilter(Func<T, IEnumerable<T>> func);

        bool Save(T model);

        bool Delete(T model);

        bool Update(T model);
    }
}
