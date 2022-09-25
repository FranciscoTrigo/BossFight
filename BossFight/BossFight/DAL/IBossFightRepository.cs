using System.Collections.Generic;

namespace BossFight.DAL
{
  public interface IBossFightRepository
  {
    IEnumerable<T> Query<T>(string sqlCommand);
  }
}
