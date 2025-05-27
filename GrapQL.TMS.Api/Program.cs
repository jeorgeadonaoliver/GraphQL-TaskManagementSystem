using GraphQL.TMS.Persistence;
using GraphQL.TMS.Application;
using GraphQL.TMS.Api.GraphQL.queries;
using GraphQL.TMS.Api.Endpoints;
using GraphQL.TMS.Api.GraphQL.mutations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddApplicationServices();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add GRAPHQL
builder.Services
    .AddGraphQLServer()
    .AddQueryType( d => d.Name("Query"))
    .AddMutationType(s => s.Name("Mutation"))
    .AddTypeExtension<EmployeeQuery>()
    .AddTypeExtension<EmployeeMutation>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGraphQL();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapEmployeeEndpoints();


app.Run();
