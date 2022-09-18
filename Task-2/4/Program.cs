const int a = 3; //число элементов 1 ячейки в массиве
const int b = 3; //число элементов 2 ячейки в массиве
const int min_value = 0;
const int max_value = 10;

int[,] numbers = new int[a, b];

Random random = new Random(); //объект для генерации

Console.Write("Рандомный массив: ");

int sum = 0;

//в задании расплывчато написано про позицию, считать ли их с 0 или с 1?

for (int i = 0; i < a; i++)
{
    Console.Write("\n");
    for (int j = 0; j < b; j++)
    {
        numbers[i, j] = random.Next(min_value, max_value); //диапазон генерации от до
        sum += (i + j) % 2 == 0 ? numbers[i, j] : 0; //если ? return true : return false
        Console.Write(numbers[i, j] + " ");
    }
}

Console.Write("\nСумма элементов четных позиций: " + sum);
Console.ReadKey();