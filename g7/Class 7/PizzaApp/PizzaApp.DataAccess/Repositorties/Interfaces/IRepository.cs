using System.Collections.Generic;

namespace PizzaApp.DataAccess.Repositorties.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        bool Save(T entity);
        bool Edit(T entity);
        bool Delete(T entity);
    }
}
