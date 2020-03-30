using System;
using System.Collections.Generic;
using System.Text;
using HtmlAgilityPack;

namespace DataExtraction.Logic.PageHtmlProvider
{
    public interface IPageHtmlProvider
    {
        HtmlDocument Load();
    }
}
