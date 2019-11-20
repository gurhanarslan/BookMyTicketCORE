using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookTicket.Models
{
    public class EfMoviesRepository : IMoviesRepository
    {
        private ApplicationDbContext context;

        public EfMoviesRepository(ApplicationDbContext _context)
        {
            context = _context;
        }



        public void CreateMovies(Movies movies)
        {
            context.Movies.Add(movies);
            context.SaveChanges();
        }

        public void DeleteMovies(int moviesid)
        {
            var user = context.Movies.FirstOrDefault(i => i.MoviesId == moviesid);
            if (context != null)
            {
                context.Movies.Remove(user);
                context.SaveChanges();
            }
        }

        public IQueryable<Movies> getAll()
        {
            return context.Movies;
        }

        public Movies getById(int moviesid)
        {
            return context.Movies.FirstOrDefault(i => i.MoviesId == moviesid);
        }

        public Movies getByTitle(string moviestitle)
        {
            return context.Movies.FirstOrDefault(i => i.MoviesName == moviestitle);
        }

        public void UpdateMovies(Movies movies)
        {
            context.Movies.Update(movies);
            context.SaveChanges();
        }
    }
}
