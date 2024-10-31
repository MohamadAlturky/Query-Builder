using QueryBuilder.Abstractions.Contracts;

namespace QueryBuilder.Abstractions.Joins;

public class OuterJoin(IView view, string leftKey, string rightKey) : IJoin
{
    public IView View { get; } = view;
    public string LeftKey { get; } = leftKey;
    public string RightKey { get; } = rightKey;
    public JoinType Type => JoinType.Inner;
    public override string ToString()
    {
        return $"\n Outer Join {View.Clause} \n     on {LeftKey} = {RightKey}";
    }

    public void DisplayJoinInfo() => Console.WriteLine($"\n Outer Join {View.Clause} on {LeftKey} = {RightKey}");
}