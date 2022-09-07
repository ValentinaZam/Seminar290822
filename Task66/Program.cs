// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m > n)
{
    int temp = m;
     m = n;
     n = temp;
}

int SumNumbers (int num1, int num2)
{
    int sum = num1;
    if (num1 == num2) return sum;
    return sum + SumNumbers(num1 + 1, num2);
}

Console.WriteLine($"Cумма чисел от {m} до {n} -> {SumNumbers(m,n)}");
