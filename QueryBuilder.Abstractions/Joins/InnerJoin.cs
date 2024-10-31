namespace QueryBuilder.Abstractions.Joins;

public class InnerJoin(string table, string leftKey, string rightKey) : IJoin
{
    public string Table { get; } = table;
    public string LeftKey { get; } = leftKey;
    public string RightKey { get; } = rightKey;
    public JoinType Type => JoinType.Inner;

    public void DisplayJoinInfo() => Console.WriteLine($"Inner Join on {Table} using {LeftKey} = {RightKey}");
}