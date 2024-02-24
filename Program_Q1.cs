﻿using System;

namespace Lesson006
{
    public class Program_Q1
    {
        public static void Main_Q1(string[] args)
        {
            Console.WriteLine("Input 10 elements in the array : ");

            
            int [] array = new int [10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("element - "+i+" : ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" ");

            Console.Write("Elements in array are : ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i]+" ");
            }


        }
    }
}