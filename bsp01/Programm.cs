
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
            Duck m = new MallardDuck();
			m.setQuack(new quacken());
            m.quack();
			m.setQuack(new quietschen());
            m.quack();
            m.swim();
            m.display();
            Console.ReadLine();
        }
    }
}