using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Models;

namespace QueryBuilder.Abstractions.Database;

public class Db : IDb
{

    public IQuery Query(IQueryableView queryableView)
    {
        throw new NotImplementedException();
    }
}