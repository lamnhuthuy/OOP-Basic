using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public abstract class Animal
    {
        protected Animal()
        {
            Console.WriteLine("Constructor Animal");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Eat something");
        }
        public abstract void Soud();
        
        public void Go()
        {
            Console.WriteLine("Animal-go");
        }
    }
}
/*
 * Abstract class co the chua cac method co noi dung va cac method khong noi dung
 * Cac mothod duoc khai bao la abstract phai duoc lop ke thua implement
 * Pham vi truy cap co the la pulbic, protected
 */