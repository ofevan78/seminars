int rand = new Random().Next(10, 100);
Console.WriteLine(rand);
int a = rand / 10;
int b = rand % 10;
if (a > b)
{
    Console.WriteLine("Нйбольшоя цифра числа " + a);
}
else if (a<b)
{
    Console.WriteLine("Нйбольшоя цифра числа " + b);
}
else
{
    Console.WriteLine("Числа равны");
}