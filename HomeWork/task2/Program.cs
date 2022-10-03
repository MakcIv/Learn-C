System.Console.WriteLine("введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a>b||a>c)
{
    System.Console.WriteLine("больше {a}");
}
else if (a<b||b>c)
{
    System.Console.WriteLine("больше {b}");
}
else if (b<c||c>a)
{
    System.Console.WriteLine("больше {c}");
}