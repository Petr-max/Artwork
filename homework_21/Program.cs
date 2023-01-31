// Задача 21:
// Напишите программу, которая 
// принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int a1 = ReadInt("Введите координату A1: ");
int b1 = ReadInt("Введите координату B1: ");
int c1 = ReadInt("Введите координату C1: ");
int a2 = ReadInt("Введите координату A2: ");
int b2 = ReadInt("Введите координату B2: ");
int c2 = ReadInt("Введите координату C2: ");

int i = a1 - a2;
int f = b1 - b2;
int j = c1 - c2;

double dist = Math.Sqrt(i * i + f * f + j * j);
double dRound = Math.Round(dist, 2, MidpointRounding.ToZero);

int ReadInt(string dist)
{
  Console.Write(dist);
  return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Расстояние между точками 3D -> {dRound}");