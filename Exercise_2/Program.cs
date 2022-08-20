/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 
*/

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Введите число:");
        int num = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        while (num > 0)
        {
            sum = sum + num % 10;

            num /= 10;
        }
        Console.WriteLine($"{sum}");
    }
}

