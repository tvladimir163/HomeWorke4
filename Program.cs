Console.Clear();

// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// // 3, 5 -> 243
// // 2, 4 -> 16

// Console.Write("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int result = 1;

// for(int i = 0; i < numberB; i++)
// {
//     result = result * numberA;
// }
// Console.WriteLine($" {numberA} в степени {numberB} = {result}");

// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// // 452 -> 11
// // 82 -> 10
// // 9012 -> 12

// Console.Write("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// while (number > 0)
// {
// int ost = number % 10;
// number = number / 10;
// sum = sum + ost;
// }
// Console.WriteLine("сумма всех цифр в числе равна: " + sum);

// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// // пользователь вводит число элементов в массиве и минимальное и максимальное значение.
// // нужно заполнить массив рандомными данными от минимального до максимального значения.

// // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// // 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int numberSize = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение: ");
int numberMin = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int numberMax = Convert.ToInt32(Console.ReadLine());

int [] array = new int [numberSize];
int size = array.Length;
int index = 0;
Console.WriteLine($"Запаляем массив случайными числами в диапозоне от {numberMin} до {numberMax}");

while(index < size)
{
array[index] = new Random().Next(numberMin, numberMax);
index++;
}

array [0] = numberMin;
array [1] = numberMax;

var orderedNumbers = array.OrderBy(n=>n);
foreach (int i in orderedNumbers)
        Console.Write($"{i}, ");