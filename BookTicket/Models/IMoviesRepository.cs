using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
    public interface IMoviesRepository
    {

        IQueryable<Movies> getAll();
        void CreateMovies(Movies movies);
        void UpdateMovies(Movies movies);
        void DeleteMovies(int moviesid);
        Movies getById(int moviesid);
        Movies getByTitle(string moviestitle);



    }
}
