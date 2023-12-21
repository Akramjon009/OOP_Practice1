namespace Leetcod_225
{
    internal class Leetcode
    {
        public Queue<int> queue;
        public Leetcode() 
        { 
            queue = new Queue<int>();
        }
        public void Push(int x)
        {
            queue.Enqueue(x);
        }

        public int Pop()
        {
           for (int i = 0; i < queue.Count-1; ++i)
           {
                int num = queue.Dequeue();
                queue.Enqueue(num);
           }
           return queue.Dequeue();
        }

        public int Top()
        {
            return queue.Last();
        }

        public bool Empty()
        {
            return queue.Count == 0;
        }
    }
}
