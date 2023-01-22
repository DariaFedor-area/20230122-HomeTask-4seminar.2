// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



/* ЗАДАЧА_25: Напишите цикл, который принимает на вход 2 числа (А и В)и 
возводит число А в натуральную степень В.
3, 5 -> 243 (3 в пятой)
2, 4 -> 16 */

Console.Clear();
Console.WriteLine("Возведем число А в степень числа В");
Console.Write("внесите первое число: А = ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("внесите второе число: В = ");
int B = Convert.ToInt32(Console.ReadLine());

int ToDegree (int A, int B)
{
    int result = 1;
    for (int x = 1; x <= B; x++)    
    {
        result = result * A;
    }
    return result;
}
Console.WriteLine($"результат возведения А в степень В = {ToDegree(A,B)}");