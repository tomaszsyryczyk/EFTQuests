using EFT_Hud.DAL.Entities;

namespace EFT_Hud.Quests.Services.Dto
{
    public class RewardDto
    {
        public RewardType Type { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }

        public ItemDto Item { get; set; }

    }
}
