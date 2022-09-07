// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое положительное чиcло: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0) Console.WriteLine("Вы ввели неккоректное значение");

void PrintNaturalNamber(int num)
{   
    if(num <= 0) return;
    Console.Write(num);
    PrintNaturalNamber(num - 1);
    
}
PrintNaturalNamber(number);

