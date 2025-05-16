using APIs.Middlewares;
using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Initialize Sentry properly using the extension method
builder.WebHost.UseSentry(o =>
{
    o.Dsn = builder.Configuration.GetConnectionString("Sentry");
    o.ProfilesSampleRate = 0.1;
    o.TracesSampleRate = 1.0;
});

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Inject deps
builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplications();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.Run();