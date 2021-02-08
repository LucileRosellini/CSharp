using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Mapi
    {
        //Concerne Json qui sert a stocker les arrêts.
        //classe pour decrire la variable qui servira à stocker les données de la deserialization. 
        public string id { get; set; }
        public string name { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public string zone { get; set; }
        public List<string> lines { get; set; }
    }
}
