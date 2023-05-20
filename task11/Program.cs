//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("ведите число от 1 до 7");
int number = int.Parse(Console.ReadLine());
if (number == 1 )
{
    Console.WriteLine( "день недели - понеделник рабочий ");
    }
    else if (number == 2)
    {
    Console.WriteLine("день недели -вторник рабочий ");
    }
    else if (number == 3)
    {
    Console.WriteLine("день недели - среда рабочий ");
    }else if (number == 4)
    {
    Console.WriteLine("день недели -четверг рабочий ");
    }else if (number == 5)
    {
    Console.WriteLine("день недели -пятница рабочий ");
    }else if (number == 6)
    {
    Console.WriteLine("день недели -суббота выходной ");
    }else if (number == 7)
    {
    Console.WriteLine("день недели -воскресение выходной ");
    }
    else 
    {
        Console.WriteLine("такого дня недели не сушествует");
    }
    