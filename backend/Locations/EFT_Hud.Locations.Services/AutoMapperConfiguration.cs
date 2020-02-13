using AutoMapper;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Locations.Services.Dto;

namespace EFT_Hud.Locations.Services
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
                cfg.CreateMap<Location, LocationDto>();
                cfg.CreateMap<Location, LocationDetailsDto>();
                cfg.CreateMap<Quest, QuestDto>(); 
            });

            var mapper = config.CreateMapper();

            return mapper;
        }
    }
}
