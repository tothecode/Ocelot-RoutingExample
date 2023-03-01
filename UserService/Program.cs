using UserService.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();

var app = builder.Build();
app.UseHttpsRedirection();
app.MapControllers();

app.Run();
