using System.Text;
using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Joins;
using QueryBuilder.Abstractions.Joins.Builders;

namespace QueryBuilder.Abstractions.Models;

public class ViewBuilder : IViewBuilder
{
    private readonly List<IJoin> _joins = new();
    private IView _baseView;

    public IViewBuilder InnerJoin(Action<IJoinBuilder> joinBuilder)
    {
        var builder = new JoinBuilder();
        joinBuilder(builder);
        _joins.Add(builder.BuildInnerJoin());
        return this;
    }

    public IViewBuilder LeftJoin(Action<IJoinBuilder> joinBuilder)
    {
        var builder = new JoinBuilder();
        joinBuilder(builder);
        _joins.Add(builder.BuildLeftJoin());
        return this;
    }

    public IViewBuilder OuterJoin(Action<IJoinBuilder> joinBuilder)
    {
        var builder = new JoinBuilder();
        joinBuilder(builder);
        _joins.Add(builder.BuildOuterJoin());
        return this;
    }

    public IViewBuilder Table(IView table)
    {
        _baseView = table;
        return this;
    }

    public IView Build()
    {
        if (_baseView == null)
        {
            throw new InvalidOperationException("Base table must be specified.");
        }

        var clauseBuilder = new StringBuilder(_baseView.Clause);

        foreach (var join in _joins)
        {
            clauseBuilder.Append(' ').Append(join);
        }

        return new BuiltView(clauseBuilder.ToString());
    }
}