﻿//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int [] MultiArray(int[] inArray)
{
    int size = inArray.Length / 2;
    if (inArray.Length % 2 == 1)
    {
        size++;
    }
    int[] result = new int[size];
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        result[i] = inArray[i] * inArray[inArray.Length - 1 - i];
    }
    if (inArray.Length % 2 == 1)

    {
        result[size - 1] = inArray[inArray.Length / 2];
    }
    return result;
}

Console.Clear();

int[] array = GetArray(6, 0, 10);
int[] res = MultiArray(array);

Console.WriteLine($"Массив: {String.Join(", ", array)}");
Console.WriteLine($"Итоговый массив: {String.Join(", ", res)}");