const string NoByteMessage = "Программа принимает только целые числа в диапазоне [0;255]";

void ErrorScene()
{
    Environment.Exit(0);
    Console.ReadKey();
}

byte EnterByte()
{
    Console.Write("Введите число: ");
    byte a; bool f_error = true;

    if (!byte.TryParse(Console.ReadLine(), out a)) Console.WriteLine(NoByteMessage);
    else f_error = false;
    if (f_error) ErrorScene();

    return a;
}

byte a = EnterByte();
byte b = EnterByte();

Console.WriteLine($"Побитовое и: {a & b}");
Console.WriteLine($"Побитовое или: {a | b}");
Console.WriteLine($"Побитовое исключающее или: {a ^ b}");
Console.ReadKey();