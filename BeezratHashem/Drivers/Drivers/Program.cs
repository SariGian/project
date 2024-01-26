
using DalDriver;
using DalDriver.Models;
using DBAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();


DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("Driver");
builder.Services.AddDbContext<DriverContext>(opt => opt.UseSqlServer(connStr));

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
