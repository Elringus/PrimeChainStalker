using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChainStalker
{
	public class PrimeChain
	{
		public ulong? FirstElement;
		public ulong? FirstElementDisplacement;

		public ulong? LastElement;
		public ulong? LastElementDisplacement;

		public ulong? ChainLength;

		public PrimeChain (ulong firstElement, ulong firstElementDisplacement)
		{
			this.FirstElement = this.LastElement = firstElement;
			this.FirstElementDisplacement = this.LastElementDisplacement = firstElementDisplacement;
			this.ChainLength = 1;
		}
	}
}
