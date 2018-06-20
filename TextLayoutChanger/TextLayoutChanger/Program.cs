using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLayoutChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            var documentPath = ConfigurationStore.Instance.SelectedDocument;
                
            var inforParser = new InfoParser();
            var textFormatter = new TextFormatter();
            var writeIntoTextFile = new NewFileCreator();
            
            var document = inforParser.OpenHtmlDocument(documentPath);
            var allRows = inforParser.GetAllRowsFromHtmlDoc(document);
            var neededRows = inforParser.GetNeededRows(allRows);
            var propertiesDescriptions = inforParser.ParseInfoFromRows(neededRows);
            var formatedText = textFormatter.FormatText(propertiesDescriptions);
            writeIntoTextFile.PutFormattedTextInNewFile(formatedText);
        }
    }
}
