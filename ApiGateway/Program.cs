using Ocelot.DependencyInjection;
using Ocelot.Middleware;

IConfiguration configuration = new ConfigurationBuilder()
                                    .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
                                    .Build();

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOcelot(configuration);

var app = builder.Build();
app.UseHttpsRedirection();
app.UseOcelot();
app.Run();
