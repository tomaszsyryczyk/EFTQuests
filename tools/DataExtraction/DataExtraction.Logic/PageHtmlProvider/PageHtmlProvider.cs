using System.Net;
using HtmlAgilityPack;

namespace DataExtraction.Logic.PageHtmlProvider
{
    public class PageHtmlProvider : IPageHtmlProvider
    {
        private HtmlDocument _htmlDocument;

        private const string StartingUrl = @"https://escapefromtarkov.gamepedia.com/Quests";

        public HtmlDocument Load()
        {

            if (_htmlDocument == null)
            {
                LoadDocument();
            }

            return _htmlDocument;
        }

        private void LoadDocument()
        {
            _htmlDocument = new HtmlDocument();

            var client = new WebClient();
            var result = client.DownloadString(StartingUrl);

            _htmlDocument.LoadHtml(result);
        }
    }
}
