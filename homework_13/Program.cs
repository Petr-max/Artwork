// Задача 13: 
// Напишите программу, которая
// выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет. 

// 645-> 5
// 78-> третьей цифры нет
// 32679-> 6

Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = -1;

if (n >= 100)
{
  while (n > 999)
  {
    n = n / 10;
  }
  result = n % 10;
  Console.WriteLine(result);
}
if (n <= 99)
{
  Console.WriteLine($"Третьей цифры нет ");
}


