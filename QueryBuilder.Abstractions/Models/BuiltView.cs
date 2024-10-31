using QueryBuilder.Abstractions.Contracts;

namespace QueryBuilder.Abstractions.Models;

public class BuiltView : IView
{
    public BuiltView(string clause)
    {
        Clause = clause;
    }

    public string Clause { get; }
}