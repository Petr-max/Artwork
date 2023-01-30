// Задача 19:

// Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите пятизначное число: ");
numStr = Console.ReadLine();
firstNum = 0;
endNum = numStr.Length - 1;

if (endNum == 4)
{
  while (firstNum < endNum && Char.IsDigit(numStrfirstNum) && Char.IsDigit(numStrendNum))
  {
    if (numStrfirstNum == numStrendNum)
    {
      firstNum++;
      endNum = endNum - 1;
    }
    else
    {
      Console.WriteLine($"{numStrfirstNum} != {numStrendNum} : число {numStr} не палиндром");
      firstNum = 5;
    }
  }
  if (firstNum == 2) Console.WriteLine($"число {numStr} - палиндром");
  if (firstNum != 2 && firstNum != 5) Console.WriteLine($"{numStr} - не верный ввод");
}
else Console.WriteLine("Значение не пятизначное");

break;
