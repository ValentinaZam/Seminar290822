// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.WriteLine("Введите целое положительное чичло: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите ещё одно целое положительное чичло: ");
int number2 = Convert.ToInt32(Console.ReadLine());

void PrintNaturalNamber(int num1, int num2)
{
    if (num1 > num2)
    {
        if (num1 == num2 - 1) return;
        Console.Write($"{num1} ");
        PrintNaturalNamber(num1 - 1, num2);
    }
    else if (num2 > num1)
    {
        if (num2 == num1 - 1) return;
        PrintNaturalNamber(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else if (num1 == num2)
    {
        Console.Write($"{num2} ");
    }
}
 
PrintNaturalNamber(number1, number2);