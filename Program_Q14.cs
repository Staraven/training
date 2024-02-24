﻿using System;

namespace Lesson006
{
    public class Program_Q14
    {
        public static void Main_Q14(string[] args)
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


            Console.WriteLine(" ");

            Console.Write("Input the position, where to value to be inserted : ");

            int p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The current list of the array : ");

            for (int i = 0; i < e; i++)
            {
                Console.Write(array[i]+" ");

            }


            Console.WriteLine(" ");


            int [] insertedarray = new int [e+1];

            for (int i = 0; i < p; i++)
            {
                insertedarray[i] = array[i];
            }

            insertedarray[p-1] = v;





            for (int i = p-1; i < e; i++)
            {
                insertedarray[i+1] = array[i];
            }

            for (int i = 0; i < e+1; i++)
            {
                Console.Write(insertedarray[i]+" "); 
                
            }




           
                

            
            


            


          

            }
    }
}