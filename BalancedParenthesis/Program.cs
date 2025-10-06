string inputParentheses = Console.ReadLine();
char[] sequenceOfParentheses = inputParentheses.ToCharArray();

bool areBalanced = true;

var stack = new Stack<char>();

foreach (char bracket in sequenceOfParentheses)
{
    if (bracket == '(' || bracket == '[' || bracket == '{')
    {
        stack.Push(bracket);
    }
    else
    {
        if (stack.Count == 0)
        {
            areBalanced = false;
            break;
        }
        else if ((stack.Peek() == '(' && bracket == ')') ||
           (stack.Peek() == '[' && bracket == ']') ||
            (stack.Peek() == '{' && bracket == '}'))
        {
            stack.Pop();
        }
        else
        {
            areBalanced = false;
            break;
        }
    }
}

if (areBalanced)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}