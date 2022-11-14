using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManagerComandsLib.Comands
{
    internal class ComandList : IComands
    {
        public string ComandInfo()
        {
            return "Добавить описание";
        }
        private Dictionary<string, string> _comands = new Dictionary<string, string>()
        {
            {"List", "List"},
            {"list", "List"},
            {"LS", "List"},
            {"ls", "List"}
        };
        public Dictionary<string, string> ComandName()
        {
            return _comands;
        }

        public string Execute(string[] args)
        {
           

                return "";
                //Добавить логику
        }
    }
}
