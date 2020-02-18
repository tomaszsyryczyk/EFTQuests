using AutoMapper;
using EFT_Hud.DAL.Entities;
using EFT_Hud.Quests.Services.Dto;

namespace EFT_Hud.Quests.Services
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
                cfg.CreateMap<Merchant, MerchantDto>();
                cfg.CreateMap<Quest, QuestDto>();
                cfg.CreateMap<Objective, ObjectiveDto>();
                cfg.CreateMap<Item, ItemDto>();
                cfg.CreateMap<Reward, RewardDto>();
            });

            var mapper = config.CreateMapper();

            return mapper;
        }
    }
}
