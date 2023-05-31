//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"[{res[i]}] ");


    }
    return res;

}


void ProductArrayNum(int[] arr)
{
    int arrSize = arr.Length;
    int count = 0;

    for (int i = 0; i < arrSize; i++)
    {

        int num = 0;
        num = Math.Abs(arr[i]) % 2;
        if (num == 0)
        {
            count++;
        }





    }
    if (count == 0)
    {
        Console.Write("нет четного числа");
    }
    Console.Write(count);

}

int[] arrya = GetArray(5, 7, 9);
Console.WriteLine();
ProductArrayNum(arrya);






