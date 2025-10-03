int[] inputData = Console.ReadLine().Split().Select(int.Parse).ToArray();
int elementsToEnqueue = inputData[0];
int elementsToDequeue = inputData[1];
int elementToLookFor = inputData[2];

int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

var queue = new Queue<int>();

for (int i = 0; i < elementsToEnqueue; i++)
{
    queue.Enqueue(numbers[i]);
}

for (int i = 0; i < elementsToDequeue; i++)
{
    queue.Dequeue();
}

if (queue.Contains(elementToLookFor))
{
    Console.WriteLine("true");
}
else if (!queue.Any())
{
    Console.WriteLine(0); ;
}
else
{
    Console.WriteLine(queue.Min());
}