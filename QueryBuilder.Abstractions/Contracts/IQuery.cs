using QueryBuilder.Abstractions.Contracts.Builders;

namespace QueryBuilder.Abstractions.Contracts.Models;

public interface IQuery
{
    IQuery Select(Action<ISelectBuilder> select);
    IQuery As(string alias);
    IQuery Where(Action<IWhereBuilder> where);
    IQuery OrderBy(Action<IOrderByBuilder> orderBy);
}

public record Select(string ColumnName, string? Alias = null);