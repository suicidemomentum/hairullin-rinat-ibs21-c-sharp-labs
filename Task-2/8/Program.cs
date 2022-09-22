using GlobalUtils;
using LocalUtils;

const int minValue = 0;
const int maxValue = 10;
int n = 0;

Console.Write("Введите кол-во элементов в массиве: ");
n = GlobalClass.GetArraySize();

Console.Write("Рандомный массив: ");
int[] numbers = GlobalClass.GetArray(minValue, maxValue, n);
GlobalClass.PrintArray(numbers);

Console.Write("\nВведите искомое число: ");
int findNum = LocalClass.GetSearchNumber();

Console.Write($"Вхождения числа {findNum}:");
LocalClass.PrintSearchNumbers(findNum, numbers);

Console.ReadKey();