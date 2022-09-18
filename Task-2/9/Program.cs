int n = -1;
bool is_error = true;

bool is_repeat(int i, int number, int[] numbers)
{
    for (int j = 0; j < i; j++)
    {
        if (numbers[j] == number)
        {
            return true;
        }
    }
    return false;
}

void arr_fill(int[] numbers)
{
    for (int i = 0; i < n; i++)
    {
        int element = 0;
        while (true)
        {
            Console.Write($"Введите элемент [{i}]: ");
            if (!int.TryParse(Console.ReadLine(), out element))
            {
                Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
                continue;
            }
            else if (is_repeat(i, element, numbers))
            {
                Console.Write("Замечено повторение\n");
                continue;
            }
            numbers[i] = element;
            break;
        }
    }
}

bool has_element(int[] numbers, int element)
{
    for (int i = 0; i < n; i++)
    {
        if (numbers[i] == element)
        {
            return true;
        }
    }
    return false;
}

Console.Write("Введите кол-во элементов в массивах: ");

if (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("На вход принимаются только int значения и значения не больше чем " + int.MaxValue);
}
else if (n < 1)
{
    Console.WriteLine("Массив не может быть меньше единицы");
}
else is_error = false;

if (is_error)
{
    Console.ReadKey();
    return;
}

int[] one_numbers = new int[n];
int[] two_numbers = new int[n];

Console.Write("Заполнение первого массива\n");

arr_fill(one_numbers);

Console.Write("Заполнение второго массива\n");

arr_fill(two_numbers);

bool is_same = true;

for (int i = 0; i < n; i++)
{
    if (!has_element(two_numbers, one_numbers[i]))
    {
        Console.Write("Массивы не одинаковые");
        is_same = false;
        break;
    }
}

if (is_same)
{
    Console.Write("Массивы одинаковые");
}

Console.ReadKey();