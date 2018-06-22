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
                //var formattedLine = "&lt;/br&gt; &lt;strong&gt; " + description.Name + " &lt;/strong&gt; | Type - System." + description.Type;
                var formatBool =
                    @"dbProps_EntityProps_Bool.Add(""{0}"", ""{1}"");";
                var formatString=
                    @"dbProps_EntityProps_String.Add(""{0}"", ""{1}"");";

                bool isBoolFormat = description.Type == "Boolean";
                string neededFormat = isBoolFormat ? formatBool : formatString;

                var formattedLine = string.Format(neededFormat, description.NameDB, description.Name);

                formattedText.Add(formattedLine);
            }

            return formattedText;
        }
    }
}
