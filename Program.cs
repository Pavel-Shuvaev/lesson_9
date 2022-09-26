// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

/* Random rnd = new Random();
int m = rnd.Next(0, 100); // Решил убрать ввод значения вручную и сделать его случайным
int n = rnd.Next(0, 100); 

Console.WriteLine($"M = {m} и N = {n}");

if (m > n)
for (int i = n; i <= m; i++)
    Console.Write($"{i} ");
else if (m == n)
Console.Write($"Значения M и N равны");
else
    for (int i = m; i <= n; i++)
        Console.Write($"{i} "); */

//---------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

/* Random rnd = new Random();
int m = rnd.Next(0, 1000); // Решил убрать ввод значения вручную и сделать его случайным
int n = rnd.Next(m, 1000); 
Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке M = {m} до N = {n} равна -> {SumFromMToN(m, n)}\n");

static int SumFromMToN(int i, int n) 
{   int sum = i;
    if (i < n) 
    {
        sum += SumFromMToN(i + 1, n);
    }
    return sum;
} */

//-------------------------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

/* Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

AckermanFunction(m, n);

void AckermanFunction(int m, int n)
{
    Console.Write($"---> A({m},{n}) = {Ackerman(m, n)}");
}

int Ackerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Ackerman(m - 1, 1);
    }
    else
    {
        return (Ackerman(m - 1, Ackerman(m, n - 1)));
    }
} */