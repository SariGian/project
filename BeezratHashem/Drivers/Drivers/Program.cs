
using DalDriver;
using DalDriver.DalApi;
using DalDriver.Dalimplementaion;
using DalDriver.Models;
using DBAccess;
using Microsoft.EntityFrameworkCore;
using AddressServices = DalDriver.Dalimplementaion.AddressServices;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();


DBActions db = new DBActions(builder.Configuration);
string connStr = db.GetConnectionString("Driver");
builder.Services.AddDbContext<DriverContext>(opt => opt.UseSqlServer(connStr));
builder.Services.AddScoped < IAddress, AddressServices>();

app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
