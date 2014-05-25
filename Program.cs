using System;
using Kevin.Core;

namespace Kevin.Console
{
	class MainClass : Output
	{
		static KevinCore core;

		public static void Main (string[] args)
		{
			MainClass instance = new MainClass ();
			core = new KevinCore (instance);

			if (args.Length == 0) { 
				instance.send ("Hello.");
				instance.Loop ();
			}

			core.tell(string.Join(" ", args));
		}

		public void Loop ()
		{
			while (true) {
				System.Console.Write ("You: ");
				string input = System.Console.ReadLine ();
				core.tell (input);
			}

		}

		#region Output implementation

		public void send (string hey)
		{	
			System.Console.WriteLine ("Kevin: " + hey);
		}

		#endregion
	}
}
