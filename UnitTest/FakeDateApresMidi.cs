using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class FakeDateApresMidi: IDate
    {
        public DateTime GetTime()
        {
            return new DateTime(2021, 2, 4, 17, 45, 10);
        }
    }
}
