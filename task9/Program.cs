//Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int rand = new Random().Next(100,1000);
Console.WriteLine("рандомное число " + rand);
int a = rand/100;
int b = rand%10;
Console.WriteLine(" "+a+b);

