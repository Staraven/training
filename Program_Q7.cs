﻿using System;

namespace Lesson006
{
    public class Program_Q5
    {
        public static void Main_Q5(string[] args)
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


             Console.Write("Input the number of elements to be stored in the second array : ");

            int e2 = Convert.ToInt32(Console.ReadLine());

            int [] array2 = new int [e2];

            Console.WriteLine("Input "+e2+" elements in the array : ");

            for (int i = 0; i < e2; i++)
            {
                Console.Write("element - "+i+" : ");
                
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }


            int [] mergedarray = new int [e+e2];


            for (int i = 0; i < e; i++)
            {
                mergedarray[i] = array[i];
            }

            for (int i = 0; i < e2; i++)
            {
                mergedarray[i+e] = array2[i];
            }


            int s = 0;
            
            for (int i = 0; i < e+e2; i++)
            {
                for (int j = 0; j < e+e2-1; j++)
                {
                    if (mergedarray[j] > mergedarray[j+1])
                    {
                        s = mergedarray[j+1];
                        mergedarray[j+1] = mergedarray[j];
                        mergedarray[j] = s;
                    }
                }
            }


            Console.WriteLine("The merged array in ascending order is : ");

            for (int i = 0; i < e+e2; i++)
            {
                Console.Write(mergedarray[i]+" ");
            }



            


          

        }
    }
}