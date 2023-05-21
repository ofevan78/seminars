//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("видите число");
int numder = int.Parse(Console.ReadLine());
int b = Numberone(numder);
int c = NumberSekondTyo(numder);

if (numder >= 100 && numder < 1000)// для трех значных

{
    Console.WriteLine("последния цифра числа " + numder % 10);
}
if (numder >= 1000 && numder <10000)// для четырех значных
{
     Console.WriteLine("третия цифра " + Numbertou(c));
}

if (numder >= 10000 && numder < 100000)// для пяти значных
{

    Console.WriteLine("третия цифра " + Numbertou(b));
}
else if (numder <=99)
{
    Console.WriteLine("третий цифры нет ");
        }


int Numberone(int a)
{
    int result = a / 100;
    return result;
}
int Numbertou(int a)
{
    int result = a % 10;
    return result;
}

int NumberSekondTyo(int a)
{
    int result = a / 10;
    return result;
}
