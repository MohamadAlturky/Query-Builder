namespace QueryBuilder.Abstractions.Queryables;

public interface IJoin
{
    string Table { get; }
    string LeftKey { get; }
    string RightKey { get; }
    JoinType Type { get; }
    void DisplayJoinInfo();
}