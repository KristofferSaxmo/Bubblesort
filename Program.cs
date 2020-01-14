using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antal nummer: ");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine("Högsta möjliga nummer: ");
            int högst = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] nummer = new int[antal];
            for (int i = 0; i < antal; i++)
            {
                nummer[i] = random.Next(högst);
                Console.Write(nummer[i]);
            }
            Swap(ref nummer[1], ref nummer[2]);
            foreach (int element in nummer)
                Console.Write(element + " ");
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
