using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;

namespace BossFight.DAL
{
  public class BossFightRepository : IBossFightRepository
  {
    private const string TableName = "BossFight";
    private readonly DapperContext dapperContext;

    public BossFightRepository(DapperContext dapperContext)
    {
      this.dapperContext = dapperContext;
    }

    public IEnumerable<T> Query<T>(string sqlCommand)
    {
      using var connection = dapperContext.CreateConnection(TableName);

      return connection.Query<T>(sqlCommand);
    }

    
  }
}
