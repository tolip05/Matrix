using System;
using System.Linq;

namespace reverseMatrix
{
    class reverse
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int totalCount = 0;

            int[][] firstMatrix = new int[rows][];
            int[][] secondMatrix = new int[rows][];
            int[][] finalMatrix = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                firstMatrix[row] = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                totalCount += firstMatrix[row].Length;
            }

            for (int row = 0; row < rows; row++)
            {
                secondMatrix[row] = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .Reverse()
                    .Select(int.Parse).ToArray();
                totalCount += secondMatrix[row].Length;
            }
            int colLenght = firstMatrix[0].Length + secondMatrix[0].Length;
            bool isFit = true;

        
            for (int row = 0; row < firstMatrix.Length; row++)
            {
                if (firstMatrix[row].Length + secondMatrix[row].Length != colLenght)
                {
                    isFit = false;
                    break;
                }
            }
            if (isFit)
            {
                for (int row = 0; row < firstMatrix.Length; row++)
                {
                    finalMatrix[row] = new int[colLenght];
                    for (int col = 0; col < firstMatrix[row].Length; col++)
                    {
                        finalMatrix[row][col] = firstMatrix[row][col];
                    }
                    int a = firstMatrix[row].Length;
                    for (int cols = firstMatrix[row].Length; cols < finalMatrix[row].Length; cols++)
                    {
                        finalMatrix[row][cols] = secondMatrix[row][cols - a];
                    }
                }
                foreach (var item in finalMatrix)
                {
                    Console.WriteLine($"[{String.Join(", ", item)}]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {totalCount}");
            }


            
            
            

        }
    }
}
