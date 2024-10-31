namespace QueryBuilder.Abstractions.QueryableViews;

public class Table(string clause) : IQueryableView
{
    public string Clause { get; } = clause;
}