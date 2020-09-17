using SEDC.PizzaApp.DomainModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.PizzaApp.DataAccess.Repositories
{
    public interface IRepository<T>
    {
        //CRUD Methods
        T GetById();
        List<T> GetAll();
        int Insert(T entity);
        void Update(T entity);
        void DeleteById(int id);
    }
}
