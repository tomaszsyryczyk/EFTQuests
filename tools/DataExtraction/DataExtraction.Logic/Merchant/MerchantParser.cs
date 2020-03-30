using System.Collections.Generic;
using DataExtraction.Logic.MerchantQuests;
using DataExtraction.Logic.PageHtmlProvider;
using HtmlAgilityPack;

namespace DataExtraction.Logic.Merchant
{
    public class MerchantParser : IMerchantParser
    {
        private MerchantDto _currentMerchant;
        private List<MerchantDto> _result;
        private HtmlDocument _document;
        private HtmlNodeCollection _images;
        private readonly IMerchantQuestsParser _merchantQuestsParser;
        private readonly IPageHtmlProvider _pageHtmlProvider;
        private const string XPathToMerchants = "//div[contains(@class, 'dealer-toggle')]";

        public MerchantParser(IPageHtmlProvider pageHtmlProvider
            ,IMerchantQuestsParser merchantQuestsParser)
        {
            _pageHtmlProvider = pageHtmlProvider;
            _merchantQuestsParser = merchantQuestsParser;
        }

        public MerchantDto[] Parse()
        {
            _result = new List<MerchantDto>();

            LoadHtml();

            GetImages();

            ProcessImages();

            return _result.ToArray();
        }

        private void LoadHtml()
        {
            _document = _pageHtmlProvider.Load();
        }

        private void ProcessImages()
        {
            foreach (var image in _images)
            {
                ParseMerchant(image.FirstChild);
                AddMerchantToResult();
            }
        }

        private void GetImages()
        {
            _images = _document.DocumentNode.SelectNodes(XPathToMerchants);
        }

        private void AddMerchantToResult()
        {
            _result.Add(_currentMerchant);
        }

        private void ParseMerchant(HtmlNode image)
        {
            var merchantImageSrc = image.Attributes["src"];
            var merchantName = image.Attributes["alt"];

            _currentMerchant = new MerchantDto(merchantName.Value, merchantImageSrc.Value);
        }
    }
}
