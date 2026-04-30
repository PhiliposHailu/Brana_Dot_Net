var builder = WebApplication.CreateBuilder(args);

// tells the DI container about our controllers
builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// this maps our [Route] attributes to the HTTP pipeline
app.MapControllers(); 

app.Run();