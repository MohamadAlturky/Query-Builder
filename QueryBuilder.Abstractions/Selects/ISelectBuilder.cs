namespace QueryBuilder.Abstractions.Selects;

public interface ISelectBuilder
{
    ISelectBuilder Column(string columnName, string? alias = null);
}