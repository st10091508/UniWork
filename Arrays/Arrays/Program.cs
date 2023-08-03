using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            #region FirstArray

            int[,] ar = new int[2, 3] { { 2, 4, 6 }, { 8, 10, 12 } };

            //Displaying everthing 

            Console.WriteLine("FIRST ARRAY\n===================================");

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.WriteLine(ar[i,j]);
                }
            }
            Console.WriteLine("===================================");

            Console.WriteLine(ar[0,1]);
            Console.WriteLine(ar[1,0]);
            Console.WriteLine("===================================");
            #endregion

            #region SecondArray
            int[,] ar1 = new int[2, 4];
            ar1[0, 0] = 6;
            ar1[0, 1] = 7;
            ar1[0, 2] = 8;
            ar1[0, 3] = 10;
            ar1[1, 0] = 18;
            ar1[1, 1] = 47;
            ar1[1, 2] = 15;
            ar1[1, 3] = 12;

            Console.WriteLine("SECOND  ARRAY\n===================================");

            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.WriteLine(ar[i, j]);
                }
            }
            Console.WriteLine("===================================");

            Console.WriteLine(ar1[1, 3]);
            Console.WriteLine(ar1[0, 1]);
            Console.WriteLine("===================================");
            #endregion


            //THIRD ARRAY
            #region ThirdArray
            Console.WriteLine("THRID ARRAY");
            Console.WriteLine("===================================");
            int[,] arr3 = new int[4,4];

            int startingNumber = 4;
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    arr3[i, j] = startingNumber++;
                }
            }

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===================================");

            #endregion

        }
    }
}
