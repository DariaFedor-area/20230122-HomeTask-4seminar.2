// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

/* ЗАДАЧА_27: напишите пограмму, которая принимает на вход число и выдает сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Clear();
Console.WriteLine("Давайте посчитаем сумму цифр вашего любого числа");
Console.Write("Введите целое число = ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int number)
{
    int summ = 0;
    int count = 0;
    for (int i = 0; i <= number; i++)
    {
        count = number % 10;
        summ += count;
    }
    return summ;
}


Console.WriteLine($"сумма цифр в числе = {SumNumbers(number)}");