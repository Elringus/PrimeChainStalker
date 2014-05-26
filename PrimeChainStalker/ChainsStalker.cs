using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChainStalker
{
	public static class ChainsStalker
	{
		private static ulong[] dataSet;
		private static bool[] isPrime;
		private static List<PrimeChain> primeChains;
		private static int progress;

		public static bool IsBreaked;

		public static void BeginTheHunt (ulong[] data)
		{
			dataSet = data;
			isPrime = new bool[data.Length];
			progress = 0;
			primeChains = new List<PrimeChain>();

			Console.WriteLine("\nStalker will now begin the hunt. Stop him with the Q key, if you dare...");

			Task[] tasks = new Task[dataSet.Length];

			for (int i = 0; i < dataSet.Length; i++)
			{
				int indexCache = i;
				tasks[indexCache] = Task.Run(() => IsPrime(dataSet[indexCache], indexCache));
			}

			Task.WaitAll(tasks);

			if (!IsBreaked) FindTheChain();
		}

		public static void FindTheChain ()
		{
			PrimeChain currentChain = null;

			for (ulong i = 0; i < (ulong)dataSet.Length; i++)
			{
				if (isPrime[i])
				{
					ulong displacement = i;
					if (currentChain == null)
					{
						currentChain = new PrimeChain(dataSet[i], displacement);
					}
					else if (dataSet[i] > currentChain.LastElement.GetValueOrDefault())
					{
						currentChain.LastElement = dataSet[i];
						currentChain.LastElementDisplacement = displacement;
						currentChain.ChainLength++;
					}
					else
					{
						primeChains.Add(currentChain);
						currentChain = new PrimeChain(dataSet[i], displacement);
					}
				}
			}

			if (currentChain != null) primeChains.Add(currentChain);

			Console.Write("\rStalking progress: 100%  ");

			if (primeChains.Count > 0)
			{
				primeChains = primeChains
					.OrderByDescending(x => x.ChainLength)
					.ThenByDescending(x => x.FirstElement)
					.ThenBy(x => x.FirstElementDisplacement) // not mandatory, but has minimum impact on performance — leaving it just for sure
					.ToList();
				Program.RecieveTheChain(primeChains[0]);
			}
			else Program.RecieveTheChain(null);
		}

		private static void IsPrime (ulong number, int index)
		{
			if (number == 1 || !IsOddOrTwo(number)) isPrime[index] = false;
			else
			{
				for (ulong i = 3; (i * i) <= number; i += 2)
					if ((number % i) == 0) isPrime[index] = false;
				isPrime[index] = true;
			}
			progress++;
			if (!IsBreaked) Console.Write("\rStalking progress: " + (progress * 100 / isPrime.Length) + "%  ");
		}

		// filters off all even numbers except 2
		private static bool IsOddOrTwo (ulong number)
		{
			if ((number & 1) == 0)
			{
				if (number == 2) return true;
				else return false;
			}
			else return true;
		}
	}
}
