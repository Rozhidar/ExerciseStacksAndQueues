int foodQuantity = Int32.Parse(Console.ReadLine());
int[] orderQuantity = Console.ReadLine().Split().Select(int.Parse).ToArray();

var queue = new Queue<int>(orderQuantity);

Console.WriteLine(queue.Max());

bool isFoodNotEnough = false;

foreach (var order in new Queue<int>(queue))
{
    if (order <= foodQuantity)
    {
        queue.Dequeue();
        foodQuantity -= order;
    }
    else
    {
        isFoodNotEnough = true;
        break;
    }
}

if (isFoodNotEnough)
{
    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
}
else
{
    Console.WriteLine("Orders complete");
}