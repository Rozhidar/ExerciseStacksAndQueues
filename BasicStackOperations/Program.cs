int[] inputData = Console.ReadLine().Split().Select(int.Parse).ToArray();
int elementsToPush = inputData[0];
int elementToPop = inputData[1];
int elementToLookFor = inputData[2];

var stack = new Stack<int>();

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < elementsToPush; i++)
{
    stack.Push(numbers[i]);
}

for (int i = 0; i < elementToPop; i++)
{
    stack.Pop();
}

if (!stack.Any())
{
    Console.WriteLine(0);
}
else if (stack.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine(stack.Min());
}