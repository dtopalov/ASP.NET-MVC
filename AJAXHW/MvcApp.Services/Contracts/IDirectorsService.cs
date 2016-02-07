namespace MvcApp.Services.Contracts
{
    using System.Linq;

    using MvcApp.Data.Models;

    public interface IDirectorsService
    {
        Director GetById(int directorId);

        IQueryable<Director> GetAll();

        int SaveChanges();
    }
}
