//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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
void DifferenceArray(int[] arr)
{
    int size = arr.Length;
    int maxValue = 0;
    int minValue = 1;
    int difference = 0;

    for (int i = 0; i < size; i++)
    {
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
        if (arr[i] < minValue)
        {
            minValue = arr[i];

        }

    }
    difference = maxValue - minValue;

    Console.Write($"разница {maxValue} {minValue} {difference}");

}
int[] array = GetArray(10, 1, 10);
DifferenceArray(array);