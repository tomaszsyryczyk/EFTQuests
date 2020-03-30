namespace DataExtraction.Logic.Merchant
{
    public interface IMerchantPersister
    {
        void Persist(MerchantDto[] merchants);
    }
}
