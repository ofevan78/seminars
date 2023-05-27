//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int NumberSum(int a)
{

int b = 0;
if(a<999)
{ 
    
    for (int i = 0; a > i; i++)
    {
        b = (a % 10) + (a / 100) + (a / 10 % 10) ;
    }

    return b;
}
if(a>999)
{ 
    
    for (int i = 0; a > i; i++)
    {
        b = (a/1000)+(a/100%10)+(a/10%10)+(a%10);
    }

    return b;
}
else  
{
   Console.WriteLine("некоректное число");
   return a;

}
}
int Prompt()
{
    Console.WriteLine("Ведите число");
    int product = int.Parse(Console.ReadLine());
    return product;
}
int a = Prompt();
Console.WriteLine($"{NumberSum(a)}");