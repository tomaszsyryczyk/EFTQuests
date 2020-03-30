using DataExtraction.Logic.ObjectStore;

namespace DataExtraction.Logic.Merchant
{
    public class MerchantPersister : IMerchantPersister
    {
        public void Persist(MerchantDto[] merchants)
        {
            CustomObjectStore.Merchants = merchants;
        }
    }
}
