﻿using System;

namespace Lesson006
{
    public class Program_Q3
    {
        public static void Main_Q3(string[] args)
        {
            Console.Write("Input the number of elements to be stored in the array : ");

            int e = Convert.ToInt32(Console.ReadLine());

            int [] array = new int [e];

            Console.WriteLine("Input "+e+" elements in the array : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write("element - "+i+" : ");
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(" ");

            int sum=0;

            for (int i = 0; i < e; i++)
            {
                sum=array[i]+sum;
            }

            Console.Write("The sum of all elements stored in the array is : "+sum);


        }
    }
}