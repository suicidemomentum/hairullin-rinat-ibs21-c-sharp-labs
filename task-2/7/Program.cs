using GlobalUtils;
using LocalUtils;

int n = 0;

Console.Write("Введите кол-во элементов в массиве: ");
n = GlobalClass.GetArraySize();

int[] numbers = new int[n];
numbers = GlobalClass.FullArray(numbers);

Console.Write("Отсортированный массив: ");
LocalClass.ReverseSortArray(numbers);
GlobalClass.PrintArray(numbers);

Console.ReadKey();