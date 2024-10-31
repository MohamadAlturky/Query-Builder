namespace QueryBuilder.Abstractions;

public interface IDb
{
    IQuery Query(string dbObjectName,string? alias = null);
    IQuery Query(IDbObject dbObject);
}

public class Db : IDb
{
    public IQuery Query(string dbObjectName,string? alias = null)
    {
        throw new NotImplementedException();
    }

    public IQuery Query(IDbObject dbObject)
    {
        throw new NotImplementedException();
    }
}