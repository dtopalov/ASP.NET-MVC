namespace MvcApp.Data
{
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;

    using Microsoft.AspNet.Identity.EntityFramework;

    using MvcApp.Data.Models;

    public class MvcAppDbContext : IdentityDbContext<User>, IMvcAppDbContext
    {
        private const string DbConnectionName = "DefaultConnection";

        public MvcAppDbContext()
            : base(DbConnectionName, throwIfV1Schema: false)
        {
        }

        public IDbSet<Movie> Movies { get; set; }

        public IDbSet<MaleActor> MaleActors { get; set; }

        public IDbSet<FemaleActor> FemaleActors { get; set; }

        public IDbSet<Director> Directors { get; set; }

        public IDbSet<Studio> Studios { get; set; }

        public static MvcAppDbContext Create()
        {
            return new MvcAppDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<MaleActor>()
            //        .HasMany(s => s.Movies)
            //        .WithOptional(s => s.MaleActor)
            //        .HasForeignKey(s => s.MaleActorId);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
