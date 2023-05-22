//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
int qurter=Prompt("ведите Четверть");
FindQurterPlane(qurter);



int Prompt(string message)
{
    Console.WriteLine(message);
    int QurterNumber = int.Parse(Console.ReadLine());
    return QurterNumber;
}
void FindQurterPlane(int x )
{
    if (x == 1)
    {
        Console.WriteLine("Диопазон I четверти по x 0 до +бесконечности по y от 0 до +бесконечности ");
    }
    if (x == 2)
    {
        Console.WriteLine("Диопазон II четверти по x -бесконечности до 0 по y 0 до +бесконечности  ");
    }
    if (x == 3)
    {
        Console.WriteLine("Диопазон III четверти по x 0 до -бесконечности по y 0 до -бесконечности");
    }
    if (x == 4)
    {
        Console.WriteLine("Диопазон IV четверти  по x 0 до +бесконечности по y от 0 до -бесконечности");
    }
}
