using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Moryakov_КТ_41_22.Database;
using Moryakov_КТ_41_22.Interfaces;

namespace Moryakov_КТ_41_22.ServiceExtensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Добавляем DbContext
            services.AddDbContext<Teacher_Dbcontext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ITeacherService, TeacherService>();
        }
    }
}
