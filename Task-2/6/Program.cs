﻿const int n = 10; //число элементов в массиве
const int min_value = -1000;
const int max_value = 1000;

int[] f_numbers = new int[n];

Random random = new Random(); //объект для генерации

Console.Write("Рандомный массив: ");

int size = 0;

for (int i = 0; i < n; i++)
{
    f_numbers[i] = random.Next(min_value, max_value); //диапазон генерации от до
    size += f_numbers[i] < 0 ? 1 : 0; //если ? return true : return false
    Console.Write(f_numbers[i] + " ");
}

Console.Write("\nНовый массив: ");

//можно ли было пользоваться встроенным add или т.п?

int[] s_numbers = new int[n + size];
int index = 0;

for (int i = 0; i < n; i++)
{
    if (f_numbers[i] < 0)
    {
        s_numbers[index] = f_numbers[i];
        s_numbers[index + 1] = f_numbers[i];
        Console.Write(s_numbers[index] + " " + s_numbers[index + 1] + " ");
        index++;
    }
    else
    {
        s_numbers[index] = f_numbers[i];
        Console.Write(s_numbers[index] + " ");
    }
    index++;
}

Console.ReadKey();