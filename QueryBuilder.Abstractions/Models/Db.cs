using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Models;

namespace QueryBuilder.Abstractions.Database;

public class Db : IDb
{

    public IQuery Query(IView view)
    {
        throw new NotImplementedException();
    }
}