using System;
namespace MvcApp.Services.Contracts
{
    using System.Linq;

    using MvcApp.Data.Models;

    public interface IStudiosService
    {
        Studio GetById(int studioId);

        IQueryable<Studio> GetAll();

        int SaveChanges();
    }
}
