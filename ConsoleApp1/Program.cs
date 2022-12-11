using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            SomeDuck duck = new SomeDuck();
            duck.Fly();
            duck.Swim();
            duck.Quacke();
            duck.Die();
            Console.ReadLine();
        }
    }
}