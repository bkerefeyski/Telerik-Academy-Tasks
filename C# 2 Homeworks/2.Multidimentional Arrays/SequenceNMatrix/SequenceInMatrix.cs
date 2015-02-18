//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define 
//as sets of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
/*
 * ha  fifi  ho  hi
 * fo   ha   hi  xx  ---> ha, ha, ha
 * xxx  ho   ha  xx
 */





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SequenceInMatrix
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("M = ");
        int m = int.Parse(Console.ReadLine());

        string[,] array = new string[n, m];
        // Read data from console
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write("Array[{0},{1}] = ", i, j);
                array[i, j] = Console.ReadLine();
            }
        }
        int count = 0;
        int bestCount = 0;
        string bestStr = "";
        //Check rows
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                if (array[row, col] == array[row, col + 1])
                {
                    count++;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestStr = array[row, col];
                }
            }
            count = 0;
        }
        //Check cols
        for (int col = 0; col < m; col++)
        {
            for (int row = 0; row < n - 1; row++)
            {
                if (array[row, col] == array[row + 1, col])
                {
                    count++;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestStr = array[row, col];
                }
            }
            count = 0;
        }
        //check diagonals
        for (int i = 0; i < bestCount + 1; i++) Console.Write(bestStr + ", ");

        for (int row = 0; row < n - 1; row++)
        {
            for (int col = 0; col < m - 1; col++)
            {
                for (int i = row, j = col; i < n && j < m; i++, j++)
                {
                    if (array[i, j] == array[i + 1, j + 1])
                    {
                        count++;
                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestStr = array[row, col];
                    }
                }
                count = 0;
            }

        }
        for (int i = 0; i < bestCount + 1; i++) Console.Write(bestStr + ", ");
    }
}