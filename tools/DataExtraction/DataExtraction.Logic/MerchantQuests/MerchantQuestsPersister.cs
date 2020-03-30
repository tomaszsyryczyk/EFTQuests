using DataExtraction.Logic.ObjectStore;

namespace DataExtraction.Logic.MerchantQuests
{
    public class MerchantQuestsPersister : IMerchantQuestsPersister
    {
        public void Persist(QuestDto[] merchantsQuests)
        {
            CustomObjectStore.MerchantsQuests = merchantsQuests;
        }
    }
}
