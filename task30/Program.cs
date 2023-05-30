//Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив[6, 7, 19, 345, 3]->нет
//- 3; массив[6, 7, 19, 345, 3]->да
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
void CheckNumArr(int[] arr, int num)
{
    bool check = false;

    foreach (int el in arr)
    {

        if (el == Math.Abs(num))
        {
            Console.WriteLine($"в массиве arr числа [{num}] -> есть");
            check = true;


        }
        if (check = false)
        {
            Console.WriteLine($" в массиве arr числа  [{num}] -> нет");

        }

    }


}

int[] array = GetArray(21, -10, 10);
CheckNumArr(array, 9);