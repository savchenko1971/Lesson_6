// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
/*
double pointX;
double pointY;

Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];

if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (d-c)/(a-b);
    pointY = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}
*/


// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте список чисел НегаФибоначчи, в том числе для отрицательных индексов.
//*Пример:*

//- для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

/*
Console.Clear();
Console.WriteLine("Программа, которая выводит ряд Негафибоначчи.");

int InputNumber()
{
    while (true)
    {
        try
        {
            System.Console.Write("Введите число k: ");
            int number = int.Parse(Console.ReadLine()!);
            if (number < 1)
            {
                throw new Exception();
            }

            return number;
        }
        catch (Exception )
        {
            System.Console.WriteLine("Допустимое значение: любое число от 1 до ∞");
            throw;
        }
    }
}

int Fib(int index)
{
    if (index == 0 || index == 1)
        return index;
    return Fib(index - 1) + Fib(index - 2);
}

void PrintNegafib(int k)
{
    int fibNumber;
    List<int> fibList = new List<int>();
    fibList.Add(0);
    for (int i = 1; i < k; i++)
    {
        fibNumber = Fib(i);
        fibList.Add(fibNumber);
        fibList.Insert(0, fibNumber * (i % 2 == 0 ? -1 : 1));
    }
    Console.WriteLine($"k = {k} -> [{string.Join(", ", fibList)}]");
}

int k = InputNumber();
PrintNegafib(k);
*/


// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
/*
Console.WriteLine ("Введите числа:");
string numbers = Console.ReadLine();
// нам нужно перебрать каждый элемент строки, если это не запятая или пробел, кладм его в массив, если запятая или пробле. делаем ++
string [] newNumbers = new string [numbers.Length];
int k = 0;
for (int i = 0; i < newNumbers.Length; i++)
{
  if (numbers[i] == ',')
  {
    k++;
  }
  else
  {
    newNumbers[k] = newNumbers[k]+$"{numbers[i]}";
  }
}
k++;
int [] resultNumbers = new int[k];
PrintArray (resultNumbers, newNumbers);
int sum = 0;
for (int i = 0; i < k; i++)
{
  if (resultNumbers[i]>0)
  {
    sum++;
  }
}
Console.WriteLine ("Количество чисел больше 0: "+sum);

void PrintArray (int [] array, string [] string1)
{
  for (int i = 0; i < array.Length; i++)
  {
  array[i] = Convert.ToInt32(string1[i]);
  Console.Write (array[i]+"  ");
  }
Console.WriteLine();
}
*/





