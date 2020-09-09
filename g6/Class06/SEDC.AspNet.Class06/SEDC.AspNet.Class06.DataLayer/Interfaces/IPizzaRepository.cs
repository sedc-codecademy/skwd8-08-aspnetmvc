using SEDC.AspNet.Class06.DataLayer.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AspNet.Class06.DataLayer.Interfaces
{
    public interface IPizzaRepository
    {
        List<Pizza> GetAll();
        Pizza GetById(int id);
        void Insert(Pizza entity);
        void Update(Pizza entity);
        int Remove(Pizza entity);
    }
}
