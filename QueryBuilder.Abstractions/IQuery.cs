namespace QueryBuilder.Abstractions;

public enum WhereOperation
{
    Equal,
    NotEqual,
}
public interface IQuery
{
    IQuery Select(Action<ISelectBuilder> select);
    IQuery From(IQuery query);
    IQuery As(string alias);
    IQuery Where(Action<IWhereBuilder> where);
    IQuery OrderBy(Action<IOrderByBuilder> orderBy);
}

public record Select(string ColumnName, string? Alias = null);

public class Query : IQuery
{
    private readonly List<Select> _selects = [];
    private string _dbObjectName = string.Empty;

    public IQuery Select(string columnName, string? alias = null)
    {
        _selects.Add(new Select(columnName, alias));
        return this;
    }


    public IQuery Select(Action<ISelectBuilder> select)
    {
        throw new NotImplementedException();
    }

    public IQuery From(IQuery query)
    {
        throw new NotImplementedException();
    }

    public IQuery As(string alias)
    {
        throw new NotImplementedException();
    }

    public IQuery Join(Action<IJoinBuilder> join)
    {
        throw new NotImplementedException();
    }

   

    public IQuery Where(Action<IWhereBuilder> where)
    {
        throw new NotImplementedException();
    }

    public IQuery OrderBy(Action<IOrderByBuilder> orderBy)
    {
        throw new NotImplementedException();
    }
}