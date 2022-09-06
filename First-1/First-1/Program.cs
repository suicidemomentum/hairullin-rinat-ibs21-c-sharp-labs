const string NoDoubleMessage = "Программа принимает только целые/вещ числа";
const string LessZeroMessage = "Сторона треугольника меньше нуля";
const string MoreMaxMessage = "Сторона треугольника больше макс значения";

void ErrorScene()
{
    Environment.Exit(0);
    Console.ReadKey();
}

double EnterSide()
{
    Console.Write("Введите сторону прямоугольника: ");
    double a; bool f_error = true;

    if (!double.TryParse(Console.ReadLine(), out a)) Console.WriteLine(NoDoubleMessage);
    else if (a < 0) Console.WriteLine(LessZeroMessage);
    else if (a > double.MaxValue) Console.WriteLine(MoreMaxMessage);
    else f_error = false;
    if (f_error) ErrorScene();

    return a;
}

double a = EnterSide();
double b = EnterSide();

Console.WriteLine("Площадь прямоугольника: " + a * b);
Console.ReadKey();