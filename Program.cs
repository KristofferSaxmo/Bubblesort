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
                int[] arr = new int[antal];
                for (int i = 0; i < antal; i++)
                {
                    arr[i] = random.Next(högst + 1);
                }
                var watch3 = System.Diagnostics.Stopwatch.StartNew();
                MergeSort(arr, 0, arr.Length - 1);
                watch3.Stop();
                foreach (int item in arr)
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
                MergeSort(numbers, 0, len - 1);
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
        static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle]; 
            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);
            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
        static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);
                Merge(input, left, middle, right);
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
