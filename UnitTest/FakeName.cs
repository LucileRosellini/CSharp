using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class FakeName : IName

    {
        public string GetName()
        {
            return "toto";
        }
    }
}
