namespace Xy.Pis.Domain
{

    public partial interface IXyDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<BsItem> BsItems { get; set; } // BsItem
        System.Data.Entity.DbSet<BsLocation> BsLocations { get; set; } // BsLocation

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
    }

}
