using SuperHeroApi.Data;
using SuperHeroApi.Interfaces;
using SuperHeroApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Application Db Context options
builder.Services.Configure<MongoDbConfiguration>(builder.Configuration.GetSection("MongoDbConfiguration"));

// Register custom services for the superheroes
builder.Services.AddSingleton<ApplicationDbContext>();
//builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<ISuperheroRepository, SuperheroRepository>();
builder.Services.AddScoped<ISuperpowerRepository, SuperpowerRepository>();
builder.Services.AddScoped<IMovieRepository, MovieRepository>();
builder.Services.AddGraphQLServer().AddQueryType<Query>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

app.Run();