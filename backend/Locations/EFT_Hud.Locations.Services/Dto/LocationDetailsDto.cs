using System.Collections.Generic;

namespace EFT_Hud.Locations.Services.Dto
{
    public class LocationDetailsDto : LocationDto
    {
        public ICollection<QuestDto> Quests { get; set; }
    }
}
