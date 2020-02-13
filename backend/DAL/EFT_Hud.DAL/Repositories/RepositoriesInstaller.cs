using EFT_Hud.Locations.Interfaces;
using EFT_Hud.Merchants.Interfaces;
using EFT_Hud.Quests.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EFT_Hud.DAL.Repositories
{
    public static class RepositoriesInstaller
    {
        public static void Install(IServiceCollection services)
        {
            services.AddScoped<IMerchantRepository,MerchantsRepository>();
            services.AddScoped<ILocationsRepository, LocationsRepository>();
            services.AddScoped<IQuestsRepository, QuestsRepository>();
        }
    }
}
