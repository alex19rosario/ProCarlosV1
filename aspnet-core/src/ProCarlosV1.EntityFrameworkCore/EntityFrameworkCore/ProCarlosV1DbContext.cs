using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProCarlosV1.Authorization.Roles;
using ProCarlosV1.Authorization.Users;
using ProCarlosV1.MultiTenancy;
using ProCarlosV1.Models;

namespace ProCarlosV1.EntityFrameworkCore
{
    public class ProCarlosV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProCarlosV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Student> Students { get; set; }
        public ProCarlosV1DbContext(DbContextOptions<ProCarlosV1DbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Abp.Localization.ApplicationLanguageText>()
                .Property(p => p.Value)
                .HasMaxLength(100); // any integer that is smaller than 10485760
        }
    }
}
