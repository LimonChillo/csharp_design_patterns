/*
	David Kranewitter
	Simon Hintersonnleinter
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b_Iterator
{
	abstract class Duck
    {

		Quack actualQuack;

		public Duck(Quack q)
		{
			actualQuack = q;
		}
      
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
		public MallardDuck(Quack q):base(q)
		{

		}


        public override void display()
        {
            Console.Out.WriteLine("Mallard");
        }
    }

    class RedheadDuck : Duck
    {

		public RedheadDuck(Quack q):base(q)
		{

		}

        public override void display()
        {
            Console.Out.WriteLine("RedheadDuck");
        }
    }
}