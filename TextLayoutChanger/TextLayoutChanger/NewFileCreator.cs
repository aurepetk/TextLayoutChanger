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
            string path = @"C:\Users\AlmantasK\Documents\formattedText.txt";
            File.WriteAllLines(path, formattedText);
        }
    }
}
