namespace QueryBuilder.Abstractions.Contracts.Builders;

public interface IOrderByBuilder
{
    IOrderByBuilder Ascending(string columnName);
    IOrderByBuilder Descending(string columnName);
}