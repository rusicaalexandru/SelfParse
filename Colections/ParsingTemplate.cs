using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace SelfParse.Colections
{
    class ParsingTemplate
    {
        private string url;

        HtmlAgilityPack.HtmlDocument htmlDocument = new HtmlAgilityPack.HtmlDocument();

        public ParsingTemplate(string Url)
        {
            url = Url;

            HttpClient httpClient = new HttpClient();
            Task<string> html = httpClient.GetStringAsync(url);
            htmlDocument.LoadHtml(html.Result);
        }
        //----------------------------------------------------------------------------------------
        public List<HtmlAgilityPack.HtmlNode> findListByID(string tag, string ID)
        {
            //mai list
            return htmlDocument.DocumentNode.Descendants(tag)
                .Where(node => node.GetAttributeValue("id", "")
                .Equals(ID)).ToList();

            /*//item
            var AnimeListItems = animeHtml[0].Descendants("div")
                .Where(node => node.GetAttributeValue("class", "")
                .Equals("shortstory")).ToList();*/
        }
        //----------------------------------------------------------------------------------------

    }
}
