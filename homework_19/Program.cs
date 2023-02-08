// Задача 19:

// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Enter five numbers: ");
Console.ReadLine();
int x = 123;
int a1 = x % 10;
int a2 = x / 10 % 10;
int a3 = x / 100 % 10;

x = a1 * 100 + a2 * 10 + a3;

if (x == 3)
{
  Console.WriteLine($"{x} -> YES");
}
else

  Console.WriteLine($"{x} -> NO");


else

  Console.WriteLine($"{x} -> Sorry, misentry:(( ");

