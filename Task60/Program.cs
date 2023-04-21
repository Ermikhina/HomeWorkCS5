// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] Create3DMatrix(int rows, int columns, int layers)
{
    int[,,] matrix3D = new int[rows, columns, layers];
    int numb = 10;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                matrix3D[i, j, k] = numb;
                numb++;
            }
        }
    }
    return matrix3D;
}
void PrintMatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
            {
                Console.Write($"{matrix3D[i, j, k],4} ({i},{j},{k})");

            }
        }
        Console.WriteLine();
    }
}
int[,,] matr3D = Create3DMatrix(3, 3, 3);
PrintMatrix3D(matr3D);