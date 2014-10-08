using System;

namespace bsp02
{
	 class StudentAccount: Account
	{
		public StudentAccount (string name):base(name)
		{

		}

		public override void withDraw (double d)
		{
			if (money - d > 0)
				base.withDraw (d);
			else
				throw new InvalidOperationException ("You have to less Money!");
		} 
	}
}

