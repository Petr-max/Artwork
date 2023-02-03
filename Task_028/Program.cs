// Задача 28: (Факториаал)
// Напишите программу, которая
// принимает на вход число N и 
// выдает произведение чисел от 1 до N.

// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
  int productnum = 1;
  for (int i = 1; i <= num; i++)
  {
    checked // проверка на ошибки
    {
      productnum = productnum * i;
    }

  }
  return productnum;
}
Console.Write("Введите целое число: ");
int number;
if (int.TryParse(Console.ReadLine(), out number))
{
  if (number > 0)
    Console.WriteLine($"Факториал числа {number} = {Factorial(number)}");
  else
    Console.WriteLine("Введено некорректное значение. Введите натуральное число от единици. ");
}
else
  Console.WriteLine("Введено некорректное значение. Введите целое число. ");