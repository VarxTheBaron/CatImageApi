using Microsoft.EntityFrameworkCore;
using CatImageApi.Models;
namespace CatImageApi.Data;

public class CatDbContext : DbContext
{
    public CatDbContext(DbContextOptions<CatDbContext> options) : base(options)
    {
    }

    public DbSet<Cat> Cats => Set<Cat>();
    public DbSet<Breed> Breeds => Set<Breed>();
    public DbSet<Weather> Weathers => Set<Weather>();
    public DbSet<CatFact> CatFacts => Set<CatFact>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed data med olika kattbilder
        modelBuilder.Entity<Cat>().HasData(
            new Cat { Id = 1, Url = "https://cataas.com/cat/cute", BreedId = 1, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 2, Url = "https://cataas.com/cat/funny", BreedId = 2, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 3, Url = "https://cataas.com/cat/sleeping", BreedId = 1, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 4, Url = "https://cataas.com/cat/playing", BreedId = 2, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 5, Url = "https://cataas.com/cat/orange", BreedId = 1, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 6, Url = "https://cataas.com/cat/kitten", BreedId = 2, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 7, Url = "https://cataas.com/cat/says/meow", BreedId = 1, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 8, Url = "https://cataas.com/cat/white", BreedId = 2, Description = "Nice kitty", WeatherId = 1 },
            new Cat { Id = 9, Url = "https://cataas.com/cat/black", BreedId = 1, Description = "Chocked black cat", WeatherId = 1 },
            new Cat { Id = 10, Url = "https://cataas.com/cat/gray", BreedId = 2, Description = "Sleeping grey cat", WeatherId = 1 }
        );

        modelBuilder.Entity<Breed>().HasData(
            new Breed { Id = 1, Name = "Ragdoll" },
            new Breed { Id = 2, Name = "Maine Coon" }
        );

        modelBuilder.Entity<Weather>().HasData(
            new Weather { Id = 1, WeatherType = "Sunny" },
            new Weather { Id = 2, WeatherType = "Rainy" }
        );

        modelBuilder.Entity<CatFact>().HasData(
            new CatFact { Id = 1, Fact = "Cats are cool!" },
            new CatFact { Id = 2, Fact = "The Cataclysm was caused by dogs!" },
            new CatFact { Id = 3, Fact = "Cats are cooler than dogs, dogs are poopy." },
            new CatFact { Id = 4, Fact = "Cats + cheeseburgers = good stuff." }
        );
    }
}
