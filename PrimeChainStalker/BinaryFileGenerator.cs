using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimeChainStalker
{
	public static class BinaryFileGenerator
	{
		public static void WriteBinary (string path)
		{
			Console.WriteLine("\nGenerating random binary file...");

			using (FileStream stream = new FileStream(path, FileMode.Create))
			{
				Random random = new Random();
				for (int i = 0; i < 1000; i++)
				{
					byte[] randomBytes = new byte[6];
					random.NextBytes(randomBytes);
					stream.Write(randomBytes, 0, 6);
				}

				// 1st assignment test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 011 }, 0, 6);

				// 2nd assignment test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 004 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 006 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);

				// 3rd assignment test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 010 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 006 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);

				// 4th assignment test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 006 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);

				// 5th assignment test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 011 }, 0, 6);

				// 6th assignment test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 011 }, 0, 6);

				// two chains with equal lengths test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 011 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 013 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 017 }, 0, 6);

				// twp chains with equal lengths and first elements test
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 002 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 005 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 007 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 011 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 013 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 017 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 003 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 011 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 013 }, 0, 6);
				//stream.Write(new byte[6] { 0, 0, 0, 0, 0, 019 }, 0, 6);
			}

			Console.WriteLine("Binary file successfully created at: " + path);
		}
	}
}
