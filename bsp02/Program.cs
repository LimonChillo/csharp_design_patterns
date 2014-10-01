using System;

namespace bsp02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			var Account1 = new Account ("Herbert");
			var Account2 = new Account ("Anton");

			Account1.deposit (12898.09);
			Account2.deposit (17379.09);

			Account1.withDraw (722.09);
			Account2.withDraw (797.09);

			Console.WriteLine(Account1.getBalance ());
			Console.WriteLine(Account2.getBalance ());

			Manager m = Manager.getInstance ();

			m.addAccount (Account1);
			m.addAccount (Account2);


			m.printAllAccounts ();

		}
	}
}
