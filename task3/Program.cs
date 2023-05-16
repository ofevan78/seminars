//Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8
Console.WriteLine("видите трех значное число");
int numder = int.Parse(Console.ReadLine());
if(numder>=100&&numder<1000)
{
    Console.WriteLine("последния цифра числа " + numder % 10);
}
else
{
    Console.WriteLine("неправльный ввод");
}