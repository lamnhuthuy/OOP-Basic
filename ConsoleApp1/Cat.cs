using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Khong the implement nhieu lop abstract
    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Constructor Cat");
        }

        public override void Soud()
        {
            Console.WriteLine("Meo Meo");
        }
        public override void Eat()
        {

            Console.WriteLine("Eating fish");
        }
        public new void Go()
        {
            Console.WriteLine("Cat- go");
        }
    }
}
