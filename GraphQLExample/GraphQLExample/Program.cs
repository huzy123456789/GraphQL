using HotChocolate.AspNetCore.Voyager;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<GraphQLExample.GraphQL.Query>(); // Adjust namespace accordingly

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Enable Voyager middleware for GraphQL
app.UseVoyager("/graphql-voyager");

// Enable GraphQL endpoints
app.MapGraphQL();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
