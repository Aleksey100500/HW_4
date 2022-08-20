/*Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Введите количество элементов массива ");
        int N = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[N];

        for( int i = 0; i < array.Length; i++)
        {
            Console.Write($"{i} = ");
            int arr = Convert.ToInt32(Console.ReadLine());    

            array[i] = arr;
        }
        for( int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}" + ", ");
        }
        
    }
}
