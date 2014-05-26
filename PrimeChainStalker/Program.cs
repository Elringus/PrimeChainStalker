using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PrimeChainStalker
{
	public class Program
	{
		private static string binFilePath;
		private static Stopwatch timer;

		private static void Main (string[] args)
		{
			Console.WriteLine("Program started. Prime chains stalker ready for action!");
			ConsoleKeyInfo cki;

			if (args.Length == 0 || !BinaryFileReader.CheckForPath(args[0]))
			{
				Console.WriteLine("\nCan't fint the source file. Do you want to auto-generate a random one in the current directory? y/n");
				cki = Console.ReadKey(true);
				if (cki.Key == ConsoleKey.Y)
				{
					binFilePath = System.Environment.CurrentDirectory + @"\_file.bin";
					BinaryFileGenerator.WriteBinary(binFilePath);
				}
				else Environment.Exit(0);
			}
			else binFilePath = args[0];

			timer = new Stopwatch();
			timer.Start();

			Task.Run(() => ChainsStalker.BeginTheHunt(BinaryFileReader.GetData(binFilePath)));
			cki = Console.ReadKey(true);
			if (cki.Key == ConsoleKey.Q)
			{
				ChainsStalker.IsBreaked = true;
				ChainsStalker.FindTheChain();
			}
		}

		// called by ChainStalker when the work is done 
		public static void RecieveTheChain (PrimeChain theChain)
		{
			if (ChainsStalker.IsBreaked) Console.WriteLine("\n\nYou stopped the Stalker from completing it's hunt. Here is what he was able to find:");

			if (theChain != null)
			{
				Console.WriteLine("\n\nChains stalker has found his victim!");
				Console.WriteLine("Max chain length is: " + theChain.ChainLength);
				Console.WriteLine("First element is: " + theChain.FirstElement);
				Console.WriteLine("First element displacement is: " + theChain.FirstElementDisplacement);
				Console.WriteLine("Last element is: " + theChain.LastElement);
				Console.WriteLine("Last element displacement is: " + theChain.LastElementDisplacement);

				Console.WriteLine(string.Format("\nSketch of the victim:\n...{0}-[{1}]...<{2}>...{3}-[{4}]...",
					theChain.FirstElementDisplacement,
					theChain.FirstElement,
					theChain.ChainLength,
					theChain.LastElementDisplacement,
					theChain.LastElement));
			}
			else Console.WriteLine("\nChain stalker couldn't find any primes at all :(");

			timer.Stop();
			Console.WriteLine("\nElapsed time, ms: " + timer.ElapsedMilliseconds);
			Console.ReadLine();
		}

	}
}
