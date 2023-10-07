using Microsoft.EntityFrameworkCore;

namespace DolphinTodoWebAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseNpgsql(_configuration.GetConnectionString("DefaultConnection")));
        }
    }
}

