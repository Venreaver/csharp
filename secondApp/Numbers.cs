using System;

namespace secondApp
{
	class Numbers
	{
		static void Main(string[] args)
		{
			int[] ar = { 2, 8, 15, -20, 37, 16, 6, 0, 1, 77, 18, 15, 4, 13, -8, -9, 11, 45, -18, 17 };
			int x = 17;
			Array.Sort(ar);
			int i = 0, j = ar.Length - 1;
			while (i < j)
			{
				int sum = ar[i] + ar[j];
				if (sum < x)
				{
					++i;
				}
				else
				{
					if (sum == x)
					{
						Console.WriteLine(ar[i] + " + " + ar[j] + " = " + x);
						++i;
					}
					--j;
				}

			}
			Console.ReadKey();
		}
	}
}
