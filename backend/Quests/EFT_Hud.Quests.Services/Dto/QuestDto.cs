using System.Collections.Generic;

namespace EFT_Hud.Quests.Services.Dto
{
    public class QuestDto
    {
        public int Id { get; set; }
        public int MerchantId { get; set; }
        public string Name { get; set; }

        public ICollection<LocationDto> Locations { get; set; }
    }
}
