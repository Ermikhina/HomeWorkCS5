// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRndInt(int size, int min, int max)
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
int SumOddElem(int[] arr)
{
    int sumOdd = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0) sumOdd = sumOdd + arr[i];
    }
    return sumOdd;
}
int[] array = CreateArrayRndInt(20, 1, 100);
PrintArray(array);
int sumElemOddNumb = SumOddElem(array);
Console.WriteLine($"Sum ov elements with odd index = {sumElemOddNumb}");