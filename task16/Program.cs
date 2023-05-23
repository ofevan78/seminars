//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
//
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

int x1 = Prompt("Ведите кординат x1 ");
int y1= Prompt("Ведите кординат y1 ");
int x2= Prompt("Ведите кординат x2 ");
int y2 = Prompt("Ведите кординат y2 ");
double d = DistanceCoordinates(x1,y1,x2,y2);
int Prompt(string message)
{
    Console.WriteLine(message);
    int QurterNumber = int.Parse(Console.ReadLine());
    return QurterNumber;
}
double DistanceCoordinates(int xa, int ya, int xb, int yb)
{
double result = Convert.ToDouble(Math.Sqrt(((xb-xa)*(xb-xa))+((yb-ya)*(yb-ya))));
Console.Write( "растояние между двух точек  " + result );
return result;
}
