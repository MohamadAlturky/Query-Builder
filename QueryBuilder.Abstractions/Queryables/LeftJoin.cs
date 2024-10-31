namespace QueryBuilder.Abstractions.Queryables;

public class LeftJoin : IJoin
{
    public string Table { get; }
    public string LeftKey { get; }
    public string RightKey { get; }
    public JoinType Type => JoinType.Left;

    public LeftJoin(string table, string leftKey, string rightKey)
    {
        Table = table;
        LeftKey = leftKey;
        RightKey = rightKey;
    }

    public void DisplayJoinInfo() => Console.WriteLine($"Left Join on {Table} using {LeftKey} = {RightKey}");
}