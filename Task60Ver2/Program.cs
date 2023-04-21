// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента. Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
// Исключение возможности 3-хзначных чисел при размерности 3Dматрицы
// более 90 элементов, НО: тогда пойдёт повтор 2-хзначных чисел


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
                if (numb>99) numb = 10;
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
                Console.Write($"{matrix3D[i, j, k],6} ({i} ,{j} ,{k})");

            }
             Console.WriteLine();
        }
    }
}
int[,,] matr3D = Create3DMatrix(10, 10, 3);
PrintMatrix3D(matr3D);