using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace NTierApp.DataAccess.Core.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private ILocalDb _db;
        public MovieRepository(ILocalDb db)
        {
            _db = db;
        }
        public bool Create(Movie entity)
        {
            var movie = _db.GetMovies().SingleOrDefault(x =>x.ID == entity.ID);
            if (movie != null)
            {
                return false;
            }
            _db.GetMovies().ToList().Add(entity);
            return true;
        }

        public bool Delete(Movie entity)
        {
           var movie =  _db.GetMovies().SingleOrDefault(m => m.ID == entity.ID);
            if (movie == null)
            {
                return false;
            }
            _db.GetMovies().ToList().Remove(entity);
            return true;
        }

        public List<Movie> GetAll()
        {
            return _db.GetMovies().ToList();
        }

        public Movie GetById(int id)
        {
            return _db.GetMovies().SingleOrDefault(x => x.ID == id);
        }

        public bool Update(Movie entity)
        {
            var movie = _db.GetMovies().SingleOrDefault(x => x.ID == entity.ID);
            if (movie == null)
            {
                return false;
            }
            _db.GetMovies().ToList().Remove(entity);
            _db.GetMovies().ToList().Add(entity);
            //int index = _db.GetMovies().ToList().IndexOf(movie);
            //_db.GetMovies().ToList()[index] = entity;
            return true;
        }
    }
}
