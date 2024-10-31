using QueryBuilder.Abstractions.Models;

namespace QueryBuilder.Abstractions.Database;

public class Db : IDb
{
    public IQuery Query(string dbObjectName,string? alias = null)
    {
        throw new NotImplementedException();
    }

    public IQuery Query(IQueryableView queryableView)
    {
        throw new NotImplementedException();
    }
}