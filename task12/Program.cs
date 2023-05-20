//Hапишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int rand = new Random().Next(100, 1000);
Console.WriteLine("рандомное число " + rand);
int a = FindFirstDigitNumber(rand);
rand = a % rand;
int b = Numbertou(rand);
Console.WriteLine("второе число " + b);


int FindFirstDigitNumber(int r)
{
    int result = r / 10;
    return result;

}
int Numbertou(int r)
{
    int result = r%10;
    return result;
}