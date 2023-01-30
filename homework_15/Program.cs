// Задача 15:
// Напишете программу, которая принимает 
// на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным. 

// 6-> Да
// 7-> Да
// 1-> Нет

Console.WriteLine("Введите цифру дня недели ");
int day = Convert.ToInt32(Console.ReadLine());

bool DayOff(int day)
{
  return day >= 1 && day <= 5 | day >= 8;
}
Console.WriteLine((DayOff(day) ? "Нет" : "Да"));