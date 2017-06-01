using System.Collections.Generic;
using System.Threading;

namespace firstApp
{
	class AlterQueue<T>
	{
		private readonly object qLock = new object();
		private readonly Queue<T> queue = new Queue<T>();

		public void Push(T item)
		{
			lock (qLock)
			{
				queue.Enqueue(item);
				Monitor.Pulse(qLock);
			}
		}

		public T Pop()
		{
			lock (qLock)
			{
				while (queue.Count == 0)
				{
					Monitor.Wait(qLock);
				}
				return queue.Dequeue();
			}
		}
	}
}
