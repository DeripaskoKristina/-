﻿Console.WriteLine("Введите числа");

int number = int.Parse(Console.ReadLine());


for ( int i = 1; i <= number; i ++ )
{
    if (i % 2 == 0) Console.WriteLine ($"{number} -> {i}");    
}