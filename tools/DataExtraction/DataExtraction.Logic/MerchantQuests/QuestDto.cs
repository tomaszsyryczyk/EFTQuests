namespace DataExtraction.Logic.MerchantQuests
{
    public class QuestDto
    {
        private string _questName;
        private QuestObjectiveDto[] _objectives;
        private QuestRewardsDto[] _rewards;

        public QuestDto(string questName, QuestObjectiveDto[] objectives, QuestRewardsDto[] rewards)
        {
            _rewards = rewards;
            _objectives = objectives;
            _questName = questName;
        }
    }

    public class QuestObjectiveDto
    {
        private string _objective;

        public QuestObjectiveDto(string objective)
        {
            _objective = objective;
        }
    }

    public class QuestRewardsDto
    {
        private string _reward;

        public QuestRewardsDto(string reward)
        {
            _reward = reward;
        }
    }
}
