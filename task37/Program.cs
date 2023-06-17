//Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10
//string Reversstring(string str) пререварачивали строку 
//{
//    string result = String.Empty;
///    for (int i = str.Length - 1; i >= 0; i--)
//        result += str[i];
//    return result;
//}
string ToBinary(int number)
{
    string binar = string.Empty;

    while (number > 0)
    {
        binar = (number % 2).ToString() + binar;
        number = number / 2;


    }
    return (binar);

}
Console.Write("ведите число ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{number} -> {ToBinary(number)}");