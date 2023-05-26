//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
int num = Prompt();
Console.WriteLine($"Сумма чисел от 1 до {num} равна = {Getsum(num)} ");
int Prompt()
{
    Console.WriteLine("Введите чилсо");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}

int Getsum(int limit)
{
    int sum = 0;
    for (int i=1;i<=limit;i++)
    {
        sum = sum + i;
    }
    return sum;
}