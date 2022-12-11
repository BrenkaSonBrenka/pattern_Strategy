using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SomeDuck : Duck
    {
        public SomeDuck()
            : base(new Flying(), new Swimming(), new Quacks(), new Dying(), "Некая утка")
        {

        }
    }
}
