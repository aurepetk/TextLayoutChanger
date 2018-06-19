using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLayoutChanger
{
    class TextFormatter
    {
        public List<string> FormatText(List<PropertyDescription> propertiesDescriptions)
        {
            var formattedText = new List<string>();

            foreach (var description in propertiesDescriptions)
            {
                var formattedLine = "&lt;/br&gt; &lt;strong&gt; " + description.Name + " &lt;/strong&gt; | Type - System." + description.Type;
                formattedText.Add(formattedLine);
            }

            return formattedText;
        }
    }
}
