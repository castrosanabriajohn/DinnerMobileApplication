var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
{
    builder.Services.AddControllers();
}

var app = builder.Build();
// Request pipeline configuration
{ 
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}
