// Найти сумму элементов от M до N, N и M заданы

int SumNumbers(int m, int n)
{
    if(m==n) return m;
    else if (m < n) return n + SumNumbers(m, n-1);
    else return n + SumNumbers(m, n+1);
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int m = ReadIntegerNumber("Введите натуральное число М: ");
int n = ReadIntegerNumber("Введите натуральное число N: ");
Console.WriteLine($"Сумма элементов от {m} до {n} = " + SumNumbers(m, n));
