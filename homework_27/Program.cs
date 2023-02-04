// Задача 27: 
// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int number = ReadInt("Введите число: ");

int vst = NumberVst(number);
SumNumbers(number, vst);

int NumberVst(int a)
{
  int index = 0;
  while (a > 0)
  {
    a /= 10;
    index++;
  }
  return index;
}
void SumNumbers(int n, int vst)
{
  int sum = 0;
  for (int i = 1; i <= vst; i++)
  {
    sum += n % 10;
    n /= 10;
  }
  Console.WriteLine($"сумма цифр {sum}");
}
int ReadInt(string message)
{
  Console.Write(message);
  return Convert.ToInt32(Console.ReadLine());
}