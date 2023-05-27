// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
int[] SumArray(int[] array1, int[] array2)
{
int[] resarray= new int[array1.Length];
for (int i = 0; i<resarray.Length;i++)
{
    resarray[i]= array1[i]+array2[i];
}
return resarray;

}

int[] RandArr(int num)
{
int [] array = new int[num];
for ( int i = 0; i<num; i++)
{
    array [i] = new Random().Next(0,2);
}
return array;
}
void PrintArrya(int[] array)
{
    for(int i=0; i < array.Length; i++)
Console.Write($" [{array[i]}] ");
Console.WriteLine();
}

const int lengtharray = 8;
//PrintArrya(RandArr(lengtharray));
int [] array1 = RandArr(lengtharray);
int [] array2 = RandArr(lengtharray);
PrintArrya(array1);
PrintArrya(array2);
PrintArrya(SumArray(array1,array2));