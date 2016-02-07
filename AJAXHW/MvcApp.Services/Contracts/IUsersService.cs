namespace MvcApp.Services.Contracts
{
    using System.Linq;

    using MvcApp.Data.Models;

    public interface IUsersService
    {
        User GetById(string userId);

        IQueryable<User> GetAll();

        int SaveChanges();

        void UpdateUser(User currentUser);
    }
}