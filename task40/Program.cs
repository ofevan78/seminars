/*

*/

Console.Write("Введите количество строк массива ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов массива ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns);




int[,] GetArray(int rows, int columns)
{

    int[,] result = new int[columns, rows];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = i + j;
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}



