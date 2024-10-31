using QueryBuilder.Abstractions.OrdersBy;
using QueryBuilder.Abstractions.Selects;
using QueryBuilder.Abstractions.Wheres;

namespace QueryBuilder.Abstractions.Contracts.Models;

public interface IQuery
{
    IQuery Select(Action<ISelectBuilder> select);
    IQuery As(string alias);
    IQuery Where(Action<IWhereBuilder> where);
    IQuery OrderBy(Action<IOrderByBuilder> orderBy);
}

public record Select(string ColumnName, string? Alias = null);