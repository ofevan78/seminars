//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int rand = new Random().Next(100, 1000);
Console.WriteLine("рандомное число " + rand);
int a = FindFirstDigitNumber(rand);
int b = FindSecondDigitNumber(rand);

rand = a * 10 + b;
Console.WriteLine("двух значное число " + rand);


int FindFirstDigitNumber(int r)
{
    int result = r / 100;
    return result;

}
int FindSecondDigitNumber(int r)
{
    int result = r % 10;
    return result;
}
