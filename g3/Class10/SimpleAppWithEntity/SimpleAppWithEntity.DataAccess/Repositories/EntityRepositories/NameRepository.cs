using SimpleAppWithEntity.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleAppWithEntity.DataAccess.Repositories.EntityRepositories
{
    public class NameRepository : IRepository<Name>
    {
        private NameDbContext _context;

        public NameRepository(NameDbContext context)
        {
            _context = context;
        }

        public List<Name> GetAll()
        {
            return _context.Names.ToList();
        }

        public Name GetById(int id)
        {
            return _context.Names.FirstOrDefault(x => x.Id == id);
        }

        public int Insert(Name entity)
        {
            _context.Names.Add(entity);
            var id = _context.SaveChanges();
            return id;
        }

        public void Update(Name entity)
        {
            var name = _context.Names.FirstOrDefault(x => x.Id == entity.Id);
            if (name != null) 
            {
                entity.Id = name.Id;
                _context.Names.Update(entity);
                _context.SaveChanges();
            }
        }

        public void DeleteById(int id)
        {
            var name = _context.Names.FirstOrDefault(x => x.Id == id);
            if (name != null) 
            {
                _context.Names.Remove(name);
                _context.SaveChanges();
            }
        }
    }
}
