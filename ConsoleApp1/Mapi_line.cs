using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mapi_line
    {   //Concerne Json qui sert à stocker des lignes.
        //classe pour decrire la variable qui servira à stocker les données de la deserialization. 
        public string id { get; set; }
        public string gtfsId { get; set; }
        public string shortName { get; set; }
        public string longName { get; set; }
        public string color { get; set; }
        public string textColor { get; set; }
        public string mode { get; set; }
        public string type { get; set; }
    }
}
