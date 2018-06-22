using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLayoutChanger
{
    class PropertyDescription
    {
        public string Name { get; set; }
        public string NameDB { get; set; }
        public string Type { get; set; }

        public PropertyDescription(string name, string nameDB, string type)
        {
            Name = name;
            NameDB = nameDB.Replace("\r\n", "");
            Type = type.Replace("\r\n", "");
        }
    }
}
