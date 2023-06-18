/*
Задайте двумерный массив. Найдите элементы, у
которых оба индекса чётные, и замените эти элементы на их
квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
*/
Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine()!);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{result[i, j]} | ");
        }
        Console.WriteLine();

    }
    return result;
}
void GetArrayOddSqure(int[,] array, int rows, int columns)
{

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = (array[i, j] * array[i, j]);

            }
            else
            {
                array[i, j] = 0;
            }


            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();

    }

}
int[,] array = GetArray(rows, columns, 5, 6);
Console.Write("");
GetArrayOddSqure(array, rows, columns);

