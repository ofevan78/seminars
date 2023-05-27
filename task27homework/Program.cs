int[] RandArr(int num)
{
int [] array = new int[num];
for ( int i = 0; i<num; i++)
{
    array [i] = new Random().Next(0,999);
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
PrintArrya(RandArr(lengtharray));