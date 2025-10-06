string input = Console.ReadLine();
char[] collection = input.ToCharArray();

var stack = new Stack<char>(collection);
stack.Pop();
var queue = new Queue<char>(collection);
queue.Dequeue();
Console.WriteLine();