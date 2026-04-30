var builder = WebApplication.CreateBuilder(args);

// 1. You MUST add this to tell the DI container about your controllers
builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// 2. You MUST add this to map your [Route] attributes to the HTTP pipeline
app.MapControllers(); 

app.Run();