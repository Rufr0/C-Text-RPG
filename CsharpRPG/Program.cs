using System;

namespace CsharpRPG
{
	class MainClass
	{
		public static void Main (string[] args)

		{
			string responce;
			string location;
			string ocupation = "idk";
			Double money = 0.00;

			System.Console.Write("Traveler, what do you call yourself?\t");
			string name = System.Console.ReadLine ();
			System.Console.Write ("[Guard]\t"+name + ", Welcome to the magical land of kelwitch, I see you have some hay are you here to traid?\t");
			if (System.Console.ReadLine () == "yes")
			{
				string ocupation = "traider";
				Double money = 150.00;
				System.Console.WriteLine ("[Guard]\tWell then, since I know so much about you, you deserver to know something about me!\n\tI'll tell you on the way to the market, how about that?");
				location = "market";
			}
			else
			{
				System.Console.WriteLine("[Guard]\tWell then, what ya doing with that hay?\n[a]\tI bought it...\n[b]\tI have hay... wow I never knew!\n[c]\tMy buisness and none of yours!");
				responce =System.Console.ReadLine().ToLower();
				if (responce=="a")
					System.Console.WriteLine("[Guard]\tHmm... very well then...");location="entrance"
				else if (responce=="b")
					System.Console.WriteLine("[Guard]\t"+"Don\'t play dumb with me now! You\'d be luck I didn\'t send you to jail for that!");location="entrance"
				else if (responce=="c")
					System.Console.WriteLine("[Guard]\tWell its our buisness as guards to inspect you, come with me, I am making it our buisness!");location="jail"
				
			}

			while (true)
			{
				if (location=="jail")
					System.Console.WriteLine("You have been thrown in jail, with no hope of freedom. Failure.");

				if (location=="market");
			}
				
			











		}
	}
}
