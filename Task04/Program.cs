// Написать программу возведения числа А в целую стень B

int ExpoNumb (int a, int b)
{
    if(b == 0) return 1;
    else return a * ExpoNumb(a, b - 1);
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int a = ReadIntegerNumber("Введите число A: ");

int b = ReadIntegerNumber("Введите степень числа: ");

Console.WriteLine($"Число {a} в степени {b} равно " + ExpoNumb(a, b));
