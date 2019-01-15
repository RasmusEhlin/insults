using System;

namespace InsultGenerator
{
	public static class InsultFive
	{
		private static WordList[] wordLists;

		public static string GetRandomInsult(Random random)
		{
			if (wordLists == null)
			{
				wordLists = new WordList[]
				{
					new WordList("words1.txt"),
					new WordList("words2.txt"),
					new WordList("words3.txt")
				};
			}
			
			return $"{wordLists[0].GetRandom(random)} {wordLists[1].GetRandom(random)} {wordLists[2].GetRandom(random)}";
		}
	}
}
