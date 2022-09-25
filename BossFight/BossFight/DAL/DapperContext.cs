using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace BossFight.DAL
{
  public class DapperContext
  {
    private readonly IConfiguration configuration;

    public DapperContext(IConfiguration configuration)
    {
      this.configuration = configuration;
    }

    public IDbConnection CreateConnection(string databaseName)
    {
      var connectionString = configuration.GetConnectionString(databaseName);
      return new SqlConnection(connectionString);
    }
  }
}
