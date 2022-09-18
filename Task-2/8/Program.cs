const int min_value = 0;
const int max_value = 10;
int n = -1;
bool is_error = true;

Console.Write("Введите кол-во элементов в массиве: ");

if (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
}
else if (n < 1)
{
    Console.WriteLine("Массив не может быть меньше единицы");
}
else is_error = false;

if (is_error)
{
    Console.ReadKey();
    return;
}

int[] numbers = new int[n];

Console.Write("Рандомный массив:");

Random random = new Random(); //объект для генерации

for (int i = 0; i < n; i++)
{
    numbers[i] = random.Next(min_value, max_value); //диапазон генерации от до
    Console.Write(" " + numbers[i]);
}

Console.Write("\nВведите искомое число: ");

int find_num;

while (true)
{
    if (!int.TryParse(Console.ReadLine(), out find_num))
    {
        Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
    }
    break;
}

Console.Write($"Вхождения числа {find_num}:");

bool is_num = false;

for (int i = 0; i < n; i++)
{
    if (numbers[i] == find_num)
    {
        Console.Write(" " + i);
        is_num = true;
    }
}

if (!is_num)
{
    Console.Write(" не найдено");
}

Console.ReadKey();