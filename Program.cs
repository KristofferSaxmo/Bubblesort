using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Antal nummer: ");
            int antal = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Högsta möjliga tal: ");
            int högst = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Skriv 1, 2, 3 eller 4");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. Alla");
            Console.WriteLine(" ");
            int sort = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (sort == 1) //Bubble Sort
            {
                Bubble(ref antal, ref högst);
            }

            else if (sort == 2) //Insertion Sort
            {
                Insertion(ref antal, ref högst);
            }

            else if (sort == 3) //Merge Sort
            {
                int[] nummer3 = new int[antal];
                Console.WriteLine("Laddar...");
                Console.WriteLine(" ");
                for (int i = 0; i < antal; i++)
                {
                    nummer3[i] = random.Next(högst + 1);
                }
                var watch = System.Diagnostics.Stopwatch.StartNew();
                MergeSort(nummer3, 0, nummer3.Length - 1);
                watch.Stop();
                if (antal <= 100000)
                {
                    foreach (int item in nummer3)
                    {
                        Console.Write(item + " ");
                    }
                }
                else
                {
                    Console.WriteLine("KLAR");
                    Console.WriteLine(" ");
                }
                var minuter = watch.ElapsedMilliseconds / 1000 / 60;
                var sekunder = watch.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                int s = Convert.ToInt32(sekunder);
                int m = Convert.ToInt32(minuter);
                Tid(ref m, ref s);
            }

            else if (sort == 4) //Alla
            {
                int s, m;

                //Bubble Sort
                int[] nummer = new int[antal];
                int flag, val;
                Console.WriteLine("Bubble Sort");
                Console.WriteLine("Laddar...");
                Console.WriteLine(" ");
                for (int i = 0; i < antal; i++)
                {
                    nummer[i] = random.Next(högst + 1);
                }
                var watch = System.Diagnostics.Stopwatch.StartNew();
                for (int q = 0; q < antal - 1; q++)
                {
                    for (int i = 0; i < antal - 1 - q; i++)
                    {
                        if (nummer[i] > nummer[i + 1])
                            Swap(ref nummer[i], ref nummer[i + 1]);
                    }
                }
                watch.Stop();
                if (antal <= 100000)
                {
                    foreach (int item in nummer)
                    {
                        Console.Write(item + " ");
                    }
                }
                else
                {
                    Console.WriteLine("KLAR");
                    Console.WriteLine(" ");
                }
                var minuter = watch.ElapsedMilliseconds / 1000 / 60;
                var sekunder = watch.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");

                //Insertion Sort
                int[] nummer2 = new int[antal];
                for (int i = 0; i < antal; i++)
                {
                    nummer2[i] = random.Next(högst + 1);
                }
                var watch2 = System.Diagnostics.Stopwatch.StartNew();
                Console.WriteLine(" ");
                Console.WriteLine("Insertion Sort");
                Console.WriteLine("Laddar...");
                Console.WriteLine(" ");
                for (int i = 1; i < antal; i++)
                {
                    val = nummer2[i];
                    flag = 0;
                    for (int j = i - 1; j >= 0 && flag != 1;)
                    {
                        if (val < nummer2[j])
                        {
                            nummer2[j + 1] = nummer2[j];
                            j--;
                            nummer2[j + 1] = val;
                        }
                        else flag = 1;
                    }
                }
                watch2.Stop();
                if (antal <= 100000)
                {
                    foreach (int item in nummer2)
                    {
                        Console.Write(item + " ");
                    }
                }
                else
                {
                    Console.WriteLine("KLAR");
                    Console.WriteLine(" ");
                }
                var minuter2 = watch2.ElapsedMilliseconds / 1000 / 60;
                var sekunder2 = watch2.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");

                //Merge Sort
                int len = antal;
                int[] numbers = new int[antal];
                Console.WriteLine(" ");
                Console.WriteLine("Merge Sort");
                Console.WriteLine("Laddar...");
                Console.WriteLine(" ");
                for (int i = 0; i < antal; i++)
                {
                    numbers[i] = random.Next(högst + 1);
                }
                var watch3 = System.Diagnostics.Stopwatch.StartNew();
                MergeSort(numbers, 0, len - 1);
                watch3.Stop();
                if (antal <= 100000)
                {
                    foreach (int item in numbers)
                    {
                        Console.Write(item + " ");
                    }
                }
                else
                {
                    Console.WriteLine("KLAR");
                    Console.WriteLine(" ");
                }
                var minuter3 = watch3.ElapsedMilliseconds / 1000 / 60;
                var sekunder3 = watch3.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Tider:");
                Console.WriteLine(" ");

                Console.Write("Bubble Sort - ");
                s = Convert.ToInt32(sekunder);
                m = Convert.ToInt32(minuter);
                Tid(ref m, ref s);
                Console.WriteLine(" ");

                Console.Write("Insertion Sort - ");
                s = Convert.ToInt32(sekunder2);
                m = Convert.ToInt32(minuter2);
                Tid(ref m, ref s);
                Console.WriteLine(" ");

                Console.Write("Merge Sort - ");
                s = Convert.ToInt32(sekunder3);
                m = Convert.ToInt32(minuter3);
                Tid(ref m, ref s);
            }
        }
        static void Bubble(ref int antal, ref int högst)
        {
            Random random = new Random();
            int[] nummer = new int[antal];
            Console.WriteLine("Laddar...");
            Console.WriteLine(" ");
            for (int i = 0; i < antal; i++)
            {
                nummer[i] = random.Next(högst + 1);
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int q = 0; q < antal - 1; q++)
            {
                for (int i = 0; i < antal - 1 - q; i++)
                {
                    if (nummer[i] > nummer[i + 1])
                        Swap(ref nummer[i], ref nummer[i + 1]);
                }
            }
            watch.Stop();
            if (antal <= 100000)
            {
                foreach (int item in nummer)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("KLAR");
            }
            var minuter = watch.ElapsedMilliseconds / 1000 / 60;
            var sekunder = watch.ElapsedMilliseconds / 1000 % 60;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            int s = Convert.ToInt32(sekunder);
            int m = Convert.ToInt32(minuter);
            Tid(ref m, ref s);
        }
        static void Insertion(ref int antal, ref int högst)
        {
            Random random = new Random();
            int flag, val;
            int[] nummer2 = new int[antal];
            Console.WriteLine("Laddar...");
            Console.WriteLine(" ");
            for (int i = 0; i < antal; i++)
            {
                nummer2[i] = random.Next(högst + 1);
            }
            var watch = System.Diagnostics.Stopwatch.StartNew();
            for (int i = 1; i < antal; i++)
            {
                val = nummer2[i];
                flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < nummer2[j])
                    {
                        nummer2[j + 1] = nummer2[j];
                        j--;
                        nummer2[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            watch.Stop();
            if (antal <= 100000)
            {
                foreach (int item in nummer2)
                {
                    Console.Write(item + " ");
                }
            }
            else
            {
                Console.WriteLine("KLAR");
            }
            var minuter = watch.ElapsedMilliseconds / 1000 / 60;
            var sekunder = watch.ElapsedMilliseconds / 1000 % 60;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            int s = Convert.ToInt32(sekunder);
            int m = Convert.ToInt32(minuter);
            Tid(ref m, ref s);
        }
        static void Merge(int[] input, int vänster, int mitten, int höger)
        {
            int[] vänsterarray = new int[mitten - vänster + 1];
            int[] högerarray = new int[höger - mitten];
            Array.Copy(input, vänster, vänsterarray, 0, mitten - vänster + 1);
            Array.Copy(input, mitten + 1, högerarray, 0, höger - mitten);
            int i = 0;
            int j = 0;
            for (int k = vänster; k < höger + 1; k++)
            {
                if (i == vänsterarray.Length)
                {
                    input[k] = högerarray[j];
                    j++;
                }
                else if (j == högerarray.Length)
                {
                    input[k] = vänsterarray[i];
                    i++;
                }
                else if (vänsterarray[i] <= högerarray[j])
                {
                    input[k] = vänsterarray[i];
                    i++;
                }
                else
                {
                    input[k] = högerarray[j];
                    j++;
                }
            }
        }
        static void MergeSort(int[] input, int vänster, int höger)
        {
            if (vänster < höger)
            {
                int mitten = (vänster + höger) / 2;
                MergeSort(input, vänster, mitten);
                MergeSort(input, mitten + 1, höger);
                Merge(input, vänster, mitten, höger);
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Tid(ref int m, ref int s)
        {
            if (m == 0)
            {
                if (s == 1)
                {
                    Console.WriteLine(s + " sekund");
                }
                else
                {
                    Console.WriteLine(s + " sekunder");
                }
            }
            else if (m == 1)
            {
                if (s == 0)
                {
                    Console.WriteLine(m + " minut");
                }
                else if (s == 1)
                {
                    Console.WriteLine(m + " minut " + s + " sekund");
                }
                else
                {
                    Console.WriteLine(m + " minut " + s + " sekunder");
                }
            }
            else
            {
                if (s == 0)
                {
                    Console.WriteLine(m + " minuter");
                }
                else if (s == 1)
                {
                    Console.WriteLine(m + " minuter " + s + " sekund");
                }
                else
                {
                    Console.WriteLine(m + " minuter " + s + " sekunder");
                }
            }
        }
    }
}
