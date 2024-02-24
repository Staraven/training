﻿using System;

namespace Lesson006
{
    public class Program_Q11
    {
        public static void Main_Q11(string[] args)
        {
            Console.Write("Input the size of array : ");

            int e = Convert.ToInt32(Console.ReadLine());

            int [] array = new int [e];

            Console.WriteLine("Input "+e+" elements in the array : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write("element - "+i+" : ");
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Elements of array in sorted ascending order : ");

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

            for (int i = 0; i < e; i++)
            {
                Console.Write(array[i]+" ");
            }


           
                

            
            


            


          

        }
    }
}