/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15-> 120
M = 4; N = 8. -> 30

*/
int Prompt(string message)
{
    Console.WriteLine(message);
    int m = int.Parse(Console.ReadLine());
    int M = Convert.ToInt32(m);




    return M;
}

int M = Prompt("видите число M: ");
int N = Prompt("Видите число N;");
Console.WriteLine($" M={M}, N={N}");

SumNatural(M, N);
void SumNatural(int M, int N)
{
    int T = 0;
    if (M > N)
    {
        for (int j = N; j <= M; j++)
        {
            T += j;


        }
        Console.Write($" {T}");
    }
    else
    {
        for (int z = M; z <= N; z++)
        {
            T += z;

        }
        Console.Write($" {T}");

    }

}
