using System.Collections.Generic;
using System.Linq;
using DataExtraction.Logic.Merchant;
using DataExtraction.Logic.ObjectStore;
using DataExtraction.Logic.PageHtmlProvider;
using HtmlAgilityPack;

namespace DataExtraction.Logic.MerchantQuests
{
    public class MerchantQuestsParser : IMerchantQuestsParser
    {
        private readonly IPageHtmlProvider _pageHtmlProvider;

        private readonly List<QuestDto> _result;
        private HtmlDocument _document;
        private MerchantDto[] _merchants;

        public MerchantQuestsParser(IPageHtmlProvider pageHtmlProvider)
        {
            _result = new List<QuestDto>();
            _pageHtmlProvider = pageHtmlProvider;
        }

        public QuestDto[] Parse()
        {
            LoadHtml();
            LoadMerchants();

            ParseQuests();

            return _result.ToArray();
        }

        private void ParseQuests()
        {
            foreach (var merchant in _merchants)
            {
                ParseQuestsForMerchant(merchant.Name);
            }
        }

        private void ParseQuestsForMerchant(string merchantName)
        {
            var xpath = $"//table[contains(@class, '{merchantName}-content')]//tr";
            var rows = _document.DocumentNode.SelectNodes(xpath);

            var quests = rows.Skip(2).ToList();
            foreach (var quest in quests)
            {
                ParseQuestHtmlRow(quest);
            }
        }

        private void ParseQuestHtmlRow(HtmlNode questRow)
        {
            var questName = ExtractQuestName(questRow);
            var objectives = ExtractObjectives(questRow);
            var rewards = ExtractRewards(questRow);

            var quest = new QuestDto(questName, objectives, rewards);
            _result.Add(quest);
        }

        private QuestRewardsDto[] ExtractRewards(HtmlNode quest)
        {
            var trNodes = quest.ChildNodes.Where(x => x.Name == "td");
            var rewardsRawRow = trNodes.Last();
            var rewards = rewardsRawRow
                .SelectNodes(rewardsRawRow.XPath + "//li")
                .Select(x => new QuestRewardsDto(x.InnerHtml))
                .ToArray();

            return rewards;
        }

        private QuestObjectiveDto[] ExtractObjectives(HtmlNode quest)
        {
            var trNodes = quest.ChildNodes.Where(x => x.Name == "td");
            var objectivesRawRow = trNodes.First();
            var objectives = objectivesRawRow
                .SelectNodes(objectivesRawRow.XPath + "//li")
                .Select(x => new QuestObjectiveDto(x.InnerHtml))
                .ToArray();
            
            return objectives;
        }

        private string ExtractQuestName(HtmlNode quest)
        {
            var thNodes = quest.ChildNodes.Where(x => x.Name == "th");
            var questTag = thNodes.First();
            var questName = questTag.ChildNodes.First().InnerHtml;

            return questName;
        }

        private void LoadMerchants()
        {
            _merchants = CustomObjectStore.Merchants;
        }

        private void LoadHtml()
        {
            _document = _pageHtmlProvider.Load();
        }
    }
}
