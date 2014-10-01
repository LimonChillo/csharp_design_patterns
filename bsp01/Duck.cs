using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bsp01
{
    abstract class Duck
    {

        Quack actualQuack;
      
        public void setQuack(Quack actualQuack)
        {
             this.actualQuack = actualQuack;
        }

        public void quack()
        {
            actualQuack.quack();
        }

        public void swim()
        {
            Console.Out.WriteLine("swim");
        }

        public abstract void display();
    }


    class MallardDuck : Duck
    {
        public override void display()
        {
            Console.Out.WriteLine("Mallard");
        }
    }

    class RedheadDuck : Duck
    {
        public override void display()
        {
            Console.Out.WriteLine("RedheadDuck");
        }
    }
}