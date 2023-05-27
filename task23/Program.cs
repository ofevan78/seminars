//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

int GetProduct(int a)
{
    int product = 1;
    if (a > 0)
    {
        for (int i = 2; i <= a; i++)
        {
            product *= i;
        }
        return product;
    }
    else if (a < 0)
    {
        for (int i = a; i <= -1; i++)
        {

            product *= i;

        }
        return product;
    }
    else
    {
        return 0;
    }
}

int Prompt()
{
    Console.WriteLine("Ведите число");
    int product = int.Parse(Console.ReadLine());
    return product;
}
int product = Prompt();
Console.WriteLine($"произведение чиесл {product} равна {GetProduct(product)}");