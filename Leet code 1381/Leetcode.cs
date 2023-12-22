namespace Leet_code_1381
{
    public class Leetcode
    {
        private int _maxSize;

        private List<int> list = new List<int>();

        public Leetcode(int maxSize)
        {
            _maxSize = maxSize;
        }

        public void Push(int x)
        {
            if (list.Count + 1 > _maxSize)
            {
                return;
            }
            list.Add(x);
        }

        public int Pop()
        {
            bool isEmpty = !list.Any();
            if (isEmpty)
            {
                return -1;
            }
            var last = list.Last();
            list.RemoveAt(list.Count - 1);
            return last;


        }

        public void Increment(int k, int val)
        {
            var i = 0;
            foreach (int listData in list.ToArray())
            {
                if (i < k)
                {
                    list[i] = listData + val;
                }
                i++;
            }
        }
    }
}
