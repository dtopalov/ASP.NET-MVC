namespace MvcApp.Services
{
    using System.Linq;

    using MvcApp.Data.Models;
    using MvcApp.Data.Repositories.Contracts;
    using MvcApp.Services.Contracts;

    public class UsersService : IUsersService
    {
        private readonly IRepository<User> users;

        public UsersService(IRepository<User> users)
        {
            this.users = users;
        }

        public User GetById(string userId)
        {
            return this.users.GetById(userId);
        }

        public IQueryable<User> GetAll()
        {
            return this.users.All();
        }

        public void UpdateUser(User user)
        {
            this.users.Update(user);
        }

        public int SaveChanges()
        {
            return this.users.SaveChanges();
        }
    }
}
