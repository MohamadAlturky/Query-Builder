using QueryBuilder.Abstractions.Models;

namespace QueryBuilder.Abstractions.Builders;

public interface IQueryableViewBuilder
{
    IQueryableViewBuilder InnerJoin(Action<IJoinBuilder> joinBuilder);
    IQueryableViewBuilder LeftJoin(Action<IJoinBuilder> joinBuilder);
    IQueryableViewBuilder OuterJoin(Action<IJoinBuilder> joinBuilder);
    
    IQueryableViewBuilder Table(IQueryableView table);
    IQueryableViewBuilder View(IQueryableView view);
}