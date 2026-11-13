namespace LoanSphere.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using LoanSphere.Domain.Entities;
 public  class LoanSphereDbContext : DbContext
{
    public LoanSphereDbContext(DbContextOptions<LoanSphereDbContext> options) : base(options) { }
    public DbSet<LoanApplication> LoanApplications { get; set; }

}
