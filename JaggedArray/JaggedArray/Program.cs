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
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4 };
            jaggedArray[2] = new int[] { 11, 22 };
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 5, 6 };
            matrix[2] = new int[] { 7, 8, 9, 10 };
            for(int row = 0; row < matrix.Length; row++)
            {
                Console.Write("Row " + row + ": ");
                for(int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
            }
            int totalSum = matrix.SelectMany(subArray => subArray).Sum();
            Console.WriteLine("Total Sum: " + totalSum);
            int maxElement = matrix.SelectMany(mat => mat).Max();
            Console.WriteLine("Max: " + maxElement);
            var firstElements = matrix.Where(mat => mat.Length > 3).Select(mat => mat.First());
            Console.Write("First Elements of Long Rows: ");
            foreach (var element in firstElements)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
