using GlobalUtils;
using LocalUtils;

int n = 0;

Console.Write("Введите кол-во элементов в массивах: ");
n = GlobalClass.GetArraySize();

int[] f_numbers = new int[n];
int[] s_numbers = new int[n];

Console.Write("Заполнение первого массива\n");
f_numbers = LocalClass.FullArray(f_numbers);

Console.Write("Заполнение второго массива\n");
s_numbers = LocalClass.FullArray(s_numbers);

if (LocalClass.IsSameArrays(f_numbers, s_numbers))
{
    Console.Write("Массивы одинаковы");
}
else
{
    Console.Write("Массивы разные");
}

GlobalClass.PrintArray(s_numbers);
GlobalClass.PrintArray(f_numbers);

Console.ReadKey();