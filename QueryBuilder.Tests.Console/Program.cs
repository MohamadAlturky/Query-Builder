using QueryBuilder.Abstractions;
using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Contracts.Builders;
using QueryBuilder.Abstractions.Database;
using QueryBuilder.Abstractions.Models;

var db = new Db();
var party = new Table("Party");
var role = new Table("role");
IViewBuilder viewBuilder = new ViewBuilder();
var joined = viewBuilder
    .Table(party)
    .InnerJoin(builder =>
    {
        builder.With(party);
        builder.On(where =>
        {
            where.Equal("Id","sad");
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


