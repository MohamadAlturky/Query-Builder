using QueryBuilder.Abstractions.Contracts.Builders;
using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Wheres;

namespace QueryBuilder.Abstractions.Models;

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
    

    public IQuery Where(Action<IWhereBuilder> where)
    {
        throw new NotImplementedException();
    }

    public IQuery OrderBy(Action<IOrderByBuilder> orderBy)
    {
        throw new NotImplementedException();
    }
}