using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Contracts.Models;

namespace QueryBuilder.Abstractions.Models;

public class Table(string clause) : IView
{
    public string Clause { get; } = clause;
}