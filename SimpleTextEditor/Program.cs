int numberOfOperations = int.Parse(Console.ReadLine());

string someString = string.Empty;

var storeLastCommand = new Stack<string>();

for (int i = 0; i < numberOfOperations; i++)
{
    string command = Console.ReadLine();

    if (command.StartsWith("1"))
    {
        var appendString = command.Substring(2);

        someString += appendString;
        storeLastCommand.Push(command);
    }
    else if (command.StartsWith("2"))
    {
        int countOfLastElementsToErase = int.Parse(command.Substring(2));

        someString = someString.Substring(0, someString.Length - countOfLastElementsToErase);
        storeLastCommand.Push(command);
    }
    else if (command.StartsWith("3"))
    {
        int index = int.Parse(command.Substring(2));
        Console.WriteLine(someString[index - 1]);
    }
    else if (command.StartsWith("4"))
    {
        var lastCommand = storeLastCommand.Pop();

        //if (lastCommand.StartsWith("1"))
        //{
        //    var addedText = lastCommand.Substring(2);
        //    someString = someString.Substring(0, someString.Length - addedText.Length);
        //}
        //else if (lastCommand.StartsWith("2"))
        //{
        //    var removedText = lastCommand.Substring(2);

        //    someString += removedText;
        //}
    }
}


//string result = original.Substring(0, original.Length - n);
// hello
// hel
// lo
// 