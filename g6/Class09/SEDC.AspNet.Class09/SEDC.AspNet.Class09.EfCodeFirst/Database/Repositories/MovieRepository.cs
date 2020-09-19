using SEDC.AspNet.Class09.EfCodeFirst.Database.Interfaces;
using SEDC.AspNet.Class09.EfCodeFirst.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.AspNet.Class09.EfCodeFirst.Database.Repositories
{
    public class MovieRepository : IRepository<Movie>
    {
        private readonly RentalStoreContext _rentalStoreContext;

        public MovieRepository(RentalStoreContext rentalStoreContext)
        {
            _rentalStoreContext = rentalStoreContext;
        }

        public List<Movie> GetAll()
        {
            return _rentalStoreContext.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return _rentalStoreContext.Movies.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(Movie entity)
        {
            _rentalStoreContext.Movies.Add(entity);
            _rentalStoreContext.SaveChanges();
        }

        public void Remove(Movie entity)
        {
            _rentalStoreContext.Movies.Remove(entity);
            _rentalStoreContext.SaveChanges();
        }

        public void Update(Movie entity)
        {
            var movie = _rentalStoreContext.Movies.FirstOrDefault(x => x.Id == entity.Id);

            movie.IsAvailable = entity.IsAvailable;
            movie.Language = entity.Language;
            movie.Length = entity.Length;
            movie.Quantity = entity.Quantity;
            movie.ReleaseDate = entity.ReleaseDate;
            movie.RentalInfo = entity.RentalInfo;
            movie.Title = entity.Title;
            // TODO: do the rest of the update

            // _rentalStoreContext.Entry<Movie>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _rentalStoreContext.SaveChanges();
        }
    }
}
