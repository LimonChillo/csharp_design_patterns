
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
            m.setQuack(new quack1());
            m.quack();
            m.setQuack(new quack2());
            m.quack();
            m.swim();
            m.display();
            Console.ReadLine();
        }
    }
}