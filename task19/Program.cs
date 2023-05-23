//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84

//A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = Prompt("Ведите кординат x1 ");
int y1= Prompt("Ведите кординат y1 ");
int z1 = Prompt("Ведите кординат z1 ");
int x2= Prompt("Ведите кординат x2 ");
int y2 = Prompt("Ведите кординат y2 ");
int z2 = Prompt("Ведите кординат z2 ");
double d = DistanceCoordinates(x1,y1,z1,x2,y2,z2);
int Prompt(string message)
{
    Console.WriteLine(message);
    int QurterNumber = int.Parse(Console.ReadLine());
    return QurterNumber;
}
double DistanceCoordinates(int xa, int ya, int za, int xb, int yb, int zb)
{
double result = Convert.ToDouble(Math.Round(Math.Sqrt(((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya))+((zb-za)*(zb-za))),3));
Console.Write( "растояние между двух точек  " + result );
return result;
}
