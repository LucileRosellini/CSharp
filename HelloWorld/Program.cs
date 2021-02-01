using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
           
        {

            {
                int caseSwitch = 1;

                switch (caseSwitch)
                {
                    case 1:

                        Console.WriteLine("Bonjour: {0}", Environment.UserName);
                       
                        break;
                    case 2:

                        Console.WriteLine("Bon Aprés-midi: {0}", Environment.UserName);
                        
                        break;

                    case 3:

                        Console.WriteLine("Bonsoir: {0}", Environment.UserName);
                      
                        break;

                    case 4:

                        Console.WriteLine("Bon Week-end: {0}", Environment.UserName);
                   
                        break;


                    default:
                        Console.WriteLine("Pas pris en charge!");
                        break;
                }
            }


            Console.ReadLine();
        }

       


    }
}
