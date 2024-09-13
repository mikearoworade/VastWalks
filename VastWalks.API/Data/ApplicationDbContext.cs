using Microsoft.EntityFrameworkCore;
using VastWalks.API.Models.Domain;

namespace VastWalks.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed data for Difficulties
            //Easy, Medium, Hard..
            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("25355da1-b203-470e-9672-cf185af83ada"),
                    Name = "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("0fcaf011-371e-48a9-8280-1caca3c9a624"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("d908a688-b24c-4f0b-80d8-19376f21e0f4"),
                    Name = "Hard"
                }
            };
            //Seed difficulties to the database
            modelBuilder.Entity<Difficulty>().HasData(difficulties);


            //Seed data for region
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("cfc5729e-7028-47c6-8808-db2221840f76"),
                    Name = "Auckland",
                    Code = "AKL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("81edc90b-3630-4618-993f-62d31bba15eb"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("57b9bd28-ce6d-435b-b430-93d72fe2b97e"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("f07a94a9-1953-42b5-b104-eb5d3868ab9a"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("7646a62b-fcf5-4dcf-b494-75a15185c33f"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },
            };

            //Seed regions to the datatbase
            modelBuilder.Entity<Region>().HasData(regions);

        }
    }
}
