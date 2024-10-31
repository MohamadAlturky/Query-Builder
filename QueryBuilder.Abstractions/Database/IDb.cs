using QueryBuilder.Abstractions.Models;
using QueryBuilder.Abstractions.QueryableViews;

namespace QueryBuilder.Abstractions.Database;

public interface IDb
{
    IQuery Query(string dbObjectName,string? alias = null);
    IQuery Query(IQueryableView queryableView);
}