using QueryBuilder.Abstractions.Contracts.Models;

namespace QueryBuilder.Abstractions.Models;

public class Table(string clause) : IQueryableView
{
    public string Clause { get; } = clause;
}