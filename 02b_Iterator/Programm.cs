
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

			Manager m = Manager.getInstance ();


			m.addDuck(new RedheadDuck(new quacken()));
			m.addDuck(new MallardDuck(new quietschen()));
		

			m.printAllDucks ();
            Console.ReadLine();
        }
    }
}