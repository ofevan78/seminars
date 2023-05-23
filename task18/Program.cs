//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int n = (Prompt("видите число N"));
 NumTable(n);

int Prompt(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    int numN = Convert.ToInt32(value);
    return Math.Abs(numN);
}

void NumTable(int n)
{
    int sqr = 1;
    int currentNum = 1;
    while (currentNum <= n)
{
    sqr = currentNum*currentNum*currentNum;
    Console.WriteLine(sqr);
    currentNum ++;
}
}
