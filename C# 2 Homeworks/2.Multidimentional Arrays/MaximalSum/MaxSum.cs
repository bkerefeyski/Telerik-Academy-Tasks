//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSum
{
    static void Main()
    {
        Console.WriteLine("Enter rows of matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter cols of matrix: ");
        int cols = int.Parse(Console.ReadLine());
        while (rows < 3 || cols < 3)
        {
            Console.WriteLine("Rows and cols should be >= 3");
            Console.WriteLine("Enter rows of matrix: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter cols of matrix: ");
            cols = int.Parse(Console.ReadLine());
        }

        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Fill the matrix: ");
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("Enter position [{0}, {1}] :", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        int currentSum = 0;
        for (int i = 0; i < rows - 2; i++)
        {
            for (int j = 0; j < cols - 2; j++)
            {
                currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] +
                    matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] +
                    matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = i;
                    bestCol = j;

                }
                currentSum = 0;
            }

        }
        Console.WriteLine("Best matrix 3x3:");
        for (int i = bestRow; i < bestRow + 3; i++)
        {
            for (int j = bestCol; j < bestCol + 3; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Best sum: " + bestSum);
    }
}