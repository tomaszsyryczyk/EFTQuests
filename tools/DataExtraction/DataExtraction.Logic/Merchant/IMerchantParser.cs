using System.Collections.Generic;
using HtmlAgilityPack;

namespace DataExtraction.Logic.Merchant
{
    public interface IMerchantParser
    {
        MerchantDto[] Parse();
    }
}
