namespace MvcApp.Services.Contracts
{
    using System.Linq;

    using MvcApp.Data.Models;

    public interface IFemaleActorsService
    {
        FemaleActor GetById(int actorId);

        IQueryable<FemaleActor> GetAll();

        int SaveChanges();

        void UpdateActor(FemaleActor actor);
    }
}