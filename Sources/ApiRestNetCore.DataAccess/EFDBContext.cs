using ApiRestNetCore.DataAccess.Configurations;
using ApiRestNetCore.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiRestNetCore.DataAccess
{
    public class EFDBContext : IdentityDbContext
    {
        #region Constructors

        public EFDBContext(DbContextOptions<EFDBContext> options)
            : base(options)
        {
        }

        #endregion

        #region Properties

        public DbSet<Persona> personas { get; set; }

        #endregion

        #region Queries

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Entity>();
            modelBuilder.ApplyConfiguration(new PersonConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
