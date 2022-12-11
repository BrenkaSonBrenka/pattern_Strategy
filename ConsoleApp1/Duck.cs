using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Duck
    {
        public string name;
        public IFly fly;
        public ISwim swim;
        public IQuacke quacke;
        public IDie die;
        public Duck(IFly fly, ISwim swim, IQuacke quacke, IDie die, string name)
        {
            this.fly = fly;
            this.swim = swim;
            this.name = name;
            this.quacke = quacke;
            this.die = die;
        }
        public void Fly()
        {
            fly.Fly();
        }
        public void Swim()
        {
            swim.Swim();
        }
        public void Quacke()
        {
            quacke.Quacke();
        }
        public void Die()
        {
            die.Die();
        }
    }
}