// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrayRndPos(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else Console.WriteLine($"{arr[i]}]");
    }
}
int QuantEvenElem(int[] arr)
{
    int quant = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) quant++;
    }
    return quant;
}
int[] array = CreateArrayRndPos(20, 1, 100);
PrintArray(array);
int quantityEv = QuantEvenElem(array);
Console.WriteLine($"Quantity ov even = {quantityEv}");
