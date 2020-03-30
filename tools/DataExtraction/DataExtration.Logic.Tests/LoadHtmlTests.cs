using System.Linq;
using DataExtraction.Logic.Merchant;
using DataExtraction.Logic.PageHtmlProvider;
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
            var loader = new PageHtmlProvider();
            var objectUnderTest = new MerchantParser(loader);

            //Act
            var merchants = objectUnderTest.Parse();

            //Assert
            Assert.Equal(MerchantsNumber, merchants.Count());
        }

        [Fact]
        public void SimpleLoad()
        {
            




        }

        

       
    }
}
