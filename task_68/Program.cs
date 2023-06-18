Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());

Console.Write(Akker(m, n)); 


// функция Аккермана
int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return (Akker(m - 1, Akker(m, n - 1)));
    }
}