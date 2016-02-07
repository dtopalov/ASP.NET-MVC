namespace MvcApp.Services.Contracts
{
    using System.Linq;

    using MvcApp.Data.Models;

    public interface IMaleActorsService
    {
        MaleActor GetById(int actorId);

        IQueryable<MaleActor> GetAll();

        int SaveChanges();

        void UpdateActor(MaleActor actor);
    }
}