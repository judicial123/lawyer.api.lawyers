using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Lawyer;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.AcademicInfo;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.Example;
using lawyer.api.lawyers.application.Contracts.Interfaces.Persistence.LawFirm;
using lawyer.api.lawyers.datastore.mssql.DatabaseContext;
using lawyer.api.lawyers.datastore.mssql.Model.MappingProfile;
using lawyer.api.lawyers.datastore.mssql.Repositories.Lawyer;
using lawyer.api.lawyers.datastore.mssql.Repositories.Laywer;
using lawyer.api.lawyers.datastore.mssql.Repositories.AcademicInfo;
using lawyer.api.lawyers.datastore.mssql.Repositories.Example;
using lawyer.api.lawyers.datastore.mssql.Repositories.LawFirm;
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
        services.AddScoped<IAcademicInfoCommandRepository, AcademicInfoCommandRepository>();
        services.AddScoped<IAcademicInfoQueryRepository, AcademicInfoQueryRepository>();
        services.AddScoped<IExampleCommandRepository, ExampleCommandRepository>();
        services.AddScoped<IExampleQueryRepository, ExampleQueryRepository>();
        services.AddScoped<ILawFirmCommandRepository, LawFirmCommandRepository>();
        services.AddScoped<ILawFirmQueryRepository, LawFirmQueryRepository>();

        return services;
    }}