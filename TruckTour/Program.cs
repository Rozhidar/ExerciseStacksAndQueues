int petrolPumpsCount = int.Parse(Console.ReadLine());

var sequenceOfPumps = new Queue<int[]>();

for (int i = 0; i < petrolPumpsCount; i++)
{
    int[] individualPump = Console.ReadLine().Split().Select(int.Parse).ToArray();
    sequenceOfPumps.Enqueue(individualPump);
}

int position = 0;

while (true)
{
    int fuel = 0;

    foreach (int[] individualPump in sequenceOfPumps)
    {
        int litres = individualPump[0];
        int distance = individualPump[1];

        fuel += litres - distance;

        if (fuel < 0)
        {
            sequenceOfPumps.Enqueue(sequenceOfPumps.Dequeue());
            position++;
            break;
        }
    }

    if (fuel > 0)
    {
        Console.WriteLine(position);
        break;
    }
}