var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// In development, enable Swagger UI and Swagger JSON.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// These are for routing and security, and must come AFTER the Swagger middleware.
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
