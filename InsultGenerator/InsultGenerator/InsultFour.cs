using System;

namespace InsultGenerator
{
	public static class InsultFour
	{
		public static void Print(Random random) =>
			Console.WriteLine(InsultFive.GetRandomInsult(random));
	}
}
