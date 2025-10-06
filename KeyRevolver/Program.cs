int priceOfEachBullet = int.Parse(Console.ReadLine());
int sizeOfGunBarrel = int.Parse(Console.ReadLine());
int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
int intelligenceValue = int.Parse(Console.ReadLine());

var sequenceOfBullets = new Stack<int>(bullets);
var sequenceOfLocks = new Queue<int>(locks);

int shots = 0;
int reloadingCounter = 0;

bool isOutOfBullets = false;
bool areAllLocksOpen = false;

while (true)
{
    if (sequenceOfLocks.Count == 0)
    {
        areAllLocksOpen = true;
        break;
    }

    if (sequenceOfBullets.Count > 0)
    {
        int currentBullet = sequenceOfBullets.Pop();
        int currentLock = sequenceOfLocks.Peek();

        if (currentBullet <= currentLock)
        {
            sequenceOfLocks.Dequeue();
            Console.WriteLine("Bang!");
        }
        else
        {
            Console.WriteLine("Ping!");
        }

        shots++;
        reloadingCounter++;

        if (reloadingCounter == sizeOfGunBarrel)
        {
            if (sequenceOfBullets.Count != 0)
            {
                Console.WriteLine("Reloading!");
                reloadingCounter = 0;
            }
        }
    }
    else
    {
        isOutOfBullets = true;
        break;
    }
}

if (areAllLocksOpen)
{
    int bulletCost = shots * priceOfEachBullet;
    int earnedMoney = intelligenceValue - bulletCost;
    Console.WriteLine($"{sequenceOfBullets.Count} bullets left. Earned ${earnedMoney}");
}
else if (isOutOfBullets)
{
    Console.WriteLine($"Couldn't get through. Locks left: {sequenceOfLocks.Count}");
}

