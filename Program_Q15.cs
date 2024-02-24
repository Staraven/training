﻿using System;

namespace Lesson006
{
    public class Program_Q15
    {
        public static void Main_Q15(string[] args)
        {
            Console.Write("Input the size of array : ");

            int e = Convert.ToInt32(Console.ReadLine());

            int [] array = new int [e];

            Console.WriteLine("Input "+e+" elements in the array in ascending order : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write("element - "+i+" : ");
                
                array[i] = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine(" ");

           


            Console.WriteLine(" ");

            Console.Write("Input the position, where to delete : ");

            int d = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" ");

            Console.WriteLine("The new list is : ");;               // 1 2 3 4 5

            int [] deletedarray = new int [e-1];

            for (int i = 0; i < d-1; i++)
            {
                deletedarray[i] = array[i];
            }

            for (int i = d; i < e; i++)
            {
                deletedarray[i-1] = array[i];
            }

            for (int i = 0; i < e-1; i++)
            {
                Console.Write(deletedarray[i]+" ");
            }




           
    
      }
    }
}