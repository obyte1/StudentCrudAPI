using StudentCrud.Domain.Implementation;
using StudentCrud.Domain.Repository;

namespace StudentCrud.Data
{
    public class CoreServiceBuilder
    {
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IStudentManager, StudentManager>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IStudentRepository, StudentRepository>();

        }
    }
}
