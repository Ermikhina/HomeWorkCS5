﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDbl(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble()*(max-min)+min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}  ");
        }
        else Console.WriteLine($"{Math.Round(arr[i], 1, MidpointRounding.ToZero)}]");
    }
}
double MinElem(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
double MaxElem(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
double[] array = CreateArrayRndDbl(10, 1, 100);
PrintArray(array);
double differMinMax =  MaxElem(array) - MinElem(array);
Console.WriteLine($"Difference ov min & max elements = {Math.Round(differMinMax, 1, MidpointRounding.ToZero)}");