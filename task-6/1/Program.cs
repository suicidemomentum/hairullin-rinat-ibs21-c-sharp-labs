using LocalUtils;

const string message = "You entered not valid int, bye!";

int n = 5;
if (n < 1)
{
    Console.WriteLine(message);
    return;
}

Queue<int> circle = LocalClass.FillQueue(n);
List<int> list = LocalClass.StrikingOutEverySecond(circle);

Console.Write("List of retired people: ");
foreach (var item in list)
{
    Console.Write(item + " ");
}

Console.WriteLine("\nThe remaining person is: " + circle.Dequeue());