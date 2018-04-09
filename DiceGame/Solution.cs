using System;
using System.Linq;
using System.IO;

class Solution
{
	static void Main(String[] args)
	{
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int MOD = 1012924417;
		int numberOfQueries = Convert.ToInt32(Console.ReadLine().Trim());
		int[][] queries = new int[numberOfQueries][];

		for (int i = 0; i < numberOfQueries; i++)
		{
			queries[i] = Console.ReadLine().Split(' ').Cast<int>().ToArray();
		}

		for (int i = 0; i < queries.Length; i++)
		{
			int pDNum = queries[i][0];      // 2
			int pDSides = queries[i][1];    // 6 (d6)
			int cDNum = queries[i][2];      // 3
			int cDSides = queries[i][3];    // 4 (d4)

			int pMax = pDNum * pDSides;     // 12
			int pMin = pDNum;               // 2
			int cMax = cDNum * cDSides;     // 12
			int cMin = cDNum;               // 3

			int pAvg = (pMax + pMin) / 2;  // 7
			int cAvg = (cMax + cMin) / 2;  // 7.5

			// calc possible combos
			int peterCombinations = (int)Math.Pow(pDSides, pDNum); // 6^2 = 36
			int colinCombinations = (int)Math.Pow(cDSides, cDNum); // 4^3 = 64
			int totalCombinations = (int)Math.Pow(peterCombinations, colinCombinations) % MOD; // 36^64 = 968059107 (mod 1012924417)

			// calc winning combos
			// if Colin rolls his minimum number, how many of Peter's combos could beat that number?
			// multiplied by number of combinations Colin can roll to get that number.

			// C rolls 4 (3 possible combos (1/1/2, 1/2/1, 2/1/1))
			// P needs 5 or higher 
		}
	}
}
