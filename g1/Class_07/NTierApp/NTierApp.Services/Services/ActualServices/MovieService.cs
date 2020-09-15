using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Enums;
using NTierApp.DataAccess.Core.Interfaces;
using NTierApp.Services.Mappings;
using NTierApp.Services.Services.Interfaces;
using NTIerApp.PresentationLayer.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace NTierApp.Services.Services.ActualServices
{
    public class MovieService : IMovieService
    {
        private IRepository<Movie> _movieRepo;


        public MovieService(IRepository<Movie> movieRepo)
        {
            _movieRepo = movieRepo;
        }
        public MovieVM GetMovieById(int id)
        {
            var movie = _movieRepo.GetById(id);
            var vm = Mapper.FromMovieToMovieVM(movie);
            return vm;
        }

        public void CreateNewMovie(MovieVM movieVm)
        {
            var movie = Mapper.FromMovieVMToMovie(movieVm);
            _movieRepo.Create(movie);
        }

        public List<MovieVM> GetMoviesByGenre(Genre genre)
        {
            var filteredMovies = _movieRepo.GetAll().Where(x => x.MovieGenre == genre).ToList();
            var vms = Mapper.MapMoviesToMoviesVM(filteredMovies);
            return vms;
        }

        public List<MovieVM> GetMoviesByRating(Rating rating)
        {
            var filteredMovies = _movieRepo.GetAll().Where(x => x.MovieRating == rating).ToList();
            var vms = Mapper.MapMoviesToMoviesVM(filteredMovies);
            return vms;
        }

        public List<MovieVM> GetMoviesRepertuar()
        {
            var movies = _movieRepo.GetAll().ToList();
            var thisMovies = movies;
            var vms = Mapper.MapMoviesToMoviesVM(movies);
            return vms;
        }
    }
}
