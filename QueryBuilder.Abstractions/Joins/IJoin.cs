using QueryBuilder.Abstractions.Contracts;

namespace QueryBuilder.Abstractions.Joins;

public interface IJoin
{
    IView View { get; }
    string LeftKey { get; }
    string RightKey { get; }
    JoinType Type { get; }
    void DisplayJoinInfo();
}