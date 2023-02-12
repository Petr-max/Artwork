// Задача 46: 

// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.

// m = 3, n = 4.

//     0   1   2   3 -> индексы столбцов

// 0   1   4   8  19
// 1   5  -2  33  -2
// 2  77   3   8   1

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Создаем двумерный массив, задаем переменные (rows-строки) и (columns-столбцы)
{
  int[,] matrix = new int[rows, columns]; // 0, 1, 2 по индексам строки
  Random rnd = new Random(); // запись в память новых случайных чисел

  for (int i = 0; i < /*3 итерации*/matrix.GetLength(0); i++) // первый цикл строки, измерение индекса массива с нуля 
  {
    for (int j = 0; j < /*4 итерации*/matrix.GetLength(1); j++) // второй цыкл, проходим по столбцам с 1
    {
      matrix[i, j] = rnd.Next(min, max + 1); // заполняем матрицу случайными числами добавляем индексы (i-строки) и (j-столбцы)
    }
  }
  return matrix; // после заполнения возвращаем массив
}
void PrintMatrix(int[,] matrix) // вывод метода и печать
{
  for (int i = 0; i < matrix.GetLength(0); i++) // первый цикл по строкам i
  {
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++) // второй цикл по столбцам j
    {
      if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | "); // вывод метода i и j с пробелом в 4 строки
      else Console.Write($"{matrix[i, j],4} | "); // вывод метода i и j с пробелом в 4 строки и " | "
    }
    Console.WriteLine("]");
  }
}
int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100); // (3 строки, 4 столбца, длинна массива от -100 до 100)
PrintMatrix(array2D); // печать матрицы в консоль (array2D)