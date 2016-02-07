namespace MvcApp.Services
{
    using System.Linq;

    using MvcApp.Data.Models;
    using MvcApp.Data.Repositories.Contracts;
    using MvcApp.Services.Contracts;
    public class DirectorsService : IDirectorsService
    {
        private readonly IRepository<Director> directors;

        public DirectorsService(IRepository<Director> directors)
        {
            this.directors = directors;
        }
        public Director GetById(int directorId)
        {
            return this.directors.GetById(directorId);
        }

        public IQueryable<Director> GetAll()
        {
            return this.directors.All();
        }

        public int SaveChanges()
        {
            return this.directors.SaveChanges();
        }
    }
}
