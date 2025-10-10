int numberOfOperations = int.Parse(Console.ReadLine());

string someString = string.Empty;

var storeLastString = new Stack<string>();

for (int i = 0; i < numberOfOperations; i++)
{
    string command = Console.ReadLine();

    if (command.StartsWith("1"))
    {
        var appendString = command.Substring(2);

        storeLastString.Push(someString);
        someString += appendString;
    }
    else if (command.StartsWith("2"))
    {
        int countOfLastElementsToErase = int.Parse(command.Substring(2));

        storeLastString.Push(someString);
        someString = someString.Substring(0, someString.Length - countOfLastElementsToErase);
    }
    else if (command.StartsWith("3"))
    {
        int index = int.Parse(command.Substring(2));
        Console.WriteLine(someString[index - 1]);
    }
    else if (command.StartsWith("4"))
    {
        someString = storeLastString.Pop();
    }
}


