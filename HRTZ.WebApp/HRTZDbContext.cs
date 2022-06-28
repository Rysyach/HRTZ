using Microsoft.EntityFrameworkCore;
using HRTZ.Core;

namespace HRTZ.WebApp;

public sealed class HRTZDbContext: DbContext
{
    public HRTZDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        Database.Migrate();
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Candidate> Candidates { get; set; }
    
    public DbSet<Admin> Admins { get; set; }
}