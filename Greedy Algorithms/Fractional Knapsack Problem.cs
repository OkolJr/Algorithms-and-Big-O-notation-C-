using System;
using System.Collections;

class GFG {

	// Class for an item which stores weight and
	// corresponding value of Item
	class item {
		public int profit;
		public int weight;

		public item(int profit, int weight)
		{
			this.profit = profit;
			this.weight = weight;
		}
	}

	// Comparison function to sort Item according
	// to val/weight ratio
	class cprCompare : IComparer {
		public int Compare(Object x, Object y)
		{
			item item1 = (item)x;
			item item2 = (item)y;
			double cpr1 = (double)item1.profit
						/ (double)item1.weight;
			double cpr2 = (double)item2.profit
						/ (double)item2.weight;

			if (cpr1 < cpr2)
				return 1;

			return cpr1 > cpr2 ? -1 : 0;
		}
	}

	// Main greedy function to solve problem
	static double FracKnapSack(item[] items, int w)
	{

		// Sort items based on cost per units
		cprCompare cmp = new cprCompare();
		Array.Sort(items, cmp);

		// Traverse items, if it can fit,
		// take it all, else take fraction
		double totalVal = 0f;
		int currW = 0;

		foreach(item i in items)
		{
			float remaining = w - currW;

			// If the whole item can be
			// taken, take it
			if (i.weight <= remaining) {
				totalVal += (double)i.profit;
				currW += i.weight;
			}

			// dd fraction until we run out of space
			else {
				if (remaining == 0)
					break;

				double fraction
					= remaining / (double)i.weight;
				totalVal += fraction * (double)i.profit;
				currW += (int)(fraction * (double)i.weight);
			}
		}
		return totalVal;
	}

	// Driver code
	static void Main(string[] args)
	{
		int W = 50;
		item[] arr = { new item(60, 10), new item(100, 20),
					new item(120, 30) };

		// Function call
		Console.WriteLine(FracKnapSack(arr, W));
	}
}