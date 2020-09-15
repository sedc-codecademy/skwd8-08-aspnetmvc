using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.WebApp.ModelDemo.DataAccess.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        T GetById(int id);
        int Create(T entity);
        int Update(T entity);
        int Delete(int id);
    }
}
