using FluentValidationExample.Entities;
using Microsoft.EntityFrameworkCore;

namespace FluentValidationExample.Data;

public class AppDb : DbContext
{
    public AppDb(DbContextOptions<AppDb> options) :base(options)
    {
        
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Adrress> Adrresses { get; set; }
}