// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
// Заготовка!!!

int[,] CreateArrayMatrix(int rows, int colums, int min, int max)
{
    int[,] arr = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i < arr.Length - 1) Console.Write($"{arr[i, j],3} ");
            else Console.Write($"{arr[i, j]}");
        }
        Console.WriteLine();
    }
}
void ChangeRows(int[,] arr)
{
    int firstRow = 0;
    int lastRow = arr.GetLength(0) - 1;
    int temp = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        temp = arr[firstRow, j];
        arr[firstRow, j] = arr[lastRow, j];
        arr[lastRow, j] = temp;
    }
}

Console.Write("Input rows quantity: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Input columns quantity: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] resultArray = CreateArrayMatrix(m, n, 1, 10);
PrintArray(resultArray);
 ChangeRows(resultArray);
Console.WriteLine("Chanded rows:");
 PrintArray(resultArray);
