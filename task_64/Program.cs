Console.Clear();

void NumbersR(int num)
{
    if (num == 1)
    {
        Console.Write(" ");
        Console.WriteLine(num);
    }
    else
    {
        Console.Write(" ");
        Console.Write(num);
        NumbersR(num - 1);
    }
}

Console.Write($"Введите число: ");
int num = int.Parse(Console.ReadLine());
NumbersR(num);