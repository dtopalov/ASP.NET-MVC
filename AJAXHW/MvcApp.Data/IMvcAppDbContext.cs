namespace MvcApp.Data
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    using MvcApp.Data.Models;

    public interface IMvcAppDbContext
    {
        IDbSet<User> Users { get; set; }
        IDbSet<Movie> Movies { get; set; }
        IDbSet<MaleActor> MaleActors { get; set; }

        IDbSet<FemaleActor> FemaleActors { get; set; }
        IDbSet<Director> Directors { get; set; }
        IDbSet<Studio> Studios { get; set; }

        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        void Dispose();

        int SaveChanges();
    }
}
