using QueryBuilder.Abstractions;
using QueryBuilder.Abstractions.Builders;
using QueryBuilder.Abstractions.Database;
using QueryBuilder.Abstractions.Queryables;
using QueryBuilder.Abstractions.QueryableViews;

var db = new Db();
Table party = new Table("Party");

var roles = db.Query("Role");
var users = db
    .Query("Party")
    .As("U")
    .Select(select =>
    {
        select.Column("Id");
        select.Column("FirstName","Name");
    })
    .Where(where =>
    {
        where
            .NotEqual("Id", 0)
            .Like("Name","Mohamad");
    })
    .OrderBy(orderBy =>
    {
        orderBy.Ascending("Id");
    });

var sql= """
         Select Id Users innerJoin 
         (Select Id From Roles where RoleId=@RoleId)  
         On Users.Id=Roles.Id
    """;


IQueryableViewBuilder viewBuilder = new QueryableViewBuilder();
viewBuilder
    .Table(party)
    .View(party)
    .OuterJoin(builder =>
    {
        builder.With(party);
        builder.Where(where =>
        {
            where.Equal("Id",1);
            where.Like("Name", "s");
        });
    });  