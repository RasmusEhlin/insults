using System;
using System.Collections.Generic;
using System.IO;

namespace InsultGenerator
{
	public class WordList
	{
		public WordList(string fileName)
		{
			Words = new List<string>(File.ReadAllLines(fileName));
		}

		public WordList()
		{
		}
		
		public List<string> Words;

		public string Random => 
			Words[new Random().Next(Words.Count)];

		public string GetRandom(Random random) => 
			Words[random.Next(Words.Count)];
	}
}