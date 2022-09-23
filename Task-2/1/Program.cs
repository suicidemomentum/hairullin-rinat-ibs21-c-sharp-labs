using GlobalUtils;
using LocalUtils;

const int n = 10; //число элементов в массиве
const int minValue = 0;
const int maxValue = 1000;

int[] numbers;
numbers = GlobalClass.GetArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.PrintArray(numbers);

int max = LocalClass.GetMax(numbers);
int min = LocalClass.GetMin(numbers);

Console.Write("\nСортированный массив: ");
LocalClass.SortMass(numbers);
GlobalClass.PrintArray(numbers);

Console.Write($"\nМаксимальное значение: {max}, минимальное значение: {min}");
Console.ReadKey();