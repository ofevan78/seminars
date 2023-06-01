//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0
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
void SumArray(int[] arr)
{
    int size = arr.Length;
    int sum = 0;
    int odd = 0;
    for (int i = 0; i < size; i++)
    {
        odd = arr[i] % 2;
        if (odd > 0)
        {
            sum = sum + arr[i];
        }
        if (odd < 0)
        {
            sum = sum + Math.Abs(arr[i]);
        }



    }
    Console.Write($"сумма нечетных чисеел {sum}");

}
int[] array = GetArray(10, -1, 10);
SumArray(array);
