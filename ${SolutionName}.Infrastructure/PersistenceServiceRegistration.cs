using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Lawyer;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.AcademicInfo;
using ${SolutionName}.Application.Contracts.Interfaces.Persistence.Example;
using ${SolutionName}.Infrastructure.DatabaseContext;
using ${SolutionName}.Infrastructure.Model.MappingProfile;
using ${SolutionName}.Infrastructure.Repositories.Lawyer;
using ${SolutionName}.Infrastructure.Repositories.Laywer;
using ${SolutionName}.Infrastructure.Repositories.AcademicInfo;
using ${SolutionName}.Infrastructure.Repositories.Example;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ${SolutionName}.Infrastructure;

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
        services.AddScoped<IAcademicInfoCommandRepository, AcademicInfoCommandRepository>();
        services.AddScoped<IAcademicInfoQueryRepository, AcademicInfoQueryRepository>();
        services.AddScoped<IExampleCommandRepository, ExampleCommandRepository>();
        services.AddScoped<IExampleQueryRepository, ExampleQueryRepository>();

        return services;    }}