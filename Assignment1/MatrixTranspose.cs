using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class MatrixTranspose
    {
        public int[][] Transpose(int[][] matrix)
        {
            int rowLen = matrix.Length;
            int colLen = matrix[0].Length;
            int[][] result = new int[colLen][rowLen];
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen - 1; j++)
                {
                    result[j][i] = matrix[i][j];
                }
            }
            return result;

        }
    }
}
