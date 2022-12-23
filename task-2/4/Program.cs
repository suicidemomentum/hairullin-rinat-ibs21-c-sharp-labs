using LocalUtils;

const int a = 3; //число элементов 1 ячейки в массиве
const int b = 3; //число элементов 2 ячейки в массиве
const int minValue = 0;
const int maxValue = 10;

int[,] numbers = LocalClass.GetArray(minValue, maxValue, a, b);
Console.Write("Рандомный массив: ");
LocalClass.PrintArray(numbers, a, b);

int sum = LocalClass.GetSumEvenPositions(numbers, a, b);
Console.Write("\nСумма элементов четных позиций: " + sum);

Console.ReadKey();