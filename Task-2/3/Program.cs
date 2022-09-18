const int n = 10; //число элементов в массиве
const int min_value = -1000;
const int max_value = 1000;

int[] numbers = new int[n];

Random random = new Random(); //объект для генерации

Console.Write("Рандомный массив: ");

int sum = 0;

for (int i = 0; i < n; i++)
{
    numbers[i] = random.Next(min_value, max_value); //диапазон генерации от до
    sum += numbers[i] > 0 ? numbers[i] : 0; //если ? return true : return false
    Console.Write(numbers[i] + " ");
}

Console.Write("\nСумма неотриц элементов: " + sum);
Console.ReadKey();