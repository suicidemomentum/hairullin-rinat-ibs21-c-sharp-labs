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

int sum = 0;

for (int i = 0; i < n; i++)
{
    if (i == 0) continue; //можно поставить в int i = 1, но начали с нуля т.к. так принято (вроде)
    if (i % 3 == 0 || i % 5 == 0) sum += i;
}

Console.WriteLine("Сумма всех натур. чисел кратных 3 или 5: " + sum);