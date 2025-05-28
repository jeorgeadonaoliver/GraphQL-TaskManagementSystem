using GraphQL.TMS.Persistence;
using GraphQL.TMS.Application;
using GraphQL.TMS.Api.GraphQL.queries;
using GraphQL.TMS.Api.Endpoints;
using GraphQL.TMS.Api.GraphQL.mutations;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((context, services, configuration) =>
    configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services)
        .Enrich.FromLogContext());

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
    .AddTypeExtension<EmployeeMutation>()
    .AddTypeExtension<DepartmentQuery>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseSerilogRequestLogging();

app.MapGraphQL();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapEmployeeEndpoints();
app.MapDepartmentEndpoints();


app.Run();
