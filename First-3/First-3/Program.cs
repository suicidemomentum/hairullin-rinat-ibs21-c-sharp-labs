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

int n_space = n - 1; //кол-во пробелов

for (int i = 0; i < n; i++, n_space--) //проход по строкам
{
    for (int count = 0; count < n_space; count++) Console.Write(" ");
    for (int count = -1; count != i + i; count++) Console.Write("*");
    for (int count = 0; count < n_space; count++) Console.Write(" ");
    Console.Write("\n");
}
Console.ReadKey();