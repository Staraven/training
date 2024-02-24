﻿using System;

namespace Lesson006
{
    public class Program_Q4
    {
        public static void Main_Q4(string[] args)
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

            Console.WriteLine("The elements stored in the first array are : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write(array[i]+" ");
            }

            Console.WriteLine(" ");

            int [] copiedarray = new int [e];

            for (int i = 0; i < e; i++)
            {
                copiedarray[i] = array[i];
            }

            Console.WriteLine("The elements copied into the second array are : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write(copiedarray[i]+" ");
            }


          

        }
    }
}