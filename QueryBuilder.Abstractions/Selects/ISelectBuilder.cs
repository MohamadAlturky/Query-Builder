namespace QueryBuilder.Abstractions.Contracts.Builders;

public interface ISelectBuilder
{
    ISelectBuilder Column(string columnName, string? alias = null);
}