using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_Override
{
    public class Animal
    {
        protected int Weight;
        protected int Height;

        public Animal()
        {
            Weight = 0;
            Height = 0;
        }
        public Animal(int weight, int height)
        {
            Weight = weight;
            Height = height;
        }
        public  virtual void Eat()
        {
            Console.WriteLine("Eat something");
        }
        public void Sound()
        {
            Console.WriteLine("Sounding.........");
        }

    }
}
