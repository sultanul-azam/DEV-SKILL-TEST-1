using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummationOfDiagonalInputInTwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = 0;
            Console.Write("Enter you number : ");
            arraySize = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[arraySize, arraySize];
            int numberOfInput = arraySize * arraySize;
            
            for (int i = 0; i < numberOfInput; i++)
            {
                for (int j = 0; j < arraySize; j++)
                {
                    Console.Write("Please iinput number : ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }





            Console.ReadLine();
        }
    }
}
