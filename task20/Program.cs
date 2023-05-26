int n = Prompt("ведиет число");
int num = n;
int rev = 0;
int dig = 0;
while (num > 0)
{
    dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
}
if (n == rev)
{
    Console.WriteLine("да");

}
if (n < rev )
{
    Console.WriteLine("нет");
}
if ( n > rev)
{
    Console.WriteLine("нет");
}
int Prompt(string message)
{
    Console.WriteLine(message);
    int QurterNumber = int.Parse(Console.ReadLine());
    return QurterNumber;
}
//как можно цикал обернуть в метод у меня не получилось 