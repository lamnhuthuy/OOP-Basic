using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoading_Override
{
    public class Tiger : Animal
    {
        public override void  Eat()
        {
            Console.WriteLine("Eating meat");
        }
        public new void Sound()
        {
            Console.WriteLine("Gow Gow");
        }
    }
}
