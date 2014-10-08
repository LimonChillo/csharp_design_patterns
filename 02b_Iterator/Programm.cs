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
    class Program
    {
        static void Main(string[] args)
        {

			Manager m = Manager.getInstance ();


			m.addDuck(new RedheadDuck(new quacken()));
			m.addDuck(new MallardDuck(new quietschen()));

			DuckIterator myDuckIterator = m.createIterator ();

			myDuckIterator.first();

			while (!myDuckIterator.isDone ()) 
			{
				myDuckIterator.currentItem ().display();
				myDuckIterator.currentItem().quack();
				myDuckIterator.next();
			}

            Console.ReadLine();
        }
    }
}