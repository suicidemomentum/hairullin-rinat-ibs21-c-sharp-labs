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

int[] indexes = LocalClass.GetIndexesOfSearchNumbers(findNum, numbers);

if (indexes.Length == 0)
{
    Console.Write($"Нет вхождений числа {findNum}");
}
else
{
    LocalClass.PrintSearchNumbers(indexes);
}

Console.ReadKey();