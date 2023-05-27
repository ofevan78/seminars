//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int NumDegree(int a, int b)
{
    int c = a;
    for(int i = 2; i<=b ;i++)
    {
        c = c * a;
    }
return c ;
} 
int Prompt()
{
    Console.WriteLine("Ведите число");
    int Degree = int.Parse(Console.ReadLine());
    return Degree;
}
int Prompt1()
{
    Console.WriteLine("Ведите степень");
    int Degree = int.Parse(Console.ReadLine());
    return Degree;
}
int a = Prompt();
int b = Prompt1();
Console.WriteLine($"число {a} в степни {b} равно {NumDegree(a,b)} ");
