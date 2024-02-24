﻿using System;

namespace Lesson006
{
    public class Program_Q17
    {
        public static void Main_Q17(string[] args)
        {
           Console.Write("Input the size of array : ");

           int s = Convert.ToInt32(Console.ReadLine());

           int [] array = new int [s];

           Console.WriteLine(" ");

           Console.WriteLine("Input "+s+" elements in the array : ");

           for (int i = 0; i < s; i++)
           {
            Console.Write("element - "+i+" : ");

            array[i] = Convert.ToInt32(Console.ReadLine());

           }

        
           Console.WriteLine(" ");

           Console.Write("The second smallest element in the array is : ");

           int k=0;

           for (int i = 0; i < s; i++)
           {
            for (int j = 0; j < s-1; j++)
            {
                if (array[j] > array[j+1])
                {
                  k = array[j+1];
                  array[j+1] = array[j];
                  array[j] = k;
            
                }
            }
           }

           Console.Write(array[1]);


           




           
    
      }
    }
}