using System;

namespace CsharpRPG
{
	class MainClass
	{
		public static void Main (string[] args)

		{
			string location = "Project select";
			string [] projects= new string[1];

			projects [0] = "1-n";



			while (true) {
				if (location == "Project select") {
					System.Console.WriteLine ("PROJECTS:");
					foreach (string value in projects) {
						System.Console.WriteLine (value);
					}
					string responce=System.Console.ReadLine ();

					bool found = false;
					foreach (string value in projects) {
						if (value == responce)
							found = true;
					}
					if (found == false) {
						System.Console.WriteLine ("\nNot on list\n");
					}
					else
						location=responce;
				}


				if (location == "1-n") {
					System.Console.Write ("Enter a number to count from: ");
					int lowernumber = Convert.ToInt32 (System.Console.ReadLine ());
					System.Console.Write ("Enter a number to count to: ");
					int highernumber = Convert.ToInt32 (System.Console.ReadLine ());
					for (; lowernumber <= highernumber; lowernumber++) {
						System.Console.Write ("{0,6}",lowernumber);
					}
					System.Console.ReadLine ();
					location = "Project select";
				}








			}
		}
	}
}
