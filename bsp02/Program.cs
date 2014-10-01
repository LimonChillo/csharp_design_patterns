using System;

namespace bsp02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Manager m = Manager.getInstance ();

			m.addAccount (new Account ("Herbert"));
			m.addAccount (new Account ("Anton"));
			m.addAccount (new Account ("Berta"));
			m.addAccount (new Account ("Cäser"));

			m.printAllAccounts ();

		}
	}
}
