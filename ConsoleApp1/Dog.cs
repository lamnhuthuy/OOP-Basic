using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Class co the implement nhieu interface
    internal class Dog : IAnimal,IAnimal2
    {
        public void Eat()
        {
            Console.WriteLine("Eating rice");
        }

        public void Go()
        {
            Console.WriteLine("Dog -go");
        }

        public void Soud()
        {
            Console.WriteLine("Gau Gau");
        }

       
    }
}
