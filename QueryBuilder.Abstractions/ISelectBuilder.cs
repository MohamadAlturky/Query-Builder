namespace QueryBuilder.Abstractions;

public interface ISelectBuilder
{
    ISelectBuilder Column(string columnName, string? alias = null);
}