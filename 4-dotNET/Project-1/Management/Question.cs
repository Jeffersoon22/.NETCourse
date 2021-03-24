using System;
using System.Collections.Generic;
using System.Text;

namespace Management
{
    [Serializable]
	public class Question
	{
		public string Que { get; set; }
		public string Correct { get; set; }
		public string Wrong1 { get; set; }
		public string Wrong2 { get; set; }
		public string Wrong3 { get; set; }
		public int Cost { get; set; }
		public Question(string quetsion, string correct, string wrong1, 
						string wrong2, string wrong3, int cost)
		{
			Que = quetsion;
			Correct = correct;
			Wrong1 = wrong1;
			Wrong2 = wrong2;
			Wrong3 = wrong3;
			Cost= cost;
		}
		public Question()
		{

		}
	}
}
