Console.Clear();

int SumR(int num_1, int num_2)
{
    
    if (num_1 == num_2)
    {
        return num_2;
    }
    else
    {
        return num_1+ SumR(num_1 +1, num_2);        
        
    }
  

}

Console.Write($"Введите число 1: ");
int num_1 = int.Parse(Console.ReadLine());
Console.Write($"Введите число 2: ");
int num_2 = int.Parse(Console.ReadLine());

Console.WriteLine(SumR(num_1, num_2));