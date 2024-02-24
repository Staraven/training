﻿using System;

namespace Lesson006
{
    public class Program_Q10
    {
        public static void Main_Q10(string[] args)
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


            int [] even = new int [e];

            int [] odd = new int [e];

            int x = 0;

            int y = 0;

            for (int i = 0; i < e; i++)
            {
                if (array[i] %2 == 0)
                {
                    even[x] = array[i];

                    x++;
                }
                else
                {
                    odd[y] = array[i];

                    y++;
                }


                
            }

            Console.WriteLine("The Even elements are : ");

            for (int i = 0; i < x; i++)
            {
                Console.Write(even[i]+" ");
            
            }


            Console.WriteLine(" ");

            Console.WriteLine("The Odd elements are : ");

            for (int i = 0; i < y; i++)
            {
                Console.Write(odd[i]+" ");
            }
                

            
            


            


          

        }
    }
}