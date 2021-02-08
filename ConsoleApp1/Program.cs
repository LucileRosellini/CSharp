using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 5.7282324;
            double y = 45.185374;
            int dist = 500;

            LignesEtArrets monObjet = new LignesEtArrets(x, y, dist);

            Console.WriteLine(monObjet.Calcule);

            Console.ReadLine();
        
        }
    }
}
