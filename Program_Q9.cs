﻿using System;

namespace Lesson006
{
    public class Program_Q9
    {
        public static void Main_Q9(string[] args)
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

            int s = 0;

            for (int i = 0; i < e; i++)
            {
                for (int j = 0; j < e-1; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        s = array[j+1];
                        array[j+1] = array[j];
                        array[j] = s;
                    }
                }
            }

            Console.WriteLine(" ");

            Console.Write("Maximum element is : "+array[e-1]);

            Console.WriteLine(" ");

            Console.Write("Minimum element is : "+array[0]);


            


            


          

        }
    }
}