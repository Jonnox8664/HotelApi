using DBAccess.DataModel;
using Microsoft.EntityFrameworkCore;

namespace DBAccess
{
    public class Context : DbContext
    {
        private string ConnectionString = @"Data Source=192.168.178.104,9433;User Id=sa;Password=P4$sw0rd!|;Database=EFDB;TrustServerCertificate=True;";
        public DbSet<Accommodation> Accommodations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
    }
}