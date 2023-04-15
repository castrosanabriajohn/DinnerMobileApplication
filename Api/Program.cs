using Application.Extensions.DependencyInjection;
using Architecture.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
{
    builder.Services.AddControllers();
    builder.Services
        .AddApplication()
        .AddInfrastructure();
}

var app = builder.Build();
// Request pipeline configuration.
{ 
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
