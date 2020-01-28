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
            Console.WriteLine("Högsta möjliga tal: ");
            int högst = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Insertion Sort");
            Console.WriteLine("3. Merge Sort");
            Console.WriteLine("4. All");
            int sort = int.Parse(Console.ReadLine());
            if (sort == 1)
            {
                Bubble(ref antal, ref högst);
            }
            else if (sort == 2)
            {
                Insertion(ref antal, ref högst);
            }
            else if (sort == 3)
            {
                int len = antal;
                int[] numbers = new int[antal];
                for (int i = 0; i < antal; i++)
                {
                    numbers[i] = random.Next(högst + 1);
                }
                var watch3 = System.Diagnostics.Stopwatch.StartNew();
                SortMethod(numbers, 0, len - 1);
                watch3.Stop();
                foreach (int item in numbers)
                {
                    Console.Write(item + " ");
                }
                var minuter3 = watch3.ElapsedMilliseconds / 1000 / 60;
                var sekunder3 = watch3.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                if (minuter3 == 0)
                {
                    if (sekunder3 == 1)
                    {
                        Console.WriteLine(sekunder3 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(sekunder3 + " sekunder");
                    }
                }
                else if (minuter3 == 1)
                {
                    if (sekunder3 == 0)
                    {
                        Console.WriteLine(minuter3 + " minut");
                    }
                    else if (sekunder3 == 1)
                    {
                        Console.WriteLine(minuter3 + " minut " + sekunder3 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter3 + " minut " + sekunder3 + " sekunder");
                    }
                }
                else
                {
                    if (sekunder3 == 0)
                    {
                        Console.WriteLine(minuter3 + " minuter");
                    }
                    else if (sekunder3 == 1)
                    {
                        Console.WriteLine(minuter3 + " minuter " + sekunder3 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter3 + " minuter " + sekunder3 + " sekunder");
                    }
                }
            }
            else if (sort == 4)
            {
                int[] nummer = new int[antal];
                int flag, val;
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
                foreach (int element in nummer)
                {
                    Console.Write(element + " ");
                }
                var minuter = watch.ElapsedMilliseconds / 1000 / 60;
                var sekunder = watch.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");
                int[] nummer2 = new int[antal];
                for (int i = 0; i < antal; i++)
                {
                    nummer2[i] = random.Next(högst + 1);
                }
                var watch2 = System.Diagnostics.Stopwatch.StartNew();
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
                foreach (int element in nummer2)
                {
                    Console.Write(element + " ");
                }
                var minuter2 = watch2.ElapsedMilliseconds / 1000 / 60;
                var sekunder2 = watch2.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");
                int len = antal;
                int[] numbers = new int[antal];
                for (int i = 0; i < antal; i++)
                {
                    numbers[i] = random.Next(högst + 1);
                }
                var watch3 = System.Diagnostics.Stopwatch.StartNew();
                SortMethod(numbers, 0, len - 1);
                watch3.Stop();
                foreach (int item in numbers)
                {
                    Console.Write(item + " ");
                }
                var minuter3 = watch3.ElapsedMilliseconds / 1000 / 60;
                var sekunder3 = watch3.ElapsedMilliseconds / 1000 % 60;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.Write("Bubble Sort - ");
                if (minuter == 0)
                {
                    if (sekunder == 1)
                    {
                        Console.WriteLine(sekunder + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(sekunder + " sekunder");
                    }
                }
                else if (minuter == 1)
                {
                    if (sekunder == 0)
                    {
                        Console.WriteLine(minuter + " minut");
                    }
                    else if (sekunder == 1)
                    {
                        Console.WriteLine(minuter + " minut " + sekunder + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter + " minut " + sekunder + " sekunder");
                    }
                }
                else
                {
                    if (sekunder == 0)
                    {
                        Console.WriteLine(minuter + " minuter");
                    }
                    else if (sekunder == 1)
                    {
                        Console.WriteLine(minuter + " minuter " + sekunder + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter + " minuter " + sekunder + " sekunder");
                    }
                }
                Console.WriteLine(" ");
                Console.Write("Insertion Sort - ");
                if (minuter2 == 0)
                {
                    if (sekunder2 == 1)
                    {
                        Console.WriteLine(sekunder2 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(sekunder2 + " sekunder");
                    }
                }
                else if (minuter2 == 1)
                {
                    if (sekunder2 == 0)
                    {
                        Console.WriteLine(minuter2 + " minut");
                    }
                    else if (sekunder2 == 1)
                    {
                        Console.WriteLine(minuter2 + " minut " + sekunder2 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter2 + " minut " + sekunder2 + " sekunder");
                    }
                }
                else
                {
                    if (sekunder2 == 0)
                    {
                        Console.WriteLine(minuter2 + " minuter");
                    }
                    else if (sekunder2 == 1)
                    {
                        Console.WriteLine(minuter2 + " minuter " + sekunder2 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter2 + " minuter " + sekunder2 + " sekunder");
                    }
                }
                Console.WriteLine(" ");
                Console.Write("Merge Sort - ");
                if (minuter3 == 0)
                {
                    if (sekunder3 == 1)
                    {
                        Console.WriteLine(sekunder3 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(sekunder3 + " sekunder");
                    }
                }
                else if (minuter3 == 1)
                {
                    if (sekunder3 == 0)
                    {
                        Console.WriteLine(minuter3 + " minut");
                    }
                    else if (sekunder3 == 1)
                    {
                        Console.WriteLine(minuter3 + " minut " + sekunder3 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter3 + " minut " + sekunder3 + " sekunder");
                    }
                }
                else
                {
                    if (sekunder3 == 0)
                    {
                        Console.WriteLine(minuter3 + " minuter");
                    }
                    else if (sekunder3 == 1)
                    {
                        Console.WriteLine(minuter3 + " minuter " + sekunder3 + " sekund");
                    }
                    else
                    {
                        Console.WriteLine(minuter3 + " minuter " + sekunder3 + " sekunder");
                    }
                }
            }
        }
        static void Bubble(ref int antal, ref int högst)
        {
            Random random = new Random();
            int[] nummer = new int[antal];
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
            foreach (int element in nummer)
            {
                Console.Write(element + " ");
            }
            var minuter = watch.ElapsedMilliseconds / 1000 / 60;
            var sekunder = watch.ElapsedMilliseconds / 1000 % 60;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            if (minuter == 0)
            {
                if (sekunder == 1)
                {
                    Console.WriteLine(sekunder + " sekund");
                }
                else
                {
                    Console.WriteLine(sekunder + " sekunder");
                }
            }
            else if (minuter == 1)
            {
                if (sekunder == 0)
                {
                    Console.WriteLine(minuter + " minut");
                }
                else if (sekunder == 1)
                {
                    Console.WriteLine(minuter + " minut " + sekunder + " sekund");
                }
                else
                {
                    Console.WriteLine(minuter + " minut " + sekunder + " sekunder");
                }
            }
            else
            {
                if (sekunder == 0)
                {
                    Console.WriteLine(minuter + " minuter");
                }
                else if (sekunder == 1)
                {
                    Console.WriteLine(minuter + " minuter " + sekunder + " sekund");
                }
                else
                {
                    Console.WriteLine(minuter + " minuter " + sekunder + " sekunder");
                }
            }
        }
        static void Insertion(ref int antal, ref int högst)
        {
            Random random = new Random();
            int flag, val;
            int[] nummer2 = new int[antal];
            for (int i = 0; i < antal; i++)
            {
                nummer2[i] = random.Next(högst + 1);
            }
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
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
            foreach (int element in nummer2)
            {
                Console.Write(element + " ");
            }
            var minuter2 = watch2.ElapsedMilliseconds / 1000 / 60;
            var sekunder2 = watch2.ElapsedMilliseconds / 1000 % 60;
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            if (minuter2 == 0)
            {
                if (sekunder2 == 1)
                {
                    Console.WriteLine(sekunder2 + " sekund");
                }
                else
                {
                    Console.WriteLine(sekunder2 + " sekunder");
                }
            }
            else if (minuter2 == 1)
            {
                if (sekunder2 == 0)
                {
                    Console.WriteLine(minuter2 + " minut");
                }
                else if (sekunder2 == 1)
                {
                    Console.WriteLine(minuter2 + " minut " + sekunder2 + " sekund");
                }
                else
                {
                    Console.WriteLine(minuter2 + " minut " + sekunder2 + " sekunder");
                }
            }
            else
            {
                if (sekunder2 == 0)
                {
                    Console.WriteLine(minuter2 + " minuter");
                }
                else if (sekunder2 == 1)
                {
                    Console.WriteLine(minuter2 + " minuter " + sekunder2 + " sekund");
                }
                else
                {
                    Console.WriteLine(minuter2 + " minuter " + sekunder2 + " sekunder");
                }
            }
        }
        static public void MergeMethod(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[numbers.Length];
            int i, left_end, num_elements, tmp_pos;
            left_end = (mid - 1);
            tmp_pos = left;
            num_elements = (right - left + 1);
            while ((left <= left_end) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];
                else
                    temp[tmp_pos++] = numbers[mid++];
            }
            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];
            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];
            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }
        static public void SortMethod(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMethod(numbers, left, mid);
                SortMethod(numbers, (mid + 1), right);
                MergeMethod(numbers, left, (mid + 1), right);
            }
        }
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
