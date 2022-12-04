// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double answer(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return result;
}

Console.WriteLine("Введите aX:");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите aY:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите aZ:");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите bX:");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите bY:");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите bZ:");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Round(answer(x1, y1, z1, x2, y2, z2), 2));