// Задача 16.
// Напишите программу, которая принимает на вход
// два числа и проверяет, является ли одно число 
// квадратом другого. 

// 5,25-> Да 
// -4,16-> Да 
// 25,5-> Да 
// 8,9-> Нет 

Console.WriteLine("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(number1, number2);

Console.WriteLine(isSquare ? "Да" : "Нет");

bool IsSquare(int num1, int num2)
{
  return num1 == num2*num2 || num2 == num1*num1;
}
