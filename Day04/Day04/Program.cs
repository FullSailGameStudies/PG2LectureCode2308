using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Day04
{
    internal class Program
    {
        static void BubbleSort(List<int> unsorted)
        {
            int n = unsorted.Count;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i <= n-1; i++)
                {
                    if (unsorted[i-1] > unsorted[i])
                    {
                        //swap(A, i - 1, i);

                        //int temp = unsorted[i - 1];
                        //unsorted[i - 1] = unsorted[i];
                        //unsorted[i] = temp;
                        (unsorted[i], unsorted[i-1]) = (unsorted[i-1], unsorted[i]);

                        swapped = true;
                    }
                }
                //n = n - 1;
                n--;
            } 
            while (swapped);
        }

        private static void PrintMe(List<int> nums)
        {
            foreach (int i in nums)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 5, 13, 0, 1, 7 };
            PrintMe(nums);
            BubbleSort(nums);
            PrintMe(nums);
            Console.ReadKey();

            /*
                ╔═══════╗ 
                ║Sorting║
                ╚═══════╝ 
             
                Sorting is used to order the items in a list/array is a specific way
             
                CHALLENGE 1:

                    Convert this BubbleSort pseudo-code into a C# method             
                     
                    procedure bubbleSort(A : list of sortable items)
                      n := length(A)
                      repeat
                          swapped := false
                          for i := 1 to n - 1 inclusive do
                              if A[i - 1] > A[i] then
                                  swap(A, i - 1, i)
                                  swapped = true
                              end if
                          end for
                          n := n - 1
                      while swapped
                    end procedure
                    
            */


            List<string> A = new() { "Wonder Woman", "Batman", "Superman", "Flash", "Aquaman", "Blue Beetle", "Lobo" };
            //call your bubble sort method and pass the list to it
            //print the list after calling the method to prove it was sorted






            /*
                ╔═════════╗ 
                ║Recursion║
                ╚═════════╝ 
             
                Recursion happens when a method calls itself. This creates a recursive loop.
                
                All recursive methods need an exit condition, something that prevents the loop from continuing.
              
            */
            int N = 0;
            RecursiveLoop(N);
            Console.ResetColor();


            /*
                CHALLENGE 2:

                    convert this for loop to a recursive method called Bats. Call Bats here in Main.
             
                    for(int i = 0;i < 100;i++)
                    {
                        Console.Write((char)78);
                        Console.Write((char)65);
                        Console.Write(' ');
                    }
            */

            //
            //call Bats here
            //
            Console.WriteLine();
            List<int> b = new() { 66, 65, 84, 77, 65, 78, 33, 33 };
            foreach (var item in b) Console.Write((char)item);
            Console.WriteLine();



        }

        static void RecursiveLoop(int N)
        {
            //an Exit Condition. This will stop the loop when N >= Console.WindowWidth
            if (N < Console.WindowWidth)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(' ');
                Thread.Sleep(20);

                RecursiveLoop(N + 1);//calls itself which makes the method recursive

                Thread.Sleep(20);
                Console.CursorLeft = N;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Write(' ');
            }
        }
    }
}
