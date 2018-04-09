using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int numberOfQueries = Convert.ToInt32(Console.ReadLine().Trim());
		List<int[]> queries = new List<int[]>();

		for (int i = 0; i < numberOfQueries; i++)
		{
			int[] x = Console.ReadLine().Split(' ').Cast<int>().ToArray();
			queries.Add(x);
		}
	}
}
