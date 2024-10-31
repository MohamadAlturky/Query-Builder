using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Wheres;

namespace QueryBuilder.Abstractions.Joins.Builders;

public interface IJoinBuilder
{
    IJoinBuilder With(IView view);

    IJoinBuilder OnEquals(string left, string right);
    IJoin BuildInnerJoin();
    IJoin BuildLeftJoin();
    IJoin BuildOuterJoin();

}


public class JoinBuilder : IJoinBuilder
{
    private IView _view;
    private string _left;
    private string _right;
    public IJoinBuilder With(IView view)
    {
        _view = view;
        return this;
    }

    public IJoinBuilder OnEquals(string left, string right)
    {
        _left = left;
        _right = right;
        return this;
    }

    public IJoin BuildInnerJoin()
    {
        return new InnerJoin(_view,_left,_right);
    }

    public IJoin BuildOuterJoin()
    {
        return new OuterJoin(_view,_left,_right);
    }

    public IJoin BuildLeftJoin()
    {
        return new LeftJoin(_view,_left,_right);
    }
}