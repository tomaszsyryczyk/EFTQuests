namespace DataExtraction.Logic.MerchantQuests
{
    public interface IMerchantQuestsPersister
    {
        void Persist(QuestDto[] merchantsQuests);
    }
}
