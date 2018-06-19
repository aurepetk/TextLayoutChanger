using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace TextLayoutChanger
{
    class InfoParser
    {
        public HtmlDocument OpenHtmlDocument(string path)
        {
            var htmlDoc = new HtmlDocument();
            htmlDoc.Load(path);
            return htmlDoc;
        }

        public HtmlNodeCollection GetAllRowsFromHtmlDoc(HtmlDocument htmlDoc)
        {
            var tables = htmlDoc.DocumentNode
                .SelectNodes("//body/table");
            var rows = tables[1]
                .SelectNodes("./tr");
            return rows;
        }

        public List<HtmlNode> GetNeededRows(HtmlNodeCollection allrows)
        {
            var neededRows = new List<HtmlNode>();

            foreach (var row in allrows)
            {
                var firstColumnOfRow = row.SelectNodes("./td[1]/font/b");
                var firstColumnOfInfoRows = row.SelectNodes("./td/i");
                if (firstColumnOfRow == null && firstColumnOfInfoRows == null)
                {
                    neededRows.Add(row);
                }
            }

            return neededRows;
        }

        public List<PropertyDescription> ParseInfoFromRows(List<HtmlNode> neededRows)
        {
            var propertiesDescriptions = new List<PropertyDescription>();

            foreach (var row in neededRows)
            {
                var nameNode = row.SelectSingleNode("./td[1]/a");
                var name = nameNode.InnerText;
                var typeNode = row.SelectSingleNode("./td[3]");
                var type = typeNode.InnerText;
                PropertyDescription propertyDescription = new PropertyDescription(name, type);
                propertiesDescriptions.Add(propertyDescription);
            }

            return propertiesDescriptions;
        }
    }
}
