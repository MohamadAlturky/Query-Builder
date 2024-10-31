namespace QueryBuilder.Abstractions;

public interface IWhereBuilder
{
    IWhereBuilder Equal(string columnName, int parameter);
    IWhereBuilder Equal(string columnName, string parameter);
    IWhereBuilder Equal(string columnName, DateTime parameter);
    IWhereBuilder Equal(string columnName, DateOnly parameter);
    IWhereBuilder Equal(string columnName, long parameter);
    
    
    IWhereBuilder NotEqual(string columnName, int parameter);
    IWhereBuilder NotEqual(string columnName, string parameter);
    IWhereBuilder NotEqual(string columnName, DateTime parameter);
    IWhereBuilder NotEqual(string columnName, DateOnly parameter);
    IWhereBuilder NotEqual(string columnName, long parameter);
    
    
    IWhereBuilder Bigger(string columnName, int parameter);
    IWhereBuilder Bigger(string columnName, string parameter);
    IWhereBuilder Bigger(string columnName, DateTime parameter);
    IWhereBuilder Bigger(string columnName, DateOnly parameter);
    IWhereBuilder Bigger(string columnName, long parameter);
    
    
    IWhereBuilder BiggerOrEqual(string columnName, int parameter);
    IWhereBuilder BiggerOrEqual(string columnName, string parameter);
    IWhereBuilder BiggerOrEqual(string columnName, DateTime parameter);
    IWhereBuilder BiggerOrEqual(string columnName, DateOnly parameter);
    IWhereBuilder BiggerOrEqual(string columnName, long parameter);



    
    IWhereBuilder Smaller(string columnName, int parameter);
    IWhereBuilder Smaller(string columnName, string parameter);
    IWhereBuilder Smaller(string columnName, DateTime parameter);
    IWhereBuilder Smaller(string columnName, DateOnly parameter);
    IWhereBuilder Smaller(string columnName, long parameter);
    
    
    IWhereBuilder SmallerOrEqual(string columnName, int parameter);
    IWhereBuilder SmallerOrEqual(string columnName, string parameter);
    IWhereBuilder SmallerOrEqual(string columnName, DateTime parameter);
    IWhereBuilder SmallerOrEqual(string columnName, DateOnly parameter);
    IWhereBuilder SmallerOrEqual(string columnName, long parameter);

    
    IWhereBuilder Like(string columnName, int parameter);
    IWhereBuilder Like(string columnName, string parameter);
    IWhereBuilder Like(string columnName, DateTime parameter);
    IWhereBuilder Like(string columnName, DateOnly parameter);
    IWhereBuilder Like(string columnName, long parameter);

}