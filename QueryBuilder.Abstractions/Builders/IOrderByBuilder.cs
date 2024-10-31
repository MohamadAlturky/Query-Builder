namespace QueryBuilder.Abstractions.Builders;

public interface IOrderByBuilder
{
    IOrderByBuilder Ascending(string columnName);
    IOrderByBuilder Descending(string columnName);
}