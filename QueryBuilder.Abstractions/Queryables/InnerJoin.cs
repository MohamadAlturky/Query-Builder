namespace QueryBuilder.Abstractions.Queryables;

public class InnerJoin : IJoin
{
    public string Table { get; }
    public string LeftKey { get; }
    public string RightKey { get; }
    public JoinType Type => JoinType.Inner;

    public InnerJoin(string table, string leftKey, string rightKey)
    {
        Table = table;
        LeftKey = leftKey;
        RightKey = rightKey;
    }

    public void DisplayJoinInfo() => Console.WriteLine($"Inner Join on {Table} using {LeftKey} = {RightKey}");
}