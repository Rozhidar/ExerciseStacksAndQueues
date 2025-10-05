string[] inputSongs = Console.ReadLine().Split(", ").ToArray();

var playList = new Queue<string>(inputSongs);

while (playList.Count > 0)
{
    var command = Console.ReadLine();

    if (command == "Play")
    {
        playList.Dequeue();
    }
    else if (command.StartsWith("Add"))
    {
        var songName = command.Substring(4);

        if (playList.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            playList.Enqueue(songName);
        }
    }
    else if (command == "Show")
    {
        Console.WriteLine(string.Join(", ", playList));
    }
}

Console.WriteLine("No more songs!");
