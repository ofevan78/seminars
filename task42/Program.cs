/*
Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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
    int sum = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {

                sum = sum + array[i, j];

            }
            else
            {
                array[i, j] = 0;
            }


            Console.Write($"{array[i, j]} | ");
        }
        Console.WriteLine();

    }
    Console.WriteLine($"Введите количество столбцов массива:{sum}");

}
int[,] array = GetArray(rows, columns, 5, 6);
Console.WriteLine("");
GetArrayOddSqure(array, rows, columns);
