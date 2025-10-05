int priceOfEachBullet = int.Parse(Console.ReadLine());
int sizeOfGunBarrel = int.Parse(Console.ReadLine());
int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
int intelligenceValue = int.Parse(Console.ReadLine());

var sequenceOfBullets =  new Stack<int>(bullets);
var sequenceOfLocks = new Queue<int>(locks);

