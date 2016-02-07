namespace MvcApp.Services
{
    using System.Linq;

    using MvcApp.Data.Models;
    using MvcApp.Data.Repositories.Contracts;
    using MvcApp.Services.Contracts;
    public class StudiosService : IStudiosService
    {
        private readonly IRepository<Studio> studios;

        public StudiosService(IRepository<Studio> studios)
        {
            this.studios = studios;
        }

        public Studio GetById(int studioId)
        {
            return this.studios.GetById(studioId);
        }

        public IQueryable<Studio> GetAll()
        {
            return this.studios.All();
        }

        public int SaveChanges()
        {
            return this.studios.SaveChanges();
        }
    }
}
