using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ProCarlosV1.Authorization.Roles;
using ProCarlosV1.Authorization.Users;
using ProCarlosV1.MultiTenancy;

namespace ProCarlosV1.EntityFrameworkCore
{
    public class ProCarlosV1DbContext : AbpZeroDbContext<Tenant, Role, User, ProCarlosV1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ProCarlosV1DbContext(DbContextOptions<ProCarlosV1DbContext> options)
            : base(options)
        {
        }
    }
}
