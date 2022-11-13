// Написать программу вычисления функции Аккермана

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AckermannFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
return AckermannFunction(m, n);
}

int m = ReadIntegerNumber("Введите натуральное число М: ");
int n = ReadIntegerNumber("Введите натуральное число N: ");
Console.WriteLine(AckermannFunction(m, n));