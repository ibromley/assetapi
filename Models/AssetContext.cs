using Microsoft.EntityFrameworkCore;

namespace AssetApi.Models
{
    public class AssetContext : DbContext
    {
        public AssetContext(DbContextOptions<AssetContext> options)
            : base(options)
        {

        }

        public DbSet<AssetItem> AssetItems { get; set;}
    }
}