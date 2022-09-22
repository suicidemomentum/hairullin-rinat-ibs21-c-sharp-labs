using GlobalUtils;
using LocalUtils;

const int n = 10; //число элементов в массиве
const int minValue = -10;
const int maxValue = 10;

int[] numbers = GlobalClass.GetArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.PrintArray(numbers);

int sum = LocalClass.GetSumPositiveNumbers(numbers);
Console.Write("\nСумма неотриц элементов: " + sum);

Console.ReadKey();