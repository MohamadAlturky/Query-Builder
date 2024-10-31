using QueryBuilder.Abstractions.Queryables;

namespace QueryBuilder.Abstractions;

public class Table : IQueryableView
{
    public Table(string name)
    {
        Name = name;
    }
    public static implicit operator Table(string name)
    {
        return new Table(name);
    }
    public string Name { get; set; }
    public string Sql { get; }
}