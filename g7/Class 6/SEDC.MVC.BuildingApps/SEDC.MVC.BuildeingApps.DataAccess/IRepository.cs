using System.Collections.Generic;

namespace SEDC.MVC.BuildeingApps.DataAccess
{
    public interface IRepository<T>
    {
        void Insert(T entity);
        List<T> GetAll();
        void Update(T entity);
        void DeleteById(int id);
    }
}
