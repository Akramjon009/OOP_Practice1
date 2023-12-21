namespace Leetcode_232
{
internal class Leetcode
{

        private Stack<int>  stack;
        private Stack<int> stack2 = new Stack<int>();
        public Leetcode()
        {
            stack = new Stack<int>(); 
        }

        public void Push(int x)
        {
            while (stack.Count > 0) stack2.Push(stack.Pop());
            stack.Push(x);
            while (stack2.Count > 0) stack.Push(stack2.Pop());
        }

        public int Pop()
        {
            return stack.Pop();
        }

        public int Peek()
        {
            return stack.Peek();
        }

        public bool Empty()
        {
            return stack.Count == 0;
        }
    }

}

