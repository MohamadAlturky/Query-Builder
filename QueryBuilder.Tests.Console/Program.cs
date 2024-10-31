using QueryBuilder.Abstractions;
using QueryBuilder.Abstractions.Contracts.Builders;
using QueryBuilder.Abstractions.Database;
using QueryBuilder.Abstractions.Models;
using QueryBuilder.Abstractions.Queryables;

var db = new Db();
Table party = new Table("Party");
Table role = new Table("role");
IQueryableViewBuilder viewBuilder = new QueryableViewBuilder();
var joined = viewBuilder
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
    }).Build();  

var roles = db.Query(joined);
var users = db
    .Query(role)
    .As("r")
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


