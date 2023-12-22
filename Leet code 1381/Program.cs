using Leet_code_1381;

int size = int.Parse(Console.ReadLine());
Leetcode stk = new Leetcode(size);

stk.Push(1);
stk.Push(2);
stk.Pop();
stk.Push(2);
stk.Push(3);
stk.Push(4);

stk.Increment(5, 100);
stk.Increment(2, 100);
stk.Pop();
stk.Pop();
stk.Pop();
stk.Pop();