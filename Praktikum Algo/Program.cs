﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_Algo
{
     class Program
    {
       // quick sort
        //Array of of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; // number of comparasion
        private int mov_count = 0; // number of data movements

        // number of element in array
        private int n;


        void input()
        {

            while (true)
            {
                Console.Write("Enter the Number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\n Array Can Have maximum 20 elements \n");
            }
            Console.WriteLine("\n========================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n========================");


        }
    }
}
