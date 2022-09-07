// Задача 67: Напишите программу, 
// которая будет принимать на вход число и 
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите трехзначное положительное чичло: ");
int number = Convert.ToInt32(Console.ReadLine());

int PrintNaturalNamber(int num)
{ 
    int summ = num % 10;
    if (num == 0) return summ;   
    return summ += PrintNaturalNamber(num / 10);   
}

PrintNaturalNamber(number);
Console.Write($"{number}  -> {PrintNaturalNamber(number)}" );
