using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Contracts.Builders;
using QueryBuilder.Abstractions.Contracts.Models;
using QueryBuilder.Abstractions.Wheres;

namespace QueryBuilder.Abstractions.Joins.Builders;

public interface IJoinBuilder
{
    IJoinBuilder With(IView view);
    
    IJoinBuilder On(Action<IOnBuilder> where);
}

public interface IOnBuilder
{
    IOnBuilder Equal(string columnName, string anotherColumnName);
    
    
    IOnBuilder NotEqual(string columnName, string anotherColumnName);
    
    
    IOnBuilder Bigger(string columnName, string anotherColumnName);
    
    
    IOnBuilder BiggerOrEqual(string columnName, string anotherColumnName);




    
    IOnBuilder Smaller(string columnName, string anotherColumnName);
   
    IOnBuilder SmallerOrEqual(string columnName, string anotherColumnName);
  

    
    IOnBuilder Like(string columnName, string anotherColumnName);

}