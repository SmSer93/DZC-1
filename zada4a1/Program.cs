Console.WriteLine("Введите два числа:");

int a, b;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
 {
Console.WriteLine($"Max = {a}");
}

if (b > a)
    { 
 Console.WriteLine($"Max = {b}");
}
