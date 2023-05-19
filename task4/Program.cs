Console.WriteLine("ведитете два числа");
int number = int.Parse(Console.ReadLine());
int start = int.Parse(Console.ReadLine());
if (number>start)
{
    Console.WriteLine(number + " Максимальое число");
    Console.WriteLine(start + " Минимальное число");

}
else
{
    Console.WriteLine(start + " Максимальое число");
    Console.WriteLine(number + " Минимальное число");
}



