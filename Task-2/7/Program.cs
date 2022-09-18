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

for (int i = 0; i < n; i++)
{
    int element = 0;
    while (true)
    {
        Console.Write($"Введите элемент [{i}]: ");
        if (!int.TryParse(Console.ReadLine(), out element))
        {
            Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
            continue;
        }
        numbers[i] = element;
        break;
    }
}

Console.Write("Отсортированный массив: ");

int temp;

for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (numbers[i] < numbers[j])
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }

    Console.Write(numbers[i] + " ");
}

Console.Write(numbers[n - 1]);
Console.ReadKey();