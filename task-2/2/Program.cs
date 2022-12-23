using LocalUtils;

const int a = 3; //число элементов 1 ячейки в массиве
const int b = 3; //число элементов 2 ячейки в массиве
const int c = 3; //число элементов 3 ячейки в массиве
const int minValue = -1000;
const int maxValue = 1000;

int[,,] numbers = LocalClass.GetArray(minValue, maxValue, a, b, c);
Console.Write("Рандомный массив: ");
LocalClass.PrintArray(numbers, a, b, c);

Console.Write("\n\nИзмененный массив: ");
LocalClass.ChangeArray(numbers, a, b, c);
LocalClass.PrintArray(numbers, a, b, c);

Console.ReadKey();