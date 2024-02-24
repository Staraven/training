﻿using System;

namespace Lesson006
{
    public class Program_Q13
    {
        public static void Main_Q13(string[] args)
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

            Console.Write("Input the value to be inserted : ");

            int v = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("The exist array list is : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write(array[i]+" ");
            }

            
            Console.WriteLine(" ");

            Console.WriteLine("After insert the list is : ");

            int [] insertedarray = new int [e+1];

            for (int i = 0; i < e; i++)
            {
                insertedarray[i] = array[i];
            }

            insertedarray[e] = v;

           
            int s = 0;

            for (int i = 0; i < e+1; i++)
            {
                for (int j = 0; j < e; j++)
                {
                    if (insertedarray[j] > insertedarray[j+1])
                    {
                        s = insertedarray[j+1];
                        insertedarray[j+1] = insertedarray[j];
                        insertedarray[j] = s; 
                        
                    }
                }
            }


            for (int i = 0; i < e+1; i++)
            {
                Console.Write(insertedarray[i]+" ");
            }




            

           
                

            
            


            


          

        }
    }
}