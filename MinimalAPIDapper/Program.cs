using MinimalAPIDapper.Entities;

//###services zone

var builder = WebApplication.CreateBuilder(args);

//###

var app = builder.Build();

//###middleware zone
app.MapGet("/", () => "Hello World!");

app.MapGet("/genres", () =>
{
    var genres = new List<Genre>
    {
        new Genre { Id = 1, Name = "Action" },
        new Genre { Id = 2, Name = "Comedy" },
        new Genre { Id = 3, Name = "Drama" }
    };
    return genres;
});
//###

app.Run();
