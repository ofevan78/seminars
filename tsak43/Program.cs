/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8
*/
int Prompt(string message)
{
    Console.Write(message);
    int M = Convert.ToInt32(Console.ReadLine());
    return M;
}
int M = Prompt("ведите число M;");
int N = Prompt("ведие число N");
Console.WriteLine($" M={M}, N={N}");
SumNatural(M, N);
void SumNatural(int M, int N)
{
    if (M > N)
    {
        for (int j = N; j <= M; j++)
        {
            Console.Write($" {j}");
        }
    }
    else
    {
        for (int z = M; z <= N; z++)
        {
            Console.Write($" {z}");
        }
    }
}

