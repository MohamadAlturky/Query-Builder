using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Models;

namespace QueryBuilder.Abstractions.Database;

public interface IDb
{
    IQuery Query(IQueryableView queryableView);
}