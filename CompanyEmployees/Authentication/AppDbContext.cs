using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompanyEmployees.Authentication;

// internal class AppDbContext : IdentityDbContext<AppUser>
// {
//     /// <summary>
//     /// Ctor
//     /// </summary>
//     public AppDbContext(DbContextOptions options) : base(options)
//     {
//     }
//
//     protected override void OnModelCreating(ModelBuilder builder)
//     {
//         base.OnModelCreating(builder);
//         builder.ApplyConfiguration(new CompanyConfiguration());
//         builder.ApplyConfiguration(new EmployeeConfiguration());
//     }
//
//     public DbSet<Company> Companies { get; set; }
//     public DbSet<Employee> Employees { get; set; }
// }
