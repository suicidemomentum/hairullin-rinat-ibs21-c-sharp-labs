using GlobalUtils;
using LocalUtils;

const int n = 10; //число элементов в массиве
const int minValue = -1000;
const int maxValue = 1000;

int[] numbers = GlobalClass.GetArray(minValue, maxValue, n);
Console.Write("Рандомный массив: ");
GlobalClass.PrintArray(numbers);

Console.Write("\nПоложительный массив: ");
numbers = LocalClass.RemoveNegativeElements(numbers);
GlobalClass.PrintArray(numbers);

Console.ReadKey();