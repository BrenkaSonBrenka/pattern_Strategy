using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Flying : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Утка летела");
        }
    }
}
