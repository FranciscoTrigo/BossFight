using System.IO;
using BossFight.BLL;
using BossFight.DAL;
using BossFight.UI.Helpers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BossFight.Startup
{
  public static class ApplicationStart
  {
    public static ServiceProvider ConfigureServices()
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", optional: false);


      var serviceCollection = new ServiceCollection()
        .AddSingleton<IConfiguration>(provider => builder.Build())
        .AddSingleton(provider =>
        {
          var configuration = provider.GetService<IConfiguration>();
          return new DapperContext(configuration);
        })
        .AddTransient<IBossFightRepository, BossFightRepository>()
        .AddTransient<IPokemonDrawHelper, PokemonDrawHelper>()
        .AddTransient<IGame, Game>()
        .AddTransient<IPokemonFactory, PokemonFactory>()
        .AddTransient<IPokemonFightHelper, PokemonFighterHelper>()
        .AddTransient<IItemFactory, ItemFactory>()
        .AddTransient<IpokemonItemHelper, PokemonItemHelper>()
        .AddTransient<IAttackFactory, AttackFactory>();


      return serviceCollection.BuildServiceProvider();
    }
  }
}
