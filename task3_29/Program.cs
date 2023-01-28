// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


/* ЗАДАЧА 29: Напишите программу, которая задает массив из 8 элементов и выводит их на экран
1,2,5,7,19 -> [1,2,5,7,19]
6,1,33 -> [6,1,33]
*/

Console.Clear();
Console.WriteLine("Давайте выведем массив на экран. Задайте его длину и диапазон чисел");
Console.Write("Длина массива = ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Диапазон от = ");
int minNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Диапазон до = ");
int maxNum = Convert.ToInt32(Console.ReadLine());

int[] CreateArray(int length, int minNum, int maxNum)
{
    int[] Array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Array[i] = new Random().Next(minNum, maxNum + 1);
    }
    return Array;
}
 Console.WriteLine($"массив : "+ string.Join(",", CreateArray(length, minNum, maxNum)));
