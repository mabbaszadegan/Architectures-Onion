using Contracts;
using LoggerService;
using Repository;
using Service;
using Service.Contracts;

namespace Net6APISample.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
                services.AddCors(options =>
                {
                    options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
                });

        public static void ConfigureIISIntegration(this IServiceCollection services) =>
                services.Configure<IISOptions>(options =>
                {

                });

        public static void ConfigureLoggerService(this IServiceCollection services) => services.AddSingleton<ILoggerManager, LoggerManager>();
        public static void ConfigureRepositoryManager(this IServiceCollection services) => services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) => services.AddScoped<IServiceManager, ServiceManager>();
        public static void ConfigureCompanyRepository(this IServiceCollection services) => services.AddScoped<ICompanyRepository, CompanyRepository>();
        public static void ConfigureEmployeeRepository(this IServiceCollection services) => services.AddScoped<IEmployeeRepository, EmployeeRepository>();

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddSqlServer<RepositoryContext>(configuration.GetConnectionString("sqlConnection"));
    }
}
