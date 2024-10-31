using QueryBuilder.Abstractions.Models;

namespace QueryBuilder.Abstractions.Builders;

public interface IJoinBuilder
{
    IJoinBuilder With(IQueryableView queryableView);
    
    IJoinBuilder Where(Action<IWhereBuilder> where);
}