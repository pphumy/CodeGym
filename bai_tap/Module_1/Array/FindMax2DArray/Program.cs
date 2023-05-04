﻿using System;

namespace FindMax2DArray
{
  class Program
    {
        public static void Main() 
{
    int i,j;
  	int[,] arr = new int[3,3];
  
       Console.Write("\n\nRead a 2D array of size 3x3 and print the matrix :\n");
       Console.Write("------------------------------------------------------\n");  
  
 
    /* Stored values into the array*/
       Console.Write("Input elements in the matrix :\n");
  for(i=0;i<3;i++)
  {
      for(j=0;j<3;j++)
      {
	      Console.Write("element - [{0},{1}] : ",i,j);
		  arr[i,j] = Convert.ToInt32(Console.ReadLine()); 
      }
  }  
 
            Console.Write("\nThe matrix is : \n");
            for(i=0;i<3;i++)
  {
      Console.Write("\n");
      for(j=0;j<3;j++)
           Console.Write("{0}\t",arr[i,j]);
     }
   Console.Write("\n\n");
    int max = arr[0, 0];
        for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    //Assign current array element to max, if (arr[i,j] > max)
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }               
            }
        Console.WriteLine("Maximum element:" + max);
        }
    }
    
}

