﻿//Hапишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно
Console.WriteLine("введите два числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
FindLargestNumber(a,b);

void FindLargestNumber(int a, int b)
{
    if(a%b == 0)
    {
        Console.WriteLine("число кратно");
    }
    else 
    {
        Console.WriteLine("число не кратно остаток" + (a%b) );
    }
}

