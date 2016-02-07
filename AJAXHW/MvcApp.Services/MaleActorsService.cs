namespace MvcApp.Services
{
    using System.Linq;

    using MvcApp.Data.Models;
    using MvcApp.Data.Repositories.Contracts;
    using MvcApp.Services.Contracts;

    public class MaleActorsService : IMaleActorsService
    {
        private readonly IRepository<MaleActor> actors;

        public MaleActorsService(IRepository<MaleActor> actors)
        {
            this.actors = actors;
        }

        public MaleActor GetById(int actorId)
        {
            return this.actors.GetById(actorId);
        }

        public IQueryable<MaleActor> GetAll()
        {
            return this.actors.All();
        }

        public void UpdateActor(MaleActor actor)
        {
            this.actors.Update(actor);
        }

        public int SaveChanges()
        {
            return this.actors.SaveChanges();
        }
    }
}
