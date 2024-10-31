using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Database;

namespace QueryBuilder.Abstractions.Models;

public class Db : IDb
{

    public IQuery Query(IView view)
    {
        throw new NotImplementedException();
    }
}