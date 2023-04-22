// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}
int[,] MultiplyOfTwoMatrixs(int[,] matrix1, int[,] matrix2)
{
    int[,] resMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            resMatrix[i, j] = 0;
            for (int m = 0; m < matrix1.GetLength(1); m++)
            {

                {
                    resMatrix[i, j] = resMatrix[i, j] + matrix1[i, m] * matrix2[m, j];
                }
            }
        }
    }
    return resMatrix;
}

int iIndex1 = 0;
int jIndex1 = 0;
int iIndex2 = 0;
int jIndex2 = 0;
Console.WriteLine("Input sizes for two matrices. 2nd size of matrice1 mast be equal to 1st size of matrice2!!!");
Console.Write("Input i index for matrice1: ");
iIndex1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input j index for matrice1: ");
jIndex1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input i index for matrice2: ");
iIndex2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input j index for matrice2: ");
jIndex2 = Convert.ToInt32(Console.ReadLine());
if (jIndex1 == iIndex2)
{
    int[,] matr1 = CreateMatrixRndInt(iIndex1, jIndex1, 0, 10);
    PrintMatrix(matr1);
    Console.WriteLine();
    int[,] matr2 = CreateMatrixRndInt(iIndex2, jIndex2, 0, 10);
    PrintMatrix(matr2);
    Console.WriteLine();
    int[,] rezultMatrix = MultiplyOfTwoMatrixs(matr1, matr2);
    Console.WriteLine("Result matrice: ");
    Console.WriteLine();
    PrintMatrix(rezultMatrix);
}
else Console.WriteLine("2nd size of matrice1 not equal to 1st size of matrice2, cannot multiply matrices");
