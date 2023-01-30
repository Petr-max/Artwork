// Задача 20:
// Напишите программу, которая
// принимает на вход координаты
// двух точек и находит расстояние
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки ");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int xa, int ya, int xb, int yb)

{
  int cat1 = xa - xb;
  int cat2 = ya - yb;
  double result = Math.Sqrt(cat1 * cat2 + cat2 * cat2);
  return result;
}

double distanse = Distanse(x1, y1, x2, y2);
double dRound = Math.Round(distanse, 2, MidpointRounding.ToZero);
Console.Write($"A ({x1} {y1}); B ({x2} {y2}) -> {dRound}");

// double range = Distanse(a, a1, b, b1);
// Console.WriteLine(Math.Round(range, 2, MidpointRounding.ToZero));

// double Distance(int xa, int ya, int xb, int yb)
// {
//   double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
//   return result;
// }