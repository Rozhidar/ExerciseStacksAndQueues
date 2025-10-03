int queriesCount = int.Parse(Console.ReadLine());

var stack = new Stack<int>();

for (int i = 0; i < queriesCount; i++)
{
    string[] command = Console.ReadLine().Split();
    char currentCommand = char.Parse(command[0]);

    if (currentCommand == '1')
    {
        int number = Int32.Parse(command[1].ToString());

        stack.Push(number);
    }
    else if (currentCommand == '2')
    {
        stack.Pop();
    }
    else if (currentCommand == '3')
    {
        if (!stack.Any())
        {
            continue;
        }

        Console.WriteLine(stack.Max());
    }
    else if (currentCommand == '4')
    {
        if (!stack.Any())
        {
            continue;
        }

        Console.WriteLine(stack.Min());
    }
}

Console.WriteLine(string.Join(", ", stack));