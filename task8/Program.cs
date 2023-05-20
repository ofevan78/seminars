int rand = new Random().Next(10, 100);
Console.WriteLine(rand);
int a1 = FindFirstDigitNumber(rand);
int b1 = FindSecondDigitNumber(rand);
FindLargestNumber(a1, b1);

int rand1 = new Random().Next(10, 100);
Console.WriteLine(rand1);
int a2 = FindFirstDigitNumber(rand1);
int b2 = FindSecondDigitNumber(rand1);
FindLargestNumber(a2, b2);


void FindLargestNumber(int a, int b)
{
    if (a > b)
    {
        Console.WriteLine("Нйбольшоя цифра числа " + a);
    }
    else if (a < b)
    {
        Console.WriteLine("Нйбольшоя цифра числа " + b);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

int FindFirstDigitNumber(int r)
{
    int result = r / 10;
    return result;
}

int FindSecondDigitNumber(int r)
{
    int result = r % 10;
    return result;
}