//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int valueX = Prompt("ведите координаты x; ");
int valueY = Prompt("ведите координаты y; ");
FindQurterPlane(valueX,valueY);



int Prompt (string message)
{
    Console.WriteLine(message);
    int coordNumber= int.Parse(Console.ReadLine());
    return coordNumber;
}
void FindQurterPlane(int X , int Y)

{if (X > 0 && Y > 0)
{
    Console.WriteLine(" I Четверть");
}
if (X < 0 && Y > 0)
{
    Console.WriteLine(" II Четверть");
}
if (X < 0 && Y < 0)
{
    Console.WriteLine(" III Четверть");
}
if (X > 0 && Y < 0)
{
    Console.WriteLine(" IV Четверть");
}
}