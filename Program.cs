using PantryApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<PantryContext>(options =>
    options.UseSqlite("Data Source=pantry.db"));


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowGitHubPages",
        policy =>
        {
            policy.WithOrigins("https://f4lch100nnn.github.io")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
}

app.UseHttpsRedirection();
app.UseCors("AllowGitHubPages");
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PantryContext>();
    db.Database.Migrate();
}


app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
