using System;
using System.Collections.Generic;

namespace EFT_Hud.Models
{
    public class MerchantDto
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public string IconName {get;set;}
        public ICollection<QuestDto> Quests {get;set;}
    }
}
