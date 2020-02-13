using System.Collections.Generic;

namespace EFT_Hud.Locations.Services.Dto
{
    public class QuestDto
    {
        public int Id {get;set;}
        public string Name {get;set;}

        public ICollection<LocationDto> Locations { get; set; }
    }
}
