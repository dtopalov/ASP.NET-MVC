namespace MvcApp.Services
{
    using System.Linq;

    using MvcApp.Data.Models;
    using MvcApp.Data.Repositories.Contracts;
    using MvcApp.Services.Contracts;
    public class MoviesService : IMoviesService
    {
        private readonly IRepository<Movie> movies;

        public MoviesService(IRepository<Movie> movies)
        {
            this.movies = movies;
        }
        public IQueryable<Movie> GetAll()
        {
            return this.movies.All();
        }

        public Movie GetById(int id)
        {
            return this.GetById(id);
        }

        public int SaveChanges()
        {
            return this.movies.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            this.movies.Update(movie);
        }

        public void DeleteMovie(int id)
        {
            this.movies.Delete(id);
        }

        public void CreateMovie(Movie movie)
        {
            this.movies.Add(movie);
        }
    }
}
