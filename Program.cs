using SpotifyApi.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var databaseOptions = 
    builder.Configuration
        .GetSection(DatabaseOptions.SectionName)
        .Get<DatabaseOptions>()
    ?? new DatabaseOptions();

builder.Services.AddSingleton(databaseOptions);

builder.Services.AddSqlClientRepositories();
// builder.Services.AddDapperRepositories();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();
