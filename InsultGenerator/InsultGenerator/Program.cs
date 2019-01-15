using System;
using System.Threading;

namespace InsultGenerator
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var random = new Random();

			InsultFour.Print(random);

			Console.ReadLine();
		}
	}
}