namespace DataExtraction.Logic.Merchant
{
    public interface IGetMerchantsCommandHandler
    {
        void Handle();
    }

    public class GetMerchantsCommandHandler : IGetMerchantsCommandHandler
    {
        private readonly IMerchantParser _parser;
        private readonly IMerchantPersister _persister;

        public GetMerchantsCommandHandler(IMerchantParser parser, IMerchantPersister persister)
        {
            _persister = persister;
            _parser = parser;
        }

        public void Handle()
        {
            var merchants = _parser.Parse();
            _persister.Persist(merchants);
        }
    }
}
