// Задача 68: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// { A(0, m) = m+1
// { A(n+1,0) = A(n, 1)
// { A(n+1, m+1) = A(n, A(n+1, m))

int AckermannFunction(int n, int m)
{
    int result = 0;
    if (n == 0) result = m + 1;
    else if (m == 0) result = AckermannFunction(n - 1, 1);
    else result = AckermannFunction(n - 1, AckermannFunction(n, m - 1));
    return result;
}

Console.Write("Input non-negative number n: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Input non-negative number m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
int askFun = 0;
if (numberN >= 0 && numberM >= 0)
{
    askFun = AckermannFunction(numberN, numberM);
    Console.WriteLine(askFun);
}
else Console.WriteLine("Input is not correct");
