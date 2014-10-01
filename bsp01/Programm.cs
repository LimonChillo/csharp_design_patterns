
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bsp01
{
    class Program
    {
        static void Main(string[] args)
        {

			Manager m = new Manager ();


			m.addDuck(new RedheadDuck(new quacken()));
			m.addDuck(new MallardDuck(new quietschen()));
		

			m.printAllDucks ();
            Console.ReadLine();
        }
    }
}