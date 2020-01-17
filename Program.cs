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
                nummer[i] = random.Next(högst+1);
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int q = 0; q < antal-1; q++)
            {
                for (int i = 0; i < antal - 1-q; i++)
                {
                    if (nummer[i] > nummer[i + 1])
                        Swap(ref nummer[i], ref nummer[i + 1]);
                }
            }
            watch.Stop();
            foreach (int element in nummer)
            {
                Console.Write(element + " ");
            }
            var tid = watch.ElapsedMilliseconds;
            Console.WriteLine(" ");
            Console.Write(tid/1000);

        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
