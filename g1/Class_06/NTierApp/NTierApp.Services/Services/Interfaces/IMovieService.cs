using NTierApp.DataAccess.Core.Entities;
using NTierApp.DataAccess.Core.Enums;
using NTIerApp.PresentationLayer.ViewModels;
using System.Collections.Generic;

namespace NTierApp.Services.Services.Interfaces
{
    public interface IMovieService
    {
        List<MovieVM> GetMoviesRepertuar();
        MovieVM GetMovieById(int id);
        List<MovieVM> GetMoviesByGenre(Genre genre);
        List<MovieVM> GetMoviesByRating(Rating rating);
    }
}
