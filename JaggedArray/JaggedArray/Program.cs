using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[][] jaggedArr = new string[3][];
            string[] h_Xavier = new string[] { "Art", "Photography", "Sleeping" };
            string[] h_Sam = new string[2] ;
            string[] h_Niki = new string[] { "Swimming", "Running", "Skiiing" };


            jaggedArr[0] = h_Xavier;
            jaggedArr[1] = h_Sam;
            jaggedArr[2] = h_Niki;
            jaggedArr[3] = new string[] { "Boxing", "Gym", "Hockey", "Drawing" };

            jaggedArr[2][0] = "Dance";
            jaggedArr[2][1] = "Swimming";

            #region Syntax
            /*
            string[] strArr = new string[2];

            strArr[0] = "Xavier";
            strArr[1] = "Krystelle";

            jaggedArr[0] = new string[2];
            jaggedArr[1] = strArr;
            jaggedArr[1] = new string[] { "Sayu", "Hawaa", "Dwd", "Suu" };

            //first bracket is the index of the jagged array, and the second bracket is the for the index of the array is being stored inside the JaggedArray 
            //this is for the "UNKNOWN" ARRAY in line 19 at position 0
            jaggedArr[0][0] = "Sam";
            jaggedArr[0][1] = "Niki";
            jaggedArr[1][1] = "Krysy"; //Changing the value of Krystelle to Krysy
            */
            #endregion
        }
    }
}
