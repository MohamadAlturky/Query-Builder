namespace QueryBuilder.Abstractions.OrdersBy;

public interface IOrderByBuilder
{
    IOrderByBuilder Ascending(string columnName);
    IOrderByBuilder Descending(string columnName);
}