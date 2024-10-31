using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Joins.Builders;

namespace QueryBuilder.Abstractions.Contracts;

public interface IViewBuilder
{
    IViewBuilder InnerJoin(Action<IJoinBuilder> joinBuilder);
    IViewBuilder LeftJoin(Action<IJoinBuilder> joinBuilder);
    IViewBuilder OuterJoin(Action<IJoinBuilder> joinBuilder);
    
    IViewBuilder Table(IView table);
    IView Build();
}