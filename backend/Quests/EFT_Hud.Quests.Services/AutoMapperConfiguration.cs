using System;
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
                cfg.CreateMap<Objective, ObjectiveDto>()
                    .ForMember(dto => dto.Location,entity => entity.MapFrom(value => value.Location.Name))
                    .ForMember(x => x.Description, entity => entity.MapFrom(value => GetDescription(value)))
                    .ForMember(x => x.ObjectiveType, entity => entity.MapFrom(value => GetObjectiveType(value.Type)))
                    .ForMember(x => x.Using, entity => entity.MapFrom(value => value.UsingItem.Name));
                cfg.CreateMap<Item, ItemDto>();
                cfg.CreateMap<Reward, RewardDto>()
                    .ForMember(dto => dto.Type, entity => entity.MapFrom(value => GetRewardType(value.Type)))
                    .ForMember(x => x.Item, entity => entity.MapFrom(value => GetItem(value.Item)));
            });

            var mapper = config.CreateMapper();

            return mapper;
        }

        private static string GetItem(Item valueItem)
        {
            return valueItem.Name;
        }

        private static string GetRewardType(RewardType valueType)
        {
            switch (valueType)
            {
                case RewardType.Item:
                    return "Item";
                case RewardType.Exp:
                    return "Exp";
                case RewardType.Unlock:
                    return "Unlock";
                case RewardType.PraporReputation:
                    return "Prapor reputation";
                case RewardType.TherapistReputation:
                    return "Therapist reputation";
                case RewardType.SkierReputation:
                    return "Skier reputation";
                case RewardType.PeacekeeperReputation:
                    return "Peacekeeper reputation";
                case RewardType.MechanicReputation:
                    return "Mechanic reputation";
                case RewardType.RagmanReputation:
                    return "Ragman reputation";
                case RewardType.JeagerReputation:
                    return "Jeager reputation";
                case RewardType.FenceReputation:
                    return "Fence reputation";
                default:
                    throw new ArgumentOutOfRangeException(nameof(valueType), valueType, null);
            }
        }

        private static string GetObjectiveType(ObjectiveType valueType)
        {
            switch (valueType)
            {
                case ObjectiveType.Handover:
                    return "Hand over";
                case ObjectiveType.Find:
                    return "Find";
                case ObjectiveType.FindInRaid:
                    return "Find in raid";
                case ObjectiveType.Elimination:
                    return "Eliminate";
                case ObjectiveType.Discover:
                    return "Discover";
                case ObjectiveType.Skill:
                    return "Reach";
                case ObjectiveType.Exit:
                    return "Exit";
                case ObjectiveType.Mark:
                    return "Mark";
                case ObjectiveType.Deliver:
                    return "Deliver";
                case ObjectiveType.Kill:
                    return "Kill";
                case ObjectiveType.Other:
                    return "Other";
                default:
                    throw new ArgumentOutOfRangeException(nameof(valueType), valueType, null);
            }
        }

        private static string GetDescription(Objective value)
        {
            return string.IsNullOrEmpty(value.Description) ? value.Item.Name : value.Description;
        }
    }
}
