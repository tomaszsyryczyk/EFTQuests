using System;
using System.Diagnostics;
using System.Linq;
using DataExtraction.Logic;
using DataExtraction.Logic.Merchant;
using HtmlAgilityPack;
using Xunit;

namespace DataExtration.Logic.Tests
{
    public class LoadHtmlTests
    {
        private const int MerchantsNumber = 8;

        [Fact]
        public void LoadMerchants()
        {

            //Arrange
            var url = @"https://escapefromtarkov.gamepedia.com/Quests";
            var loader = new PageHtmlProviderProvider();
            var htmlDocument = loader.Load(url);
            var objectUnderTest = new MerchantParser();

            //Act
            var merchants = objectUnderTest.Parse(htmlDocument);

            //Assert
            Assert.Equal(MerchantsNumber, merchants.Count());
        }

        [Fact]
        public void SimpleLoad()
        {
            //Arrange
            var url = @"https://escapefromtarkov.gamepedia.com/Quests";
            var loader = new PageHtmlProviderProvider();
            var htmlDocument = loader.Load(url);

            var merchantParser = new MerchantParser();
            var merchants = merchantParser.Parse(htmlDocument);

            foreach (var merchant in merchants)
            {
                var name = merchant.Name;
                var table = FindTable(htmlDocument, name);
            }

        }

        private HtmlNode FindTable(HtmlDocument htmlDocument, string name)
        {
            var xpath = $"//table[contains(@class, '{name}-content')]//tr";
            var rows = htmlDocument.DocumentNode.SelectNodes(xpath);
            
            var quests = rows.Skip(2).ToList();
            foreach (var quest in quests)
            {
                ParseQuest(quest);
            }
            return rows.First();
        }

        private void ParseQuest(HtmlNode quest)
        {
            var thNodes = quest.ChildNodes.Where(x => x.Name == "th");
            var questTag = thNodes.First();
            var questName = questTag.ChildNodes.First().InnerHtml;

            var trNodes = quest.ChildNodes.Where(x => x.Name == "td");
            var objectives = trNodes.First();
        }
    }
}
