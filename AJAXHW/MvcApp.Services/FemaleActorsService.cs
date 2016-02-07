namespace MvcApp.Services
{
    using System.Linq;

    using MvcApp.Data.Models;
    using MvcApp.Data.Repositories.Contracts;
    using MvcApp.Services.Contracts;

    public class FemaleActorsService : IFemaleActorsService
    {
        private readonly IRepository<FemaleActor> actors;

        public FemaleActorsService(IRepository<FemaleActor> actors)
        {
            this.actors = actors;
        }

        public FemaleActor GetById(int actorId)
        {
            return this.actors.GetById(actorId);
        }

        public IQueryable<FemaleActor> GetAll()
        {
            return this.actors.All();
        }

        public void UpdateActor(FemaleActor actor)
        {
            this.actors.Update(actor);
        }

        public int SaveChanges()
        {
            return this.actors.SaveChanges();
        }
    }
}
