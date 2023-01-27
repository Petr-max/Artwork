// Задача 14.
// Напишите программу, которая принимает
// на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14-> Нет
// 46-> Нет 
// 161-> Да

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

bool mult = Mult(number1);
bool Mult(int num1)
{
  return num1 % 7 == 0 && num1 % 23 == 0;
}
Console.WriteLine(mult ? "Да" : "Нет" );


