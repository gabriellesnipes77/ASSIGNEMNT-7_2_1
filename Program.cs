using System;
using System.Collections.Generic;

namespace ASSIGNEMNT_7_2_1
{


    class ShellSortProgram
    {

        //Shell Sort using a list
        static void ShellSort(List<int> list)
        {
            int n = list.Count;

            //Start with a larger gap and reduce it 
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                //Perform a gapped insertion sort
                for (int i = gap; i < n; i++)
                {
                    int temp = list[i];
                    int j = i;

                    //Shell elements of list, that are greater than temp, to one position ahead
                    while (j >= gap && list[j - gap] > temp)
                    {
                        list[j] = list[j - gap];
                        j -= gap;
                    }

                    //Place temp (list [i] at the correct postion

                    list[j] = temp;
                }
            }
        }

        //Function to print the List
        static void PrintList(List<int> list)
        {
            foreach (int num in list)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {

            //Input: Get the array from user
            Console.WriteLine("Enter the number of elements in the array:");
            int n = int.Parse(Console.ReadLine());

            List<int> list = new List<int>();

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            //Output: Print original list
            Console.WriteLine("Original List:");
            PrintList(list);


            //Sort the list using Shell Sort
            ShellSort(list);


            //Output: Print sorted List
            Console.WriteLine("Sorted List: ");
            PrintList(list);
        }
    }
}
