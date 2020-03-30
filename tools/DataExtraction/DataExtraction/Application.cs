using DataExtraction.Logic.Merchant;
using DataExtraction.Logic.MerchantQuests;
using DataExtraction.Logic.ObjectStore;

namespace DataExtraction
{
    public interface IApplication
    {
        void Start();
    }

    public class Application : IApplication
    {
        private readonly IGetMerchantsCommandHandler _merchantsCommandHandler;
        private readonly IMerchantQuestsCommandHandler _merchantQuestsCommandHandler;

        public Application(IGetMerchantsCommandHandler merchantsCommandHandler, IMerchantQuestsCommandHandler merchantQuestsCommandHandler)
        {
            _merchantQuestsCommandHandler = merchantQuestsCommandHandler;
            _merchantsCommandHandler = merchantsCommandHandler;
        }

        public void Start()
        {
            ParseMerchants();
            ParseMerchantQuests();
            var test1 = CustomObjectStore.Merchants;
            var test2  = CustomObjectStore.MerchantsQuests;
        }

        private void ParseMerchantQuests()
        {
            _merchantQuestsCommandHandler.Handle();
        }

        private void ParseMerchants()
        {
            _merchantsCommandHandler.Handle();
        }
    }
}
