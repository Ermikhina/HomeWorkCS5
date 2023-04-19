// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

int[,] matr = CreateMatrixRndInt(4, 4, -100, 100);
PrintMatrix(matr);
int iIndex = 0;
int jIndex = 0;
Console.Write("Input i index: ");
iIndex = Convert.ToInt32(Console.ReadLine());
Console.Write("Input j index: ");
jIndex = Convert.ToInt32(Console.ReadLine());
if (iIndex >= 0 && jIndex >= 0 && iIndex < matr.GetLength(0) && jIndex < matr.GetLength(1))
    Console.WriteLine($"Element on {iIndex}, {jIndex} position = {matr[iIndex, jIndex]}");
else Console.WriteLine("There is no such element in matrix");