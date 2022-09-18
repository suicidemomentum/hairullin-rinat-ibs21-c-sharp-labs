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
    Console.Write("Введите сторону треугольника: ");
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
double c = EnterSide();

if (a + b > c && b + c > a && a + c > b) //если учитывать вырожденные треугольники, то со знаком равно проверять
{
    double p = (a + b + c) / 2;
    double s = Math.Round(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2); //roud округление (число, кол-во знаков после запятой)
    Console.WriteLine("Площадь треугольника: " + s);
}
else Console.WriteLine($"Треугольника со сторонами {a}, {b}, {c} не существует");

Console.ReadKey();