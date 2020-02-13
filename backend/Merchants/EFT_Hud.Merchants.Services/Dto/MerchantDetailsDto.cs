using System.Collections.Generic;

namespace EFT_Hud.Merchants.Services.Dto
{
    public class MerchantDetailsDto : MerchantDto
    {
        public ICollection<QuestDto> Quests { get; set; }
    }
}
