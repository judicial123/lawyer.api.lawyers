using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model.MappingProfile;
using lawyer.api.lawyers.datastore.mssql.Repositories.Lawyer;
using lawyer.api.lawyers.datastore.mssql.Repositories.Laywer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lawyer.api.lawyers.datastore.mssql;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<LawyersContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("LawyersConnectionString")));
        services.AddAutoMapper(typeof(ApplicationMappingProfile).Assembly);
        services.AddScoped<ILawyerCommandRepository, LawyerCommandRepository>();
        services.AddScoped<ILawyerQueryRepository, LawyerQueryRepository>();

        return services;
    }
}