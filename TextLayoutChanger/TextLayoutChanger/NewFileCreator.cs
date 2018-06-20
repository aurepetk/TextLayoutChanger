using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLayoutChanger
{
    class NewFileCreator
    {
        public void PutFormattedTextInNewFile(List<string> formattedText)
        {
            var documentPath = ConfigurationStore.Instance.SelectedDocument;
            string[] partsOfDocPath = documentPath.Split('.');
            var document = partsOfDocPath[partsOfDocPath.Length - 2];

            string path = @"C:\Users\AlmantasK\Documents\ForTextLayoutChanger\" + document + ".txt";

            if (File.Exists(path))
            {
                File.Delete(path);
            }

            var theFile = File.Create(path);
            theFile.Close();
            
            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (String line in formattedText)
                    tw.WriteLine(line);
            }
        }
    }
}
