Console.WriteLine("Введите число :");

int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{ 
    int i = 1;
    while (i <= n)
    { if (i % 2 == 0)
    { Console.WriteLine(i);
    }
    i++;
    }
}
else 
{ 
    int i = -1;
    while (i >= n)
    {
        if (i % 2 == 0)
        {
             Console.WriteLine(i);
        }
        i--;
            }
}
