using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    class FakeDateWeekEnd: IDate
    {
        public DateTime GetTime()
        {
            return new DateTime(2021, 2, 6, 17, 45, 10);
        }
    }
}
