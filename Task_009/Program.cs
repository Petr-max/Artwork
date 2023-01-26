// Задача 9:
// Напишите программу, которая 
// 1. выводит случайное число 
// 2. из отрезка [10, 99]
// 3. и показывает наибольшую цифру числа.

// 78-> 8
// 12-> 2
// 85-> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка 10 -> 99 {number}");

// int firstDigit = number / 10; // 7
// int secondDigit = number % 10; // 8 

// if (firstDigit > secondDigit)
//   Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
// else
//   Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа -> {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

// int maxDigit1 = MaxDigit(23);
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit1}");

// int maxDigit2 = MaxDigit(98);
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit2}");

int MaxDigit(int num) // num = number 
{
  int firstDigit = num / 10; // 7
  int secondDigit = num % 10; // 8 
  int result = firstDigit > secondDigit ? firstDigit : secondDigit;
  return result;
}

// int maxDigit3 = MaxDigit(26);
// Console.WriteLine($"Наибольшая цифра числа -> {maxDigit3}");