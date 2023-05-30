//задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5
//Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6]-> 36 21
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
void CheckNumArr(int[] arr, int userNumMin, int userNumMax)
{
    int count = 0;
    foreach (int el in arr)
    {

        if (el >= userNumMin && el <= userNumMax)
        {
            count++;

        }





    }
    Console.WriteLine($"количество чисел в диопозоне от {userNumMin} до {userNumMax} = {count}");




}

int[] array = GetArray(123, 0, 150);
Console.WriteLine();
CheckNumArr(array, 10, 99);

