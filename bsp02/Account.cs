using System;
using System.Collections.Generic;


namespace bsp02
{
	class Account
	{

		private string name;
		private double money = 0;

		public Account (string name)
		{
			this.name = name;
		}
			
		public void deposit(double d)
		{
			money += d;
		}

		public void withDraw(double d)
		{
			money -= d;
		}
		public double getBalance()
		{
			return money;
		}
		public string getName()
		{
			return name;
		}


	}
}

