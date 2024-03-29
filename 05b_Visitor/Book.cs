﻿// David Kranewitter
// Simon Hintersonnleitner
//
using System;

namespace b_Visitor
{
	public class Book:Item
	{

		string isbn;
		public Book (string name, double price, string isbn):base(name,price)
		{
			this.isbn = isbn;
		}

		public override void print (int level)
		{
			base.print (level);
			Console.WriteLine("<book name="+ name+ " price="+price+" isbn="+isbn+" />");
		}

		public string getIsbn()
		{
			return isbn;
		}
	}
}

