// Задача 23:

// Напишите программу, которая 
// принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27

// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число (N): ");
int tablecube = Convert.ToInt32(Console.ReadLine());

for (int j = 1; j <= tablecube; j++) Console.Write($"{Math.Pow(j, 3)}, ");

Console.WriteLine(" ");

