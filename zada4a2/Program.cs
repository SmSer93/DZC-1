Console.WriteLine("Введите три числа:");

int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int maxnum = a;
if (a > maxnum) maxnum = a;
if (b > maxnum) maxnum = b;
if (c > maxnum) maxnum = c; 
{
Console.WriteLine($"Максимальное {maxnum}");
}
