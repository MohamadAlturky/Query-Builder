namespace QueryBuilder.Abstractions.Queryables;


public interface IQueryableViewBuilder
{
    IQueryableViewBuilder InnerJoin(Action<IJoinBuilder> joinBuilder);
    IQueryableViewBuilder LeftJoin(Action<IJoinBuilder> joinBuilder);
    IQueryableViewBuilder OuterJoin(Action<IJoinBuilder> joinBuilder);
    
    IQueryableViewBuilder Table(IQueryableView table);
    IQueryableViewBuilder View(IQueryableView view);
}
public interface IJoinBuilder
{
    IJoinBuilder With(IQueryableView queryableView);
    
    IJoinBuilder Where(Action<IWhereBuilder> where);
}


public class QueryableViewBuilder : IQueryableViewBuilder
{
    private readonly List<IJoin> _joins = new();

    // 4a. Method to add an Inner Join
    public QueryableViewBuilder AddInnerJoin(string table, string leftKey, string rightKey)
    {
        _joins.Add(new InnerJoin(table, leftKey, rightKey));
        return this;
    }

    // 4b. Method to add a Left Join
    public QueryableViewBuilder AddLeftJoin(string table, string leftKey, string rightKey)
    {
        _joins.Add(new LeftJoin(table, leftKey, rightKey));
        return this;
    }

    // 4c. Build method to retrieve the configured joins
    public List<IJoin> Build() => _joins;
    public IQueryableViewBuilder InnerJoin(IJoinBuilder joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IQueryableViewBuilder LeftJoin(IJoinBuilder joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IQueryableViewBuilder OuterJoin(IJoinBuilder joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IQueryableViewBuilder InnerJoin(Action<IJoinBuilder> joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IQueryableViewBuilder LeftJoin(Action<IJoinBuilder> joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IQueryableViewBuilder OuterJoin(Action<IJoinBuilder> joinBuilder)
    {
        throw new NotImplementedException();
    }

    public IQueryableViewBuilder Table(IQueryableView table)
    {
        throw new NotImplementedException();
    }

    public IQueryableViewBuilder View(IQueryableView view)
    {
        throw new NotImplementedException();
    }
}
