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
            return StaticDatabase.Sizes;
        }

        public Size GetById(int id)
        {
            return StaticDatabase.Sizes.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Size entity)
        {
            StaticDatabase.Sizes.Add(entity);
            return entity.Id;
        }

        public void Update(Size entity)
        {
            Size size = StaticDatabase.Sizes.FirstOrDefault(x => x.Id == entity.Id);
            if (size == null)
            {
                throw new Exception($"Size with id {entity.Id} was not found");
            }
            //update the record in DB
            int index = StaticDatabase.Sizes.IndexOf(size);
            StaticDatabase.Sizes[index] = entity;
        }

        public void Delete(int id)
        {
            Size size = StaticDatabase.Sizes.FirstOrDefault(x => x.Id == id);
            if (size == null)
            {
                throw new Exception($"Size with id {id} was not found");
            }
            //delete record from DB
            int index = StaticDatabase.Sizes.IndexOf(size);
            StaticDatabase.Sizes.RemoveAt(index);
        }
    }
}
