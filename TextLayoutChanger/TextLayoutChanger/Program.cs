using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLayoutChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            var htmlDocumentPath = "ESE.Entity.Document.html";

            var inforParser = new InfoParser();
            var textFormatter = new TextFormatter();
            var writeIntoTextFile = new NewFileCreator();
            
            var document = inforParser.OpenHtmlDocument(htmlDocumentPath);
            var allRows = inforParser.GetAllRowsFromHtmlDoc(document);
            var neededRows = inforParser.GetNeededRows(allRows);
            var propertiesDescriptions = inforParser.ParseInfoFromRows(neededRows);
            var formatedText = textFormatter.FormatText(propertiesDescriptions);
            writeIntoTextFile.PutFormattedTextInNewFile(formatedText);
        }
    }
}
