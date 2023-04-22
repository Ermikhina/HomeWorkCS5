// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNumbers(int numM, int numN)
{
    return numM == numN ? numM : numN + SumOfNumbers(numM, numN - 1);
}

Console.Write("Input natural number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input natural number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (numberM < numberN) sum = SumOfNumbers(numberM, numberN);
else sum = SumOfNumbers(numberN, numberM);
Console.WriteLine($"The sum of the numbers from M to N = {sum}");