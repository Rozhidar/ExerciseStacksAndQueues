int[] deliveredClothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
int rackCapacity = int.Parse(Console.ReadLine());

var rack = new Stack<int>(deliveredClothes);

int currentSumOfClothes = 0;
int racksCount = 1;

while (rack.Count > 0)
{
    currentSumOfClothes += rack.Peek();

    if (currentSumOfClothes <= rackCapacity)
    {
        rack.Pop();
    }
    else
    {
        currentSumOfClothes = 0;
        racksCount++;
    }
}

Console.WriteLine(racksCount);