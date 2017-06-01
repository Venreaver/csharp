using System;
using System.Threading;

namespace firstApp
{
	class Program
	{
		static AlterQueue<int> queue = new AlterQueue<int>();
		public static void Main(string[] args)
		{
			Thread newOne = new Thread(ToPop);
			newOne.Start();
			ToPush();
			Console.ReadKey();
		}

		static void ToPop()
		{
			Random rand = new Random(3);
			for (int i = 0; i < 15; ++i)
			{
				Console.WriteLine(queue.Pop() + " was poped");
				Thread.Sleep(rand.Next(1000));
			}
		}

		static void ToPush()
		{
			Random rand = new Random(2);
			for (int i = 0; i < 15; ++i)
			{
				queue.Push(i);
				Console.WriteLine(i + " was pushed");
				Thread.Sleep(rand.Next(1000));
			}
		}
	}
}
