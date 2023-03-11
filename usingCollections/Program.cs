using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part a - Queue<T> collection
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            queue.Enqueue(40);
            queue.Enqueue(50);

            if (queue.Contains(30))
            {
                Console.WriteLine("Queue contains 30.");
            }

            queue.Dequeue();
            Console.WriteLine($"Items in queue: {queue.Count}");
            Console.WriteLine("Items in queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            // Part b - PriorityQueue<T> collection
            PriorityQueue<int> priorityQueue = new PriorityQueue<int>();
            priorityQueue.Enqueue(20, 2);
            priorityQueue.Enqueue(50, 5);
            priorityQueue.Enqueue(10, 1);
            priorityQueue.Enqueue(30, 3);
            priorityQueue.Enqueue(40, 4);

            while (priorityQueue.Count > 0)
            {
                int item = priorityQueue.Dequeue();
                Console.WriteLine($"Dequeued item with priority {item}");
            }

            // Part c - Stack<T> collection
            Stack<string> stack = new Stack<string>();
            stack.Push("apple");
            stack.Push("banana");
            stack.Push("cherry");
            stack.Push("date");
            stack.Push("elderberry");

            if (stack.Contains("cherry"))
            {
                Console.WriteLine("Stack contains cherry.");
            }

            stack.Pop();
            Console.WriteLine($"Items in stack: {stack.Count}");
            Console.WriteLine("Items in stack:");
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }

    // Custom PriorityQueue class to support priority queue functionality
    public class PriorityQueue<T>
    {
        private List<KeyValuePair<T, int>> list;

        public PriorityQueue()
        {
            list = new List<KeyValuePair<T, int>>();
        }

        public void Enqueue(T item, int priority)
        {
            list.Add(new KeyValuePair<T, int>(item, priority));
        }

        public T Dequeue()
        {
            KeyValuePair<T, int> max = list.First();
            foreach (KeyValuePair<T, int> item in list)
            {
                if (item.Value > max.Value)
                {
                    max = item;
                }
            }
            list.Remove(max);
            return max.Key;
        }

        public int Count
        {
            get { return list.Count; }
        }
    }
}
