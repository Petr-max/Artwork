// Разберём группы методов

// ....Первая группа методов
// Методы первой группы очень простые и выглядят следующим образом. Допустим:

void Metod1()
{
  Console.WriteLine("Автор Pitr");
}
Metod1(); //— где Metod1, является идентификатором метода

// ....Вторая группа методов
// Это методы, которые ничего не возвращают, но в то же время могут принимать какие-то аргументы.

void Metod2(string msg) //— где void ключевое слово, дальше идентификатор, 
                        // в скобках указаны какие-то аргументы.
{
  Console.WriteLine(msg); //— оператор, в скобках указан принятый аргумент.
}
Metod2("Текст сообщения"); //— где Metod2 является идентификатором, 
а в скобках указан текст, выводимый в консоли.

....Именованные аргументы

void Metod21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg); //- где переменная count отображает на экране
                            // определённое количество сообщений msg.
    i++;
  }
}
Metod21("Текст", 4); //- метод вызывает Текст, после запятой указано 
количество вызовов, в нашем случае 4.
Metod21(count: 4, msg: "Новый Текст");

....Третья группа методов
Эти методы, которые что-то возвращают, но ничего не принимают. 

int Metod3() //- не принимает никакие аргументы
{
  return DataTime.Now.Year; //- обязательное использование оператора return,
}
int year = Metod3(); //- вызываем метод, в левой части используем идентификатор
                     // переменной (year) и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);

// ....Четвёртая группа методов
// Самая важная группа методов, это методы, которые что-то принимают и что-то возвращают.

string Metod4(int count, string text)
{
  int i = 0;
  string result = String.Empty;
  while (i < count)
  {
    result = result + text;
    i++;
  }
  return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);

....Цикл for

string Metod4(int count, string text)
{
  string result = String.Empty;
  for (int i = 0; i < count; i++) //- вначале ключевое слово, затем инициализация
                                  // счётчика, после проверка условия и инкремент (увеличение счётчика).
  {
    result = result + text;
  }
  return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);

....Таблица умножения

for (int i = 2; i <= 10; i++)
{
  for (int j = 2; j <= 10; j++)
  {
    Console.WriteLine($"{ i} * { j} = { i* j}");
  }
Console.WriteLine();
}

// ....Тренировочная задача

// =====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,";
"ежели бы вас послали вместо нашего милого Винценгероде,";
"вы бы взяли приступом согласие прусского короля.";
"Вы так красноречивы. Вы дадите мне чаю?";
string s = "qwerty"
012345
s[3] // r

string Replase(string text, char oldValue, char newValue)
{
  string result = String.Empty;
  int length = text.Length;
  for (int i = 0; i < length; i++)
  {
    if (text[i] == oldValue) result + $"{NewValue}";
    else result + $"{str[i]}";
  }
  return result;
}
string newText = replace(text, ' ', " | ");
Console.WriteLine(newText);

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

....Упорядочить массивы

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PtintArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]}");
  }
  Console.WriteLine();
}
void selectionSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;
    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition]) minPosition = j;
      {
        minPosition = j;
      }
    }
    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

