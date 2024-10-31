using QueryBuilder.Abstractions.Contracts;
using QueryBuilder.Abstractions.Models;

var db = new Db();
var party = new Table("party");
var role = new Table("role");
var user = new Table("user");

IViewBuilder viewBuilder = new ViewBuilder();
var joined = viewBuilder
    .Table(party)
    .InnerJoin(builder =>
    {
        builder.With(role);
        builder.OnEquals("party.Id","role.user");
    }).LeftJoin(builder =>
    {
        builder.With(user).OnEquals("user.party","party.Id");
    })
    .Build();

Console.WriteLine(joined.Clause);
//
// var roles = db.Query(joined);
// var users = db
//     .Query(role)
//     .As("r")
//     .Select(select =>
//     {
//         select.Column("Id");
//         select.Column("FirstName","Name");
//     })
//     .Where(where =>
//     {
//         where
//             .NotEqual("Id", 0)
//             .Like("Name","Mohamad");
//     })
//     .OrderBy(orderBy =>
//     {
//         orderBy.Ascending("Id");
//     });
//
//
