namespace DataExtraction.Logic.MerchantQuests
{
    public interface IMerchantQuestsCommandHandler
    {
        void Handle();
    }

    public class MerchantQuestsCommandHandler : IMerchantQuestsCommandHandler
    {
        private readonly IMerchantQuestsParser _parser;
        private readonly IMerchantQuestsPersister _persister;

        public MerchantQuestsCommandHandler(IMerchantQuestsParser parser, IMerchantQuestsPersister persister)
        {
            _persister = persister;
            _parser = parser;
        }

        public void Handle()
        {
            var merchantsQuests = _parser.Parse();
            _persister.Persist(merchantsQuests);
        }
    }
}
