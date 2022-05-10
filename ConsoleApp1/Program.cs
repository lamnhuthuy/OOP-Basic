using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /*   Cat cat= new Cat();
            cat.Eat();
            //Eating fish
            cat.Go();
            //Cat go
            cat.Soud();
            //Meo meo
            Console.ReadLine();*/

        /*    Animal cat = new Cat();
            cat.Eat();
            //Eating fish
            cat.Go();
            //Animal go
            cat.Soud();
            //Meo meo
            Console.ReadLine();*/

            //Animal = new Animal();
            //Loi do khong khoi tao doi tuong tu abstract class

            //IAnimal animal= new IAnimal();
            //Loi do khong khoi tao doi tuong tu interface class
            IAnimal dog = new Dog();
            dog.Eat();
            dog.Soud(); ;
            dog.Go();
            Console.ReadLine();
        }
    }
}
