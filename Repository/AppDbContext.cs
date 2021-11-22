using Microsoft.EntityFrameworkCore;
using Shop.Domain.Commands.Responses;

namespace DotNetCoreReposityMediatorCQRS.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        
        public DbSet<CreateCustomerResponse> Customers { get; set; }
        
    }
}