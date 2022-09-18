const int a = 3; //число элементов 1 ячейки в массиве
const int b = 3; //число элементов 2 ячейки в массиве
const int c = 3; //число элементов 3 ячейки в массиве
const int min_value = -1000;
const int max_value = 1000;

int[,,] numbers = new int[a, b, c];

Random random = new Random(); //объект для генерации

Console.Write("Рандомный массив: ");

for (int i = 0; i < a; i++)
{
    Console.Write("\n");
    for (int j = 0; j < b; j++)
    {
        Console.Write("\n");
        for (int g = 0; g < c; g++)
        {
            numbers[i, j, g] = random.Next(min_value, max_value); //диапазон генерации от до
            Console.Write(numbers[i, j, g] + " ");
        }
    }
}

Console.Write("\n\nИзмененный массив: ");

for (int i = 0; i < a; i++)
{
    Console.Write("\n");
    for (int j = 0; j < b; j++)
    {
        Console.Write("\n");
        for (int g = 0; g < c; g++)
        {
            if (numbers[i, j, g] > 0)
            {
                numbers[i, j, g] = 0;
            }
            Console.Write(numbers[i, j, g] + " ");
        }
    }
}

Console.ReadKey();