namespace MvcApp.Services.Contracts
{
    using System.Linq;

    using MvcApp.Data.Models;

    public interface IMoviesService
    {
        IQueryable<Movie> GetAll();

        Movie GetById(int id);

        int SaveChanges();

        void UpdateMovie(Movie movie);

        void DeleteMovie(int id);

        void CreateMovie(Movie movie);
    }
}