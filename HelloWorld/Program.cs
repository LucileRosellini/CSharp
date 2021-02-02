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
            Message message = new Message();
            Console.WriteLine(message.GetMessageByTime());
            Console.ReadLine();
        }

      
    }          
}

