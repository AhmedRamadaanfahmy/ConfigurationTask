namespace taskApis.Models
{
    using Microsoft.EntityFrameworkCore;

    public partial class MapConfigurationContext : DbContext
    {
        public MapConfigurationContext (DbContextOptions<MapConfigurationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Configuration> Configurations { get; set; }
        public virtual DbSet<MapSubType> MapSubTypes { get; set; }
        public virtual DbSet<MapType> MapTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapType>().HasData(
                new MapType
                {
                    Id = 1,
                    Value = "Features"
                },
                new MapType
                {
                    Id = 2,
                    Value = "Basemap",
                }
            );

            modelBuilder.Entity<MapSubType>().HasData(
                new MapSubType{
                    Id = 1,
                    Value = "Dynamic",
                    MapTypeId = 1
                },
                new MapSubType{
                    Id = 2,
                    Value = "Cached",
                    MapTypeId = 1
                },
                new MapSubType{
                    Id = 3,
                    Value = "Imagery",
                    MapTypeId = 2
                },
                new MapSubType{
                    Id = 4,
                    Value = "Topographic",
                    MapTypeId = 2
                }
            );
        }
    }
}
