using System.Collections.Generic;
using System.Linq;
using EFTQuests.Data;

namespace EFTQuests.Services
{
    public static class MerchantService
    {
        public static List<Merchant> GetMerchants()
        {
            var result = new List<Merchant>();
            using (var context = new EftQuestDbContext())
            {
                var merchants = context.Merchants
                    .ToList();

                return merchants;
            }
        }

        private static string GetMerchantIcon(string iconName)
        {
            return $"/Icons/Merchants/{iconName}";
        }
    }
}
