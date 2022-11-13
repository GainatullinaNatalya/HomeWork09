// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
//Первые два элемента последовательности задаются пользователем

string NumSequence(int numb1, int numb2, int count)
{
    if(count!=0)
    {
        --count;
        int sum = numb1 + numb2;
        return $"{sum} " + NumSequence(numb2, sum, count);
    }
    else return String.Empty;
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int numb1 = ReadIntegerNumber("Введите первый элемент последовательности: ");
int numb2 = ReadIntegerNumber("Введите второй элемент последовательности: ");
int count = ReadIntegerNumber("Введите значение N: ");
Console.WriteLine($"{numb1} " + $"{numb2} " + NumSequence(numb1, numb2, count));





