using System.Collections.Generic;

namespace EFT_Hud.Models
{
    public class QuestDto
    {
        public int Id {get;set;}
        public int MerchantId {get;set;}
        public string Name {get;set;}
        public ICollection<string> Requirements {get;set;}
        public ICollection<QuestItemRequirementDto> ItemRequirements {get;set;}
        public ICollection<string> Rewards {get;set;}
    }
}
