using System;
using System.Collections.Generic;
using System.Linq;
using DomainModels;

namespace DataAccess.Implementations
{
    public class SizeRepository : IRepository<Size>
    {
        public List<Size> GetAll()
        {
            using (var db = new PizzaAppContext())
            {
                return db.Sizes.ToList();
            }
        }

        public Size GetById(int id)
        {
            using (var db = new PizzaAppContext())
            {
                return db.Sizes.FirstOrDefault(x => x.Id == id);
            }
        }

        public int Insert(Size entity)
        {
            using (var db = new PizzaAppContext())
            {
                db.Add(entity);
                db.SaveChanges();
                return entity.Id;
            }
        }

        public void Update(Size entity)
        {
            using (var db = new PizzaAppContext())
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new PizzaAppContext())
            {
                var size = db.Sizes.FirstOrDefault(x => x.Id == id);

                if (size == null)
                    throw new Exception("size not found.");

                db.Remove(size);
                db.SaveChanges();
            }
        }
    }
}
