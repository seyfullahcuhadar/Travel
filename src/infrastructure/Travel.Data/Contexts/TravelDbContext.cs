using Microsoft.EntityFrameworkCore;
using Travel.Application.Common.Interfaces;
using Travel.Domain.Entities;
namespace Travel.Data.Contexts
{
public class TravelDbContext : DbContext,IApplicationDbContext
{
    public TravelDbContext
        (DbContextOptions<TravelDbContext> options)
        : base(options)
    {
    }
    public DbSet<TourList> TourLists { get; set; }
    public DbSet<TourPackage> TourPackages { get;  set; }
}
}
