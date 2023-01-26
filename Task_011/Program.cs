
// Задача 11.
// Напишите программу, которая
// 1. выводит трехзначное случайное число 
// 2. и удаляет вторую цифру этого числа. 

// 456-> 46
// 782-> 72
// 918-> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка-> {number}");

int res = RemoveSecondDigit(number);

Console.WriteLine($"Число-> {res}");

int RemoveSecondDigit(int num)

{
  int num1 = number / 100;
  int num3 = number % 10;
  int resalt = num1 * 10 + num3;
  return resalt;
}