// Задача 19:

// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Enter five numbers: ");
string numeral = Console.ReadLine()!;
int len = numeral.Length;

if (len == 5)
{
  if (numeral[0] == numeral[4] && numeral[1] == numeral[3])
  {
    Console.WriteLine($"{numeral} -> YES");
  }
  else
  {
    Console.WriteLine($"{numeral} -> NO");
  }
}
else
{
  Console.WriteLine($"{numeral} -> Sorry, misentry:(( ");
}

