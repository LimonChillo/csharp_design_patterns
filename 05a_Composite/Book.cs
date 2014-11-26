// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace a_Composite
{
	public class Book:Item
	{

		string isbn;
		public Book (string name, float price, string isbn):base(name,price)
		{
			this.isbn = isbn;
		}
	}
}

