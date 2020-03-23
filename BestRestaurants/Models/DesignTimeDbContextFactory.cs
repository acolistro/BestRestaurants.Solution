using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BestRestaurants.Models
{
  public class BestRestaurantsContextFactory : IDesignTimeDbContextFactory<BestRestaurantsContext>
  {

    BestRestaurantsContext IDesignTimeDbContextFactory<BestRestaurantsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BestRestaurantsContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BestRestaurantsContext(builder.Options);
    }
  }
}