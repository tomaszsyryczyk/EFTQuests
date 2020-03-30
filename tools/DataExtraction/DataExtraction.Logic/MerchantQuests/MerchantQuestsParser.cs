using System;

namespace DataExtraction.Logic.MerchantQuests
{
    public interface IMerchantQuestsParser
    {
        object[] Parse(string merchantName);
    }

    public class MerchantQuestsParser : IMerchantQuestsParser
    {
        public object[] Parse(string merchantName)
        {
            throw new NotImplementedException();
        }
    }
}
