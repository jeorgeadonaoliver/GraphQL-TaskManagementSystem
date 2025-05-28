using GraphQL.TMS.Persistence.Context;
using GraphQL.TMS.Persistence.Repositories;
using GraphQL.TMS.Application.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQL.TMS.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection services,
           IConfiguration configuration)
        {
            services.AddDbContext<ProjdbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ProjDbConnectionString"));
            });

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            //services.AddScoped<IEmployeeProjectsRepository, EmployeeProjectRepository>();
            //services.AddScoped<IJobRepository, JobRepository>();
            //services.AddScoped<IProjectRepository, ProjectRepository>();
            //services.AddScoped<IRoleRepository, RoleRepository>();
            //services.AddScoped<ITeamRepository, TeamRepository>();

            return services;
        }
    }
}
