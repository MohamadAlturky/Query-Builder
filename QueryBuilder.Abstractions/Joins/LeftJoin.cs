using QueryBuilder.Abstractions.Contracts;

namespace QueryBuilder.Abstractions.Joins;

public class LeftJoin(IView view, string leftKey, string rightKey) : IJoin
{
    public IView View { get; } = view;
    public string LeftKey { get; } = leftKey;
    public string RightKey { get; } = rightKey;
    public JoinType Type => JoinType.Left;
    public override string ToString()
    {
        return $"Left Join {View.Clause} on {LeftKey} = {RightKey}";
    }

    public void DisplayJoinInfo() => Console.WriteLine($"\n Left Join {View.Clause} on {LeftKey} = {RightKey}");
}