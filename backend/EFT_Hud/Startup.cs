using EFT_Hud.DAL.Entities;
using EFT_Hud.DAL.Repositories;
using EFT_Hud.Filters;
using EFT_Hud.Locations.Services;
using EFT_Hud.Merchants.Services;
using EFT_Hud.Quests.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EFT_Hud
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(options => options.Filters.Add(new HttpResponseExceptionFilter()));
            services.AddCors();
            
            services.AddDbContext<EftHudDbContext>(options => {
                options.UseMySql(
                    Configuration.GetConnectionString("DbContext"), 
                    x => x.MigrationsAssembly("EFT_Hud.DAL"));
            });

            RepositoriesInstaller.Install(services);
            ServiceInstaller(services);
        }

        private void ServiceInstaller(IServiceCollection services)
        {
            services.AddScoped<IMerchantsService, MerchantsService>();
            services.AddScoped<ILocationsService, LocationsService>();
            services.AddScoped<IQuestsService, QuestsService>();
        }

        private static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<EftHudDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            UpdateDatabase(app);
            app.UseHttpsRedirection();
            
            app.UseRouting();
            app.UseCors(
                options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()
            );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
