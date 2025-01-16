using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace compare_algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            while (option != 5)
            {
                //Random n = new Random();
                //Stopwatch sw = new Stopwatch();
                Console.WriteLine("Please input the correct number for your desired option:");
                Console.WriteLine("1: Linear Search");
                Console.WriteLine("2: Binary Search");
                Console.WriteLine("3: Bubble Sort");
                Console.WriteLine("4: Merge Sort");
                Console.WriteLine("5: Quit");
                option = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many numbers in the array?");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[size];
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Enter the number:");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Your array: ");
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
                //Console.WriteLine(CreateArray);
                //Console.WriteLine(menu);

                bool found1 = false;
                int count1 = 0;
                if (option == 1)
                {
                    Console.WriteLine("Enter the number you wish to find in the array you previously entered:");
                    int numtofind = Convert.ToInt32(Console.ReadLine());
                    while (found1 == false)
                    {
                         if (numtofind == numbers[count1])
                         {
                            found1 = true;
                         }
                         else
                         {
                            found1 = false;
                            count1++;
                         }
                    }
                    Console.WriteLine("You number to find was at index: " + count1);
                }
                
                if (option == 3)
                {
                    bool swaps = false;
                    int count3 = 0;
                    int temp;
                    do
                    {
                        swaps = false;
                        for (int j = 0; j < numbers.Length - 1; j++)
                        {
                            if (numbers[j] > numbers[j + 1])
                            {
                                temp = numbers[j];
                                numbers[j] = numbers[j + 1];
                                numbers[j + 1] = temp;
                                swaps = true;
                            }
                            count3++;
                        }
                    } while (swaps);
                    Console.WriteLine("Your sorted array is: " + numbers);
                }
                
            }         
         
        }
        //static int[] CreateArray(int size)
        //{
          
        //    int[] numbers = new int[size];
        //    for (int i = 0; i < size; i++)
        //    {
        //        Console.WriteLine("Enter the number:");
        //        numbers[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("Your array: ");
        //    foreach (int i in numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    return numbers;

        //}
        //static void menu()
        //{
        //    Console.WriteLine("Please input the correct number for your desired option:");
        //    Console.WriteLine("1: Linear Search");
        //    Console.WriteLine("2: Binary Search");
        //    Console.WriteLine("3: Bubble Sort");
        //    Console.WriteLine("4: Merge Sort");
        //    Console.WriteLine("5: Quit");
         
        //}
        
        static void BubbleSort(int[] a)
        {
            
        }
        static void Merge(int[] a, int low, int mid, int high)
        {
            int i, j, k;
            int num1 = mid - low + 1;
            int num2 = high - mid;
            int[] L = new int[num1];
            int[] R = new int[num2];
            for (i = 0; i < num1; i++)
            {
                L[i] = a[low + i];
            }
            for (j = 0; j < num2; j++)
            {
                R[j] = a[mid + j + 1];
            }
            i = 0;
            j = 0;
            k = low;
            while (i < num1 && j < num2)
            {
                if (L[i] <= R[j])
                {
                    a[k] = L[i];
                    i++;
                }
                else
                {
                    a[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < num1)
            {
                a[k] = L[i];
                i++;
                k++;
            }
            while (j < num2)
            {
                a[k] = R[j];
                j++; k++;
            }
        }
        static void MergeSortRecursive(int[] a, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSortRecursive(a, low, mid);
                MergeSortRecursive(a, mid + 1, high);
                Merge(a, low, mid, high);
            }
        }
        //static bool LinearSearch(int[] a, int numToFind)
        //{
        //    Console.WriteLine("Enter your number to find from you array");
        //    numToFind = Convert.ToInt32(Console.ReadLine());
        //}

        //static bool BinarySearch(int[] a, int numToFind)
        //{

        //}

    }
}
