//Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
int[] GetArray(int size, int maxvalue, int minVaiue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minVaiue, maxvalue + 1);
        Console.Write($"{res[i]} ");


    }
    return res;
}
void NegativeNum(int[] userArray)
{
    int arrSize = userArray.Length;
    for (int i = 0; i < arrSize; i++)
    {
        userArray[i] *= -1;
        Console.Write($"{userArray[i]} ");

    }

}



int[] arr = GetArray(4, 5, -5);
Console.WriteLine();
NegativeNum(arr);
