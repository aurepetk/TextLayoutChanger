using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextLayoutChanger
{
    public sealed class ConfigurationStore
    {
        public string SelectedDocument { get; }

        private static volatile ConfigurationStore _instance;
        private static readonly object syncRoot = new object();

        private ConfigurationStore()
        {
            SelectedDocument = ConfigurationManager.AppSettings["DocumentPath"];
        }

        public static ConfigurationStore Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (syncRoot)
                    {
                        if (_instance == null)
                            _instance = new ConfigurationStore();
                    }
                }

                return _instance;
            }
        }
    }
}
