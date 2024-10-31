namespace QueryBuilder.Abstractions.Joins;

public interface IJoin
{
    string Table { get; }
    string LeftKey { get; }
    string RightKey { get; }
    JoinType Type { get; }
    void DisplayJoinInfo();
}