// напишите программу которая принимает на вход три числа и выдает максимальное из итих чисел  
Console.WriteLine("Ведите три числа");
int numbera = int.Parse(Console.ReadLine());
int numberb = int.Parse(Console.ReadLine());
int numberc = int.Parse(Console.ReadLine());
if (numbera>numberb&&numbera>numberc)
{
    Console.WriteLine(numbera + " максимальное число");
}
if (numberb>numbera&&numberb>numberc)
{
    Console.WriteLine(numberb + " максимальное число");
}
if (numberc>numberb&&numberc>numbera)
{
    Console.WriteLine(numberc + " максимально число");
}



   
