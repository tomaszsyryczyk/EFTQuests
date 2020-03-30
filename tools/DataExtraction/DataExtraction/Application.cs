using System;
using System.Collections.Generic;
using System.Text;
using DataExtraction.Logic;
using DataExtraction.Logic.Merchant;
using HtmlAgilityPack;

namespace DataExtraction
{
    public interface IApplication
    {
        void Start();
    }

    public class Application : IApplication
    {
        private readonly IPageHtmlProvider _pageHtmlProvider;
        private readonly IMerchantPersister _merchantPersister;
        private readonly IMerchantParser _merchantParser;

        private const string StartingUrl = @"https://escapefromtarkov.gamepedia.com/Quests";
        private HtmlDocument _root;

        public Application(IPageHtmlProvider pageHtmlProvider, IMerchantParser merchantParser, IMerchantPersister merchantPersister)
        {
            _merchantParser = merchantParser;
            _merchantPersister = merchantPersister;
            _pageHtmlProvider = pageHtmlProvider;
        }

        public void Start()
        {
            _root = _pageHtmlProvider.Load(StartingUrl);
            ParseMerchants();
        }

        private void ParseMerchants()
        {
            var merchants = _merchantParser.Parse(_root);
            _merchantPersister.Persist(merchants);
        }
    }
}
