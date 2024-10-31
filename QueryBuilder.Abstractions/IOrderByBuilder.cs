namespace QueryBuilder.Abstractions;

public interface IOrderByBuilder
{
    IOrderByBuilder Ascending(string columnName);
    IOrderByBuilder Descending(string columnName);
}