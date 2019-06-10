using dotnetsqlserverexample;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Testing
{
    public class TestStartup : Startup
    {
        public TestStartup(IConfiguration configuration) : base(configuration)
        {
        }

        public override void ConfigureDatabase(IServiceCollection services)
        {
            services.AddDbContext<dotnetsqlserverexample.Models.AppContext>(options =>
                options.UseInMemoryDatabase("test_db"));

        }
    }
}
