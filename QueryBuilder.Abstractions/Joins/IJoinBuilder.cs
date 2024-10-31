using QueryBuilder.Abstractions.Contracts.Builders;
using QueryBuilder.Abstractions.Contracts.Models;

namespace QueryBuilder.Abstractions.Joins.Builders;

public interface IJoinBuilder
{
    IJoinBuilder With(IQueryableView queryableView);
    
    IJoinBuilder Where(Action<IWhereBuilder> where);
}