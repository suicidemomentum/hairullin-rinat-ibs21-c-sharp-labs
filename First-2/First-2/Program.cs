void ErrorScene()
{
    Environment.Exit(0);
    Console.ReadKey();
}

Console.Write("Введите n: ");
int n; bool n_error = true;

if (!int.TryParse(Console.ReadLine(), out n)) Console.WriteLine("Программа принимает только целые числа");
else if (n < 1) Console.WriteLine("Вы ввели значение меньше единицы");
else if (n > int.MaxValue) Console.WriteLine("Вы ввели значение больше максимального");
else n_error = false;
if (n_error) ErrorScene();

for (int i = 0; i < n; i++) //проход по строкам
{
    for (int count = -1; count != i; count++) Console.Write("*");
    Console.Write("\n");
}
Console.ReadKey();