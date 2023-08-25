using projectEf;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

var builder = WebApplication.CreateBuilder(args);
//builder.Services.AddDbContext<TareasContext>(x => x.UseInMemoryDatabase("TasksDB"));
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("TareasDB"));

var app = builder.Build();
//app.MapGet("/", () => "Hello World!");
app.MapGet("/DBconexion", async([FromServices] TareasContext DbContext)=> {
    DbContext.Database.EnsureCreated();
    return Results.Ok("DB corriendo en memoria " + DbContext.Database.IsInMemory());
});
app.Run();
