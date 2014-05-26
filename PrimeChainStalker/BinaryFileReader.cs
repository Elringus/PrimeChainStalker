using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrimeChainStalker
{
	public static class BinaryFileReader
	{
		public static bool CheckForPath (string path)
		{
			return File.Exists(path);
		}

		public static ulong[] GetData (string path)
		{
			using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
			{
				int index = 0;

				long length = reader.BaseStream.Length;
				if (length % 6 != 0) length = length - (length % 6);

				ulong[] data = new ulong[length / 6 + 1];

				while (index <= length) 
				{
					byte[] buffer = new byte[6];
					reader.Read(buffer, 0, 6);
					data[index / 6] += ConvertToUlong(buffer);

					index += 6;
				}

				Console.WriteLine("\nSource file at " + path + " has been loaded.");

				return data;
			}
		}

		// converts 48-bit source data to 64-bit ulong type
		private static ulong ConvertToUlong (byte[] buffer)
		{
			ulong number = 0;
			for (int i = 0; i < 6; i++) 
				number = (number << 8) + buffer[i];
			return number;
		}

	}
}
