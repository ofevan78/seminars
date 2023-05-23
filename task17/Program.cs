//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел
//от 1 до N.

//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4

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
    sqr = currentNum*currentNum;
    Console.WriteLine(sqr);
    currentNum ++;
}
}