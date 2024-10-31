using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Joins.Builders;
using QueryBuilder.Abstractions.Models;

namespace QueryBuilder.Abstractions.Contracts.Builders;

public interface IQueryableViewBuilder
{
    IQueryableViewBuilder InnerJoin(Action<IJoinBuilder> joinBuilder);
    IQueryableViewBuilder LeftJoin(Action<IJoinBuilder> joinBuilder);
    IQueryableViewBuilder OuterJoin(Action<IJoinBuilder> joinBuilder);
    
    IQueryableViewBuilder Table(IQueryableView table);
    IQueryableViewBuilder View(IQueryableView view);
    IQueryableView Build();
}