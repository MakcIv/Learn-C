﻿System.Console.WriteLine("введите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b>max)
{
    max=b;
}
if (c>max)
{
    max=c;
}
System.Console.WriteLine("максимальное число ->" + max);
