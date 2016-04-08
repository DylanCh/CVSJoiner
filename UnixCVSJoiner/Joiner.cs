using System;
using System.Collections.Generic;

namespace UnixCVSJoiner
{
	public class Joiner
	{
		public Joiner ()
		{
		}

		public Joiner(List<KeyValuePair<int, string>> people, List<KeyValuePair<int, string>> purchases, short selection){
			switch (selection) {
			case 1:
				HashJoin (people, purchases);
				break;
			case 2:
				SortMergeJoin (people, purchases);
				break;
			}
		}

		private void HashJoin(List<KeyValuePair<int, string>> people, List<KeyValuePair<int, string>> purchases)
		{
			var peopleHash = new Dictionary<int,string>();
			foreach(var n in people)
				peopleHash.Add(n.Key,n.Value);

			foreach (var i in purchases)
				if (peopleHash.ContainsKey(i.Key))
				{
					string custName;
					peopleHash.TryGetValue(i.Key, out custName);
					Console.WriteLine("Name index {0}, {1}, bought some {2} ",
						i.Key, custName , i.Value);
				}
		} // end method

		private void SortMergeJoin(List<KeyValuePair<int, string>> people,List<KeyValuePair<int, string>> purchases)
		{
			// first we sort both lists
			people.Sort(Compare);
			purchases.Sort(Compare);

			// then we do an interleaved linear scan to merge the sorted lists
			int i = 0, j = 0;

			while(i<people.Count & j<purchases.Count)
			{
				if (people[i].Key < purchases[j].Key)
					i++;
				else if (people[i].Key > purchases[j].Key)
					j++;
				else   // must be a match
				{
					Console.WriteLine("Name index {0}, {1}, bought some {2} ",
						people[i].Key, people[i].Value, purchases[j].Value);
					j++;
				}
			}
		}

		public int Compare(KeyValuePair<int, string> a, KeyValuePair<int, string> b)
		{
			if (a.Key > b.Key)
				return 1;

			if (a.Key == b.Key)
				return 0;

			return -1;
		}
	}
}

