using System;
using System.ComponentModel;

namespace Sorting_algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unordered
            //int[] values = { 21, 20, 19, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            //ordered
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };

            //bubble sort
            //length is set to the total length of the array
            int length = values.Length;
            //pass perform
            for (int passes = 0; passes < length; passes++)
            { //compare items
                //resests required swaps clause
                bool Rswaps = false;
                for (int i = 0; i < length - 1; i++)
                {
                    //if the prior value is larger than the next
                    //swap items
                    if (values[i] > values[i + 1])
                    {
                        //sets larger value as temp variable so it can swap
                        int temp = values[i];
                        //the prior position is taken by the smaller value
                        values[i] = values[i + 1];
                        //the larger value goes further down the list
                        values[i + 1] = temp;
                        //changes no swap clause if swap occured
                        Rswaps = true;
                    }
                }
                //if no swaps occur the algorithm with break
                if (Rswaps == false) { break; }
            }
            //prints list after operation
            for (int i = 0; i < values.Length; i++) 
            { Console.Write(values[i] + " "); }
            Console.WriteLine("Bubble");
            //--------------------------------------------------------------------------

            //unordered
            //int[] list = { 21, 20, 19, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

            //ordered
            int[] list = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };

            //insertion sort
            //length is set to the total length of the array
            length = list.Length;
            //pass perform
            for (int passes = 0; passes < length; passes++)
            { //compare items
                //resests required swaps clause
                bool Rswaps = false;
                for (int i = 0; i < length - 1; i++)
                {
                    //if the prior value is larger than the next
                    //swap items
                    if (list[i] > list[i + 1])
                    {
                        //sets larger value as temp variable so it can swap
                        int temp = list[i];
                        //the prior position is taken by the smaller value
                        list[i] = list[i + 1];
                        //the larger value goes further down the list
                        list[i + 1] = temp;
                        //changes no swap clause if swap occured
                        Rswaps = true;
                        //back swaps occur all at all swaps apart from the first
                        if (i != 0) 
                        {
                            //iterates backward
                            for (int backp = i; backp < 0; backp--)
                            {
                                //swaps smaller value back down list
                                if (list[backp] < list[backp - 1])
                                {
                                    temp = list[backp];
                                    list[backp] = list[backp - 1];
                                    list[backp - 1] = temp;
                                }
                            }
                        }
                    }
                }
                //if no swaps occur the algorithm with break
                if (Rswaps == false) 
                { break; }
            }
            //prints list after operation
            for (int i = 0; i < list.Length; i++) 
            { Console.Write(list[i] + " "); }
            Console.WriteLine("Insertion");
            //--------------------------------------------------------------------------
        }
    }
}
