namespace QueryBuilder.Abstractions.Builders;

public interface ISelectBuilder
{
    ISelectBuilder Column(string columnName, string? alias = null);
}