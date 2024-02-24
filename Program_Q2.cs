﻿using System;

namespace Lesson006
{
    public class Program_Q2
    {
        public static void Main_Q2(string[] args)
        {
            Console.Write("Input the number of elements to store in the array : ");

            int e = Convert.ToInt32(Console.ReadLine());

            int [] array = new int [e];

            Console.WriteLine(" ");

            Console.WriteLine("Input "+e+" number of elements in the array : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write("element - "+i+" : ");
                
                array[i] = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine(" ");

            Console.WriteLine("The values store into the array are : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine(" ");

            Console.WriteLine("The values store into the array in reverse are : ");

            for (int i = e-1; i >= 0; i--)
            {
                Console.Write(array[i]+" ");
            }

        }
    }
}