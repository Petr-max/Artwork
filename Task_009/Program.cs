// Задача 9:
// Напишите программу, которая 
// 1. выводит случайное число 
// 2. из отрезка [10, 99]
// 3. и показывает наибольшую цифру числа.

// 78-> 8
// 12-> 2
// 85-> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число -> {number}");

int maxDigit = MaxDigit(number);

int MaxDigit(int num) // num = number 
{
  int firstDigit = num / 10; // 7
  int secondDigit = num % 10; // 8 
  int result = firstDigit > secondDigit ? firstDigit : secondDigit;
  return result;
}
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");
  int firstDigit = num / 10; // 7
  int secondDigit = num % 10; // 8 
  int result = firstDigit > secondDigit ? firstDigit : secondDigit;
  return result;
}

// int maxDigit3 = MaxDigit(26);
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit3}");
