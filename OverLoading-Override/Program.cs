using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Calculator calculator = new Calculator();
              var res= calculator.Sum(5, 6);
              var res1= calculator.Sum(5.5f, 6.6f);
              Console.WriteLine(res1);
              Console.ReadLine();
            */
            /*
              Tiger tiger= new Tiger();
              tiger.Eat();
              //Eating meat
              tiger.Sound();
              //Gow Gow
              Console.ReadLine();
            */
            Animal tiger = new Tiger();
            tiger.Eat();
            //Eating meat
            tiger.Sound();
            //Sounding.........
            Console.ReadLine();
        }
    }
}
//Overloading