// Показать натуральные числа от M до N, N и M заданы

string NatNumbers(int m, int n)
{
    if (n >= m) return NatNumbers(m, n - 1) + $"{n} ";
    else return String.Empty;
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int m = ReadIntegerNumber("Введите натуральное число М: ");
int n = ReadIntegerNumber("Введите натуральное число N: ");
Console.WriteLine($"Последовательность натуральных чисел от M до N: " + NatNumbers(m, n));