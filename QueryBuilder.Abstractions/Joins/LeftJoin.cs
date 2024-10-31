namespace QueryBuilder.Abstractions.Joins;

public class LeftJoin(string table, string leftKey, string rightKey) : IJoin
{
    public string Table { get; } = table;
    public string LeftKey { get; } = leftKey;
    public string RightKey { get; } = rightKey;
    public JoinType Type => JoinType.Left;

    public void DisplayJoinInfo() => Console.WriteLine($"Left Join on {Table} using {LeftKey} = {RightKey}");
}