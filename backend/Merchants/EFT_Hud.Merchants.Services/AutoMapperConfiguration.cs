using AutoMapper;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Merchants.Services.Dto;

namespace EFT_Hud.Merchants.Services
{
    public static class AutoMapperHelper
    {
        public static TDesc Map<TSource, TDesc>(TSource source)
        {
            var mapper = CreateMapper();
            return mapper.Map<TSource, TDesc>(source);
        }

        private static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Merchant, MerchantDto>();
                cfg.CreateMap<Merchant, MerchantDetailsDto>();
                cfg.CreateMap<Quest, QuestDto>(); 
                cfg.CreateMap<Location, LocationDto>();
            });

            var mapper = config.CreateMapper();

            return mapper;
        }
    }
}
