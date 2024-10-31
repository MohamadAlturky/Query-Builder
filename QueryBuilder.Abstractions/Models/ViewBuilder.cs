using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Joins;
using QueryBuilder.Abstractions.Joins.Builders;

namespace QueryBuilder.Abstractions.Models;

public class ViewBuilder : IViewBuilder
{
    private readonly List<IJoin> _joins = new();

    // 4a. Method to add an Inner Join
    public ViewBuilder AddInnerJoin(string table, string leftKey, string rightKey)
    {
        _joins.Add(new InnerJoin(table, leftKey, rightKey));
        return this;
    }

    // 4b. Method to add a Left Join
    public ViewBuilder AddLeftJoin(string table, string leftKey, string rightKey)
    {
        _joins.Add(new LeftJoin(table, leftKey, rightKey));
        return this;
    }

    // 4c. Build method to retrieve the configured joins
    //public List<IJoin> Build() => _joins;
    public IViewBuilder InnerJoin(IJoinBuilder joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IViewBuilder LeftJoin(IJoinBuilder joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IViewBuilder OuterJoin(IJoinBuilder joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IViewBuilder InnerJoin(Action<IJoinBuilder> joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IViewBuilder LeftJoin(Action<IJoinBuilder> joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IViewBuilder OuterJoin(Action<IJoinBuilder> joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IViewBuilder Table(IView table)
    {
        throw new NotImplementedException();
    }

    public IViewBuilder View(IView view)
    {
        throw new NotImplementedException();
    }

    public IView Build()
    {
        throw new NotImplementedException();
    }
}
