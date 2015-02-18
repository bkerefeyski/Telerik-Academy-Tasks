//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:

//Example a)     Example b)     Example c)     Example d)
/* 1 5  9 13      1 8  9 16     7 11 14 16     1 12 11 10
 * 2 6 10 14      2 7 10 15     4  8 12 15     2 13 16  9
 * 3 7 11 15      3 6 11 14     2  5  9 13     3 14 15  8
 * 4 8 12 16      4 5 12 13     1  3  6 10     4  5  6  7
 * */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillMatrix
{
    static void PritArr(int[,] arr)
    {
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write(arr[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        Console.Write("Enter rows of matrix: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter cols of matrix: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrixA = new int[rows, cols];

        int startMatrixA = 1;

        //Example a)
        Console.WriteLine("Example a)");

        for (int col = 0; col < matrixA.GetLength(1); col++)
        {
            for (int row = 0; row < matrixA.GetLength(0); row++)
            {
                matrixA[row, col] = startMatrixA;
                startMatrixA++;
            }
        }

        PritArr(matrixA);


        //Example b)
        Console.WriteLine("Example b)");

        int startMatrixB = 1;
        int[,] matrixB = new int[rows, cols];

        for (int col = 0; col < matrixB.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrixB.GetLength(0); row++)
                {
                    matrixB[row, col] = startMatrixB;
                    startMatrixB++;
                }
            }
            else
            {
                for (int row = matrixB.GetLength(0) - 1; row >= 0; row--)
                {
                    matrixB[row, col] = startMatrixB;
                    startMatrixB++;
                }
            }
        }

        PritArr(matrixB);

        //Example c)
        Console.WriteLine("Example c)");
        int endMatrixC = rows * cols;
        int startMatrixC = 1;
        int[,] matrixC = new int[rows, cols];

        //Fill matrix below main diagonal
        for (int i = rows - 1; i >= 0; i--)
        {
            int r = i;
            int c = 0;
            while (r < rows && c < cols)
            {
                matrixC[r, c] = startMatrixC;
                r++;
                c++;
                startMatrixC++;
            }
        }
        //Fill matrix above main diagonal
        for (int i = 1; i < cols; i++)
        {
            int r = 0;
            int c = i;
            while (r < rows && c < cols)
            {
                matrixC[r, c] = startMatrixC;
                r++;
                c++;
                startMatrixC++;
            }
        }
        PritArr(matrixC);

        //Example d)
        Console.WriteLine("Example d)");

        int startMatrixD = 1;
        int[,] matrixD = new int[rows, cols];
        int offset = 0;
        int ROW = 0;
        int COL = 0;

        while (startMatrixD <= rows * cols)
        {
            for (ROW = offset; ROW < rows - offset; ROW++)
            {
                COL = offset;
                matrixD[ROW, COL] = startMatrixD;
                startMatrixD++;
            }
            for (COL = 1 + offset; COL < cols - offset; COL++)
            {
                ROW = rows - 1 - offset;
                matrixD[ROW, COL] = startMatrixD;
                startMatrixD++;
            }
            for (ROW = rows - 2 - offset; ROW >= offset; ROW--)
            {
                COL = cols - 1 - offset;
                matrixD[ROW, COL] = startMatrixD;
                startMatrixD++;
            }
            for (COL = cols - 2 - offset; COL >= offset + 1; COL--)
            {
                ROW = offset;
                matrixD[ROW, COL] = startMatrixD;
                startMatrixD++;
            }
            offset++;
        }

        PritArr(matrixD);

    }
}