System.Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 1)
{
    Console.WriteLine("число нечетное", num, "нечетное");
}
else
{
    Console.WriteLine("число четное", num, "четное");
}