const int n = 10; //число элементов в массиве
const int min_value = 0;
const int max_value = 1000;

int[] numbers = new int[n];

Random random = new Random(); //объект для генерации

Console.Write("Рандомный массив: ");

int max = min_value;
int min = max_value;

for (int i = 0; i < n; i++)
{
    numbers[i] = random.Next(min_value, max_value); //диапазон генерации от до

    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }

    Console.Write(numbers[i] + " ");
}

Console.Write("\nСортированный массив: ");

int temp;

for (int i = 0; i < n - 1; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (numbers[i] > numbers[j])
        {
            temp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = temp;
        }
    }

    Console.Write(numbers[i] + " ");
}

Console.Write(numbers[n - 1]);
Console.Write("\nМаксимальное значение: " + max + ", минимальное значение: " + min);
Console.ReadKey();