using DataExtraction.Logic.Merchant;
using DataExtraction.Logic.MerchantQuests;

namespace DataExtraction.Logic.ObjectStore
{
    public static class CustomObjectStore 
    {
        public static MerchantDto[] Merchants { get; set; }
        public static QuestDto[] MerchantsQuests { get; set; }
    }
}
